using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
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

            centralita += local1;
            centralita += provincial1;
            centralita += provincial1; //Agrego la misma llamada para comprobar que al existir dicha llamada en la lista
                                       //de centralita, no la vuelva a agregar.

            Console.WriteLine(centralita);

            Console.ReadLine();
        }
    }
}
