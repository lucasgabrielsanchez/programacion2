using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase13;


namespace Clase13Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto autito = new Auto(4, Evelocidad.Media, 4);
            Cohete cohe = new Cohete(18, Evelocidad.Hiper, "Lumia5", 40);
            Caballo cab = new Caballo(2, Evelocidad.Baja, "Danés");


            Console.Write(autito.Detalle + "\n");
            Console.WriteLine(autito.Acelerar());
            Console.WriteLine(autito.Frenar());

            Console.WriteLine("");

            Console.Write(cohe.Detalle + "\n");
            Console.WriteLine(cohe.Acelerar());
            Console.WriteLine(cohe.Frenar());

            Console.WriteLine("");

            Console.Write(cab.Detalle + "\n");
            Console.WriteLine(cab.Acelerar());
            Console.WriteLine(cab.Frenar());

            Console.ReadLine();

            List<Transporte> listaT = new List<Transporte>();

            listaT.Add(autito);
            listaT.Add(cohe);
            listaT.Add(cab);

            //foreach (Transporte item in listaT)
            //{
            //    if (item is Auto)
            //    {
            //        Console.WriteLine(((Auto)item).Detalle);
            //        Console.WriteLine(((Auto)item).Acelerar());
            //        Console.WriteLine(((Auto)item).Frenar());
            //    }

            //    if (item is Cohete)
            //    {
            //        Console.WriteLine(((Cohete)item).Detalle);
            //        Console.WriteLine(((Cohete)item).Acelerar());
            //        Console.WriteLine(((Cohete)item).Frenar());
            //    }

            //    if (item is Caballo)
            //    {
            //        Console.WriteLine(((Caballo)item).Detalle);
            //        Console.WriteLine(((Caballo)item).Acelerar());
            //        Console.WriteLine(((Caballo)item).Frenar());
            //    }
            //}

            foreach (Transporte item in listaT)
            {
                Console.WriteLine(item.Detalle);
                Console.WriteLine(item.Acelerar());
                Console.WriteLine(item.Frenar() + "\n");
            }


            Console.ReadLine();




        }
    }
}
