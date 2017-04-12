using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteandoSobrecargas
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSobrecarga testing = new TestSobrecarga(); //constructor por default

            testing.Inicializar("Hola");
            testing.Inicializar(5);
            testing.Inicializar(DateTime.Now);

            testing = new TestSobrecarga(5, "pepe"); //constructor sobrecargado con int y string como parametros

            testing = new TestSobrecarga("carlitos"); //constructor sobrecargado con string como parametro

            Console.WriteLine ("{0}", testing.Mostrar());

            Console.ReadLine();
        }

    }
}
