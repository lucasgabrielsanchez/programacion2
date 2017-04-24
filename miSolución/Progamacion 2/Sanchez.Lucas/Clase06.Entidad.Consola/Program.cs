using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase06.Entidad;

namespace Clase06.Entidad.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //int asdd;
            //Paleta asd = new Paleta(18);
            //asdd = asd._colores.GetLength(0);

            //Testeando Tempera
            Tempera tem = new Tempera(ConsoleColor.Blue, "Colorin", 16);

            Console.WriteLine(Tempera.Mostrar(tem));

            Console.Read();

            //Testeando Paleta

            Paleta asd = new Paleta(4);

            Console.WriteLine(asd.Mostrar());

            Console.ReadKey();




            

        }
    }
}
