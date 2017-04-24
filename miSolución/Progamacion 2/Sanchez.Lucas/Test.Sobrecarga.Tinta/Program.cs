using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Sobrecarga; //Poniendo este using evito tener que escribir toda la ruta
                            //para acceder a las clases de Entidades.Sobrecarga, si no lo
                            //escribo por ejemplo debería escribir  Entidades.Sobrecarga.Tinta pepito = new Entidades.Sobrecarga.Tinta()

namespace Test.Sobrecarga.PlumaTinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta pepito = new Tinta();
            Tinta pepito1 = new Tinta(ConsoleColor.Black);
            Tinta pepito2 = new Tinta(ETipo.ConBrilito, ConsoleColor.Green);

            Console.WriteLine("{0}", Tinta.Mostrar(pepito));
            Console.ReadLine();
            Console.WriteLine("{0}", Tinta.Mostrar(pepito1));
            Console.ReadLine();
            Console.WriteLine("{0}", Tinta.Mostrar(pepito2));
            Console.ReadLine();

            if (pepito == pepito)
                Console.WriteLine("Son Iguales");
            else
                Console.WriteLine("No Son Iguales");

            Console.ReadLine();

            if (pepito != pepito)
                Console.WriteLine("Son Iguales");
            else
                Console.WriteLine("No Son Iguales");

            Console.ReadLine();

            Entidades.Sobrecarga.Pluma plumita = new Entidades.Sobrecarga.Pluma(1, "faber", pepito2);

            Console.WriteLine("{0}", plumita.Mostrar());

            Console.ReadLine();

            if (pepito2 == plumita)
                Console.Write("Son Iguales");
            else
                Console.Write("No Son Iguales");

            Console.ReadLine();


              //testeando el uso de un atributo estático, no se pide en el ejercicio, en la clase Tinta está la declaración

              Console.WriteLine("\n" + Tinta.numeroPrueba);

              Console.ReadLine();

              Tinta.numeroPrueba = 19;

              Console.WriteLine(Tinta.numeroPrueba + "\n");

              Console.ReadLine();

        }
    }
}
