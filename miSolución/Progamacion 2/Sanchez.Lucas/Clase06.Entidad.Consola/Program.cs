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
            Tempera temI = new Tempera(ConsoleColor.Blue, "Colorin", 16);
            Tempera tem1 = new Tempera(ConsoleColor.Cyan, "xD", 5);
            
            Console.WriteLine(Tempera.Mostrar(tem));

            if (tem == temI) //testeando igualdad de temperas
                Console.WriteLine("\nSon temperas iguales");

            Console.WriteLine("\n"+(string)tem); //testeado casteo explicito de tempera

            int a = tem;

            Console.WriteLine("\nLa cantidad casteada implicitamente de tem es: " + a); // testeando el casteo implicito de tempera

            tem = tem + temI;

            Console.WriteLine("\nLa suma de las temperas iguales da: \n" + (string)tem); // testeando la suma de temperas

            Console.Read();

            //Testeando Paleta

            Paleta asd = new Paleta(4);

            asd = asd + tem; //le sumo a paleta una tempera

            asd = asd + tem;//le sumo a paleta la misma tempera para que incremente la cantidad de la tempera dentro de la paleta

            asd = asd + tem1;//le sumo a paleta, una tempera distinta

            //asd = asd - tem;

            //asd = asd + asd;// testeando suma de paletas

            Console.ReadKey();




            

        }
    }
}
