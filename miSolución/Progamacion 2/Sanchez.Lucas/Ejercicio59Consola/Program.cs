using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio59Librería;

namespace Ejercicio59Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a = new Auto("asd");
            Console.WriteLine(a.cantidadPuertas);
            Console.ReadLine();
        }
    }
}
