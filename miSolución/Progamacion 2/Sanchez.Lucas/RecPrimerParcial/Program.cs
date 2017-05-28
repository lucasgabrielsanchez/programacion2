using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Jugo jugo = new Jugo(1122, EMarcaProducto.Naranjú, 45.8f, ESaborJugo.Rico);

            Console.WriteLine(jugo.CalcularCostoDeProduccion);
            Console.WriteLine(jugo.ToString());

            Galletita galle = new Galletita(4568, EMarcaProducto.Pitusas, 38, 580);
            Console.WriteLine(galle.CalcularCostoDeProduccion);
            Console.WriteLine(galle.ToString());

            Console.ReadLine();
        }
    }
}
