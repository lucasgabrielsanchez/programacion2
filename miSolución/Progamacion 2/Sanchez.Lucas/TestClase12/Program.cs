using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase12;

namespace TestClase12
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseUno C1 = new ClaseUno("string de clase 1 \n");

            //Console.WriteLine(C1.MostrarClaseUno() + "\n"); //prueba

            //Console.WriteLine(C1.TipoClaseUno + "\n"); //prueba

            ClaseDos C2 = new ClaseDos("juan ", "perez \n");

            //Console.WriteLine(C2.MostrarClaseDos() + "\n"); //prueba

            //Console.WriteLine(C2.TipoClaseDos + "\n"); //prueba

            ClaseTres C3 = new ClaseTres("uno", " dos", " tres \n");

            //Console.WriteLine(C3.TipoClaseTres + "\n"); //prueba

            //Console.WriteLine(C3.MostrarClaseTres()); //prueba

            Console.WriteLine("\n" + "recorriendo lista:" + "\n");

            List<ClaseUno> ListaClases = new List<ClaseUno>(); //Lista generica debe guardar a la clase principal ya que
                                                               //los hijos tambien pertenecen al padre, si lo hago al revez
            ListaClases.Add(C1);                               //poniendo a ClaseTres en la Lista, no va a tomar a la ClaseDos
            ListaClases.Add(C2);                               //ni a la ClaseUno ya que de la ClaseTres para abajo serian 
            ListaClases.Add(C3);                               //del mismo tipo.

            //foreach (ClaseUno item in ListaClases) //sin polimorfismo tengo que recorrer de esta el foreach y mostrar asi
                                                     //porque debo diferenciar cada tipo de objeto ya que el mostrar y la
                                                     //propiedad de cada uno es individual y debo discriminarlos
            //{
                
            //    if (item is ClaseTres)
            //    {
            //        Console.WriteLine(((ClaseTres)item).MostrarClaseTres() + "\n");

            //        Console.WriteLine(((ClaseTres)item).TipoClaseTres + "\n");
            //    }

            //    else if (item is ClaseDos) //se usa else if porque sino al ser el mismo objeto lo muestra en todos los if
            //    {
            //        Console.WriteLine(((ClaseDos)item).MostrarClaseDos() + "\n");

            //        Console.WriteLine(((ClaseDos)item).TipoClaseDos + "\n");
            //    }

            //    else if (item is ClaseUno) //se usa else if porque sino al ser el mismo objeto lo muestra en todos los if
            //    {
            //        Console.WriteLine(item.MostrarClaseUno() + "\n");

            //        Console.WriteLine(item.TipoClaseUno + "\n");
            //    }
            //}

            foreach (ClaseUno item in ListaClases)//con polimorfismo  evito lo de arriba, tener que diferenciar entre
            {
                Console.WriteLine(item.Mostrar());//metodos y propiedades de cada clase ya que la clase principal los tiene
                Console.WriteLine(item.Tipo);     //como virtual y los hijos como override. De este modo, al recorrer el foreach
                //el compilador sabe diferenciar a que metodo virtual u override debe invocar.

            }

            Console.WriteLine("\notro tipo de foreach: \n");

            foreach (ClaseUno item in ListaClases) //en este foreach al console.writeline se le pasa el item solo, ya que
            {                                      //sobreescribimos al ToString en cada clase y el console.writeline intenta
                Console.WriteLine(item);           //convertir implicimente en ToString al item.
                Console.WriteLine(item.Tipo);
            }
            
            Console.ReadKey();
        }
    }
}
