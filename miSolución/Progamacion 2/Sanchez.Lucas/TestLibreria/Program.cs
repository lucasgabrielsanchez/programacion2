using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestLibreria
{
    class Program
    {
        static void Main(string[] args)
            
        {
            TestSobrecarga xD = new TestSobrecarga(18,"pepitosuarez");

            Console.WriteLine("{0}", xD.Mostrar());

            Console.ReadLine();

            xD.Inicializar("ahrre");
            xD.Inicializar(DateTime.Now);
            xD.Inicializar(468);

            Console.WriteLine("{0}", xD.Mostrar());

            Console.ReadLine();
            


        }
    }
}
