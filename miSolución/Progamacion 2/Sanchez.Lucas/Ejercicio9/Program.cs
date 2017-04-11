using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, i, j;

            Console.Write("Ingrese la altura de la media pirámide: ");
            

            while ((int.TryParse(Console.ReadLine(), out num)) != true || num < 1)
            {
                Console.Write("Debe ingresar un número y debe ser positivo, vuelva a intentar: ");
            }

            Console.Write("\n");

            for (i = 0; i < num; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
