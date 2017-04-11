using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Sello.mensaje = "Probando Programa";

            Console.WriteLine("El texto es: {0}", Sello.Imprimir());

            Console.ReadLine();

            Sello.Borrar();

            Console.WriteLine("El texto es: {0}", Sello.Imprimir());

            Console.ReadLine();

            Sello.mensaje = "Probando Programa";

            Sello.color = ConsoleColor.Cyan;

            Console.WriteLine("El texto es: {0}", Sello.ImprimirEnColor());

            Console.ReadLine();

            Console.Write("El texto es:\n{0}", Sello.MensajeArmado());

            Console.ReadLine();

            

           
        }
    }
}
