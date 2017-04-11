using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio Nro 1";
            //Console.ReadLine();

            int maximo = 0, minimo = 0, escalar, i, acum = 0;
            bool pepito;

            for (i = 0; i < 5; i++)
            {

               Console.Write("Ingrese un número: ");

               while ((int.TryParse(Console.ReadLine(), out escalar)) != true)
                {
                    Console.Write("El dato ingresado no es numérico, reingréselo: ");
                }

                //if ((int.TryParse(Console.ReadLine(), out escalar)) == true)
               
                    if (i == 0)
                    {
                        minimo = escalar;
                        maximo = escalar;
                    }

                    if (escalar < minimo)
                    {
                        minimo = escalar;
                    }

                    if (escalar > maximo)
                    {
                        maximo = escalar;
                    }

                    acum += escalar;

            } 

            Console.WriteLine("El mínimo es: {0}, El máximo es: {1}, El promedio es: {2}", minimo, maximo, (float)acum/5);
            Console.ReadLine();

        }
    }
}
