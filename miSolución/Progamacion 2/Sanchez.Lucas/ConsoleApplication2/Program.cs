using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase22Entidades;

/*Con eventos por ejemplo, yo puedo lanzar un evento cuando algo que no deseo se produce, y alguien lo va a capturar/procesar
 * y si nadie lo captura no pasa nada. A diferencia de las Excepciones. Además a diferencia de las excepciones, el programa podría
 * continuar normalmente aunque un "error" se haya producido. Un evento invoca a un "Delegado", el delegado en si no hace nada
 * lo que hace es pasar el evento a quien lo debe "tratar". "El delegado es un puntero a funciones". El delegado va a ir a una clase
 * que puede ser la misma u otra y ejecutará un método, que puede ser de instancia o de clase. La clase que lanza el evento se la conoce
 * como clase "emisora". El delegado enviará el evento a una clase "receptora". El evento a generar debe ser del tipo que el delegado
 * manipule. El delegado debe ser public para que la clase receptora también lo conozca. Si es privado o protected no se verá en todo
 * el proyecto.
 * Definición de un delegado: [mod. visibilidad] delegate TipoRetorno Identificador ([args]);
 * un namespace puede contener delegados.
 * Manejador de eventos.
*/

namespace Clase22Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e = new Empleado("Juan", "Perez", 200);

            Program p = new Program();

            e.SueldoEvent += Program.Hola;
            e.SueldoEvent += Program.ManejadorEventos; // <= 4 //El método vá sin paréntesis porque le estamos pasando la dirección de memoria.
            e.SueldoEvent += p.MiManejador; //pasandole un metodo de instancia.
            
            try
            {
                e.Sueldo = -20;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            e.Sueldo = 10000;

            Console.ReadLine();
        }

        private static void ManejadorEventos()// <= 3
                                              //retorna void y no recibe parámetros
        {
            Console.WriteLine("Se ha superado el límite del sueldo");
        }

        private static void Hola()// <= 3
        //retorna void y no recibe parámetros
        {
            Console.WriteLine("Probando");
        }

        private void MiManejador()
        {
            Console.WriteLine("Probando mi manejador de instancia");
        }
    }
}
