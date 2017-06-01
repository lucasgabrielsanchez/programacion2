using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Privado priv = new Privado(500, 65465, 50);
            Comercial com = new Comercial(400, 98798798, 8);
            Deportivo dep = new Deportivo(800, "AS644AS", 800);
            Carreta carr = new Carreta(900);
            Avion avion = new Avion(400, 800000);

            

            List<IAFIP> listaAfip = new List<IAFIP>();

            listaAfip.Add(priv);
            listaAfip.Add(com);
            listaAfip.Add(dep);
            listaAfip.Add(avion);

            Console.WriteLine("Mostrando IAFIP");

            foreach (IAFIP item in listaAfip)
            {
                Console.WriteLine(Gestion.MostrarImpuestoNacional(item));
                // ó Console.WriteLine(item.CalcularImpuesto());
                
            }

            List<IARBA> listaArba = new List<IARBA>();

            Console.WriteLine("Mostrando ARBA");

            foreach (IARBA item in listaAfip)
            {
                Console.WriteLine(Gestion.MostrarImpuestoProvincial(item));
                // ó Console.WriteLine(item.CalcularImpuesto());
                
            }

            //Mostrando un objeto que tiene ambas interfaces
            Console.WriteLine("Mostrando ARBA y AFIP");
            Console.WriteLine(((IAFIP)dep).CalcularImpuesto());
            Console.WriteLine(((IARBA)dep).CalcularImpuesto());

            Console.WriteLine(dep.MostrarImpuestoNacional());
            Console.WriteLine(dep.MostrarImpuestoProvincial());

            //Console.WriteLine("Impuesto Avion Privado: " + Gestion.MostrarImpuestoNacional(priv));
            //Console.WriteLine("Impuesto Avion Comercial: " + Gestion.MostrarImpuestoNacional(com));
            //Console.WriteLine("Impuesto Auto Deportivo: " + Gestion.MostrarImpuestoNacional(dep));
            

            Console.ReadLine();
        }
    }
}
