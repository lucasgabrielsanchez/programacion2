using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2ParcialLibrería;

namespace _2ParcialConsola
{
    class Program
    {
        private static bool Serializar(ISerializable obj)
        {
            return obj.SerializarXML();
        }

        private static bool Deserializar(ISerializable obj)
        {
            return obj.Deserializar();
        }

        private static void Main(string[] args)
        {
            Platano p1 = new Platano(0.5f, ConsoleColor.Yellow, "Argentina");
            Platano p2 = new Platano(0.6f, ConsoleColor.Green, "Bolivia");
            Platano p3 = new Platano(0.7f, ConsoleColor.Yellow, "Tailandia");

            Manzana m1 = new Manzana(0.2f, ConsoleColor.Red, "Arcor");
            Manzana m2 = new Manzana(0.3f, ConsoleColor.Green, "Manaos");
            Manzana m3 = new Manzana(0.4f, ConsoleColor.Red, "Terrabusi");


            //Cajón de Plátanos
            Cajon<Platano> cp = new Cajon<Platano>(2, 500);

            try
            {
                cp += p1;
                cp += p2;
                cp += p3;
            }
            catch (CajonLlenoException c)
            {
                Console.WriteLine(c.Message);
            }

            Console.WriteLine(cp);

            if (cp.ImprimirTicket("CajónDePlátanos.txt"))           
                Console.WriteLine("El Ticket Pudo ser impreso");
            else
                Console.WriteLine("El Ticket No Pudo ser impreso");

            Console.ReadLine();
            Console.Clear();

            //Cajón de Manzanas
            Cajon<Manzana> cm = new Cajon<Manzana>(2, 200);

            try
            {
                cm += m1;
                cm += m2;
                cm += m3;
            }
            catch (CajonLlenoException c)
            {
                Console.WriteLine(c.Message);
            }

            Console.WriteLine(cm);

            Console.ReadLine();
            Console.Clear();

            //Cajón de Frutas
            Cajon<Fruta> cf = new Cajon<Fruta>(2, 800);

            //try
            //{
                cf += p1;
                cf += p2;
                cf += p3;
                cf += m1;
                cf += m2;
                cf += m3;
            //}
            //catch (CajonLlenoException c)
            //{
            //    Console.WriteLine(c.Message);
            //}

            Console.WriteLine(cf);



            /*invocando a "RutaDeArchivo" en cada objeto, estoy accediendo a la propiedad que implementan "Manzana" y "Cajon" de la interface ISerializable.
             Si le paso una ruta a cada objeto instanciado, éste se guardará en dicha ruta, ya que la propiedad fué escrita de manera "autodefinida" y por ende
             se comporta como si fuese un atributo. Por esta razón me permite indicarle a cada objeto en particular, el path y el nombre con el que lo deseo guardar
             al ser serializado.*/
            m1.RutaDeArchivo = AppDomain.CurrentDomain.BaseDirectory + "Manzana.xml";
            if (Program.Serializar(m1))
                Console.WriteLine("El objeto pudo ser serializado");
            else
                Console.WriteLine("El objeto no pudo ser serializado");

            cp.RutaDeArchivo = AppDomain.CurrentDomain.BaseDirectory + "CajónDePlátanos.xml";
            if (Program.Serializar(cp))
                Console.WriteLine("El objeto pudo ser serializado");
            else
                Console.WriteLine("El objeto no pudo ser serializado");

            cf.RutaDeArchivo = AppDomain.CurrentDomain.BaseDirectory + "CajónDeFrutas.xml";
            if (Program.Serializar(cp))
                Console.WriteLine("El objeto pudo ser serializado");
            else
                Console.WriteLine("El objeto no pudo ser serializado");

            Console.ReadLine();
        }
    }
}
