using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase19BaseDeDatosLibrería;

namespace Clase19BaseDeDatosConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            ConexionABaseDeDatos xD = new ConexionABaseDeDatos();

            foreach (Persona item in xD.TraerTodos())
            {
                Console.WriteLine(item);
            }

            Persona probar = new Persona();

            probar.nombre = "Lucas";
            probar.apellido = "Sanchez";
            probar.edad = 24;

            Persona probar2 = new Persona(6, "Luquitas", "Sanchezitos", 26);

            //xD.Agregar(probar);
            //xD.Modificar(probar2);
            //xD.Borrar(7);
            //xD.Borrar(8);
            //xD.Borrar(9);
            //xD.Borrar(10);
            //xD.Borrar(11);
            //xD.Borrar(12);
            //xD.Borrar(13);

            //foreach (Persona item in xD.TraerTodos())
            //{
            //    Console.WriteLine(item);
            //}
           
            Console.ReadLine();
        }
    }
}
