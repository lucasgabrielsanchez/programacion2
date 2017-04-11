using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Ingrese el número que desea elevar: ");

            int.TryParse(Console.ReadLine(), out num);
        }
    }
}
