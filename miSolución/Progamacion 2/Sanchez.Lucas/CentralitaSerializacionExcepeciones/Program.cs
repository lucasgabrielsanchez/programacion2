using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CentralitaSerializacionExcepeciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita centralita = new Centralita("Telefonica");

            Local local1 = new Local("1234", "4321", 0.30f, 2.65f);
            Provincial provincial1 = new Provincial("4444", Franja.Franja_1, 0.21f, "5555");
            Local local2 = new Local("9999", "3333", 0.45f, 1.99f);

            //Utilizo los atributos desglozados del objeto provincial1 para pasarlos como parámetro a provincial2.
            Provincial provincial2 = new Provincial(provincial1.NroOrigen, Franja.Franja_3, provincial1.Duracion, provincial1.NroDestino);

            try
            {
                centralita += local1;
                centralita += provincial1;
                centralita += provincial1; //Agrego la misma llamada para comprobar que al existir dicha llamada en la lista
                                           //de centralita, no la vuelva a agregar.
                centralita += local2;
                centralita += provincial2;
            }
            catch (CentralitaException cE)
            {
                Console.WriteLine("La excepción es: {0} - La clase que la causó es: {1} - El método que lo causó es: {2}", cE.Message, cE.NombreClase, cE.NombreMetodo);
            }

            Console.WriteLine(centralita);

            centralita.RutaDeArchivo = (AppDomain.CurrentDomain.BaseDirectory + "Centralita.xml");

            try
            {
                centralita.Serializarse();
                Console.WriteLine("Serialización Exitosa.");
            }

            catch (CentralitaException C)
            {
                Console.WriteLine("La excepción es: {0} - La clase que la causó es: {1} - El método que lo causó es: {2}", C.ExcepcionInterna.Message, C.NombreClase, C.NombreMetodo);
            }

            try
            {
                centralita.Deserializarse();
                Console.WriteLine("Deserialización Exitosa.");
            }
            
            catch (CentralitaException C)
            {
                Console.WriteLine("La excepción es: {0} - La clase que la causó es: {1} - El método que lo causó es: {2}", C.ExcepcionInterna.Message, C.NombreClase, C.NombreMetodo);
            }

            centralita.OrdenarLlamadas();

            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Lista ordenada:");

            Console.WriteLine(centralita);


            Console.WriteLine("Leyendo archivo de texto\n");
            try
            {
                StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Llamadas.txt");

                Console.WriteLine(sr.ReadToEnd());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
