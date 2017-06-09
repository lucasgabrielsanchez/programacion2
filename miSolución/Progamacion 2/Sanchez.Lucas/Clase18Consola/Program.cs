using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase18Librería;

namespace Clase18Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Auto a = new Auto("azul", "Chevrolet");
            //Auto b = new Auto("azul", "Chevrolet");
            //Auto c = new Auto("negro", "Nose");
            //Auto d = new Auto("rojo", "NiIdea");

            //DepositoDeAutos dda = new DepositoDeAutos(2);

            //dda.Agregar(a);
            //dda.Agregar(b);
            //dda.Agregar(c);
            //dda.Agregar(d);

            //Console.WriteLine(dda);

            //Console.ReadLine();

            Auto a1 = new Auto("Rojo", "Ferrari");
            Auto a2 = new Auto("Amarillo", "Porche");
            Auto a3 = new Auto("Negro", "BMW");
            Auto a4 = new Auto("Verde", "Ford");
            DepositoDeAutos da = new DepositoDeAutos(3);
            if ((da + a1))
            {
            Console.WriteLine("Se ha agregado el item!!!");
            }
            da.Agregar(a2);
            da.Agregar(a3);
            if (!da.Agregar(a4))
            {
            Console.WriteLine("No se pudo agregar el item!!!");
            }
            Console.WriteLine(da);
            da.Remover(a2);
            if (!(da - a4))
            {
            Console.WriteLine("No se pudo remover el item!!!");
            }
            Console.WriteLine(da);

            Console.ReadLine();
            Console.Clear();


            Bicicleta b1 = new Bicicleta("Shimano", 26f, 4500f);
            Bicicleta b2 = new Bicicleta("Mountain", 25f, 4000f);
            Bicicleta b3 = new Bicicleta("asd", 25f, 4000f);
            Bicicleta b4 = new Bicicleta("oij", 25f, 4000f);

            DepositoDeBicicletas ddb = new DepositoDeBicicletas(3);

            ddb.Agregar(b1);
            ddb.Agregar(b2);
            ddb.Agregar(b3);
            ddb.Agregar(b4);

            Console.WriteLine(ddb);

            Console.ReadLine();
            Console.Clear();

            Cocina c1 = new Cocina(111, 12300, false);
            Cocina c2 = new Cocina(112, 15000, true);
            Cocina c3 = new Cocina(113, 5600, false);
            DepositoDeCocinas dc = new DepositoDeCocinas(5);
            dc.Agregar(c1);
            dc.Agregar(c2);
            if (!(dc + c3))
            {
                Console.WriteLine("No se pudo agregar el item!!!");
            }
            Console.WriteLine(dc);
            dc.Remover(c2);
            if (!(dc - c2))
            {
                Console.WriteLine("No se pudo remover el item!!!");
            }
            Console.WriteLine(dc);
           
            Console.ReadLine();
            Console.Clear();

            //terminar esta parte
            Cocina cc1 = new Cocina(111, 12300, false);
            Cocina cc2 = new Cocina(112, 15000, true);
            Cocina cc3 = new Cocina(113, 5600, false);
            Auto aa1 = new Auto("Rojo", "Ferrari");
            Auto aa2 = new Auto("Amarillo", "Porche");
            Auto aa3 = new Auto("Negro", "BMW");
            Auto aa4 = new Auto("Verde", "Ford");
            Deposito_Genérico<Cocina> ddc = new Deposito_Genérico<Cocina>(5);
            Deposito_Genérico<Auto> dda = new Deposito_Genérico<Auto>(3);
            dc.Agregar(c1);
            dc.Agregar(c2);
            if (!(dc + c3))
            {
            Console.WriteLine("No se pudo agregar el item!!!");
            }
            if ((da + a1))
            {
            Console.WriteLine("Se ha agregado el item!!!");
            }
            da.Agregar(a2);
            da.Agregar(a3);
            if (!da.Agregar(a4))
            {
            Console.WriteLine("No se pudo agregar el item!!!");
            }
            Console.WriteLine(dc);
            Console.WriteLine(da);
            dc.Remover(c2);
            if (!(dc - c2))
            {
            Console.WriteLine("No se pudo remover el item!!!");
            }
            da.Remover(a2);
            if (!(da - a4))
            {
            Console.WriteLine("No se pudo remover el item!!!");
            }
            Console.WriteLine(dc);
            Console.WriteLine(da);
            
            Console.ReadLine();
           
 
        }
    }
}
