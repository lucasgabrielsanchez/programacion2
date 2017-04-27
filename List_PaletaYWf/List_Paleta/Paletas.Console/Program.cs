using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase06.Paletas.Entidades;

namespace Paletas.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Paleta oPaleta = new Paleta();
            Tempera tempera1 = new Tempera(ConsoleColor.Blue, "faber", 2);
            Tempera tempera2 = new Tempera(ConsoleColor.Red, "alba", 3);
            Tempera tempera3 = new Tempera(ConsoleColor.Green, "faber", 4);
            Tempera tempera4 = new Tempera(ConsoleColor.Red, "faber", 2);
            Tempera tempera5 = new Tempera(ConsoleColor.Green, "alba", 5);

            oPaleta.Colores.Add(tempera1);
            oPaleta.Colores.Add(tempera2);
            oPaleta.Colores.Add(tempera3);
            oPaleta.Colores.Add(tempera4);
            oPaleta.Colores.Add(tempera5);
            int salir = 0;
            int opcion = 0;
            do
            {
                Console.WriteLine("SELECCIONE UNA OPCION:\n" + "1. Agregar tempera.\n" + "2. Usar tempera.\n" + "3. Listar temperas de paleta.");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:
                        AgregarTempera(oPaleta);
                        break;
                    case 2:
                        break;
                    case 3:
                        //ListarTemperas(oPaleta);
                        break;
                    default:
                        salir = 9;
                        break;
                }
                
            } while (salir != 9);

        }
        static void AgregarTempera(Paleta oPaleta)
        {
            ConsoleColor color;
            string marca;
            int cantidad;
            Console.WriteLine("Ingrese color: ");
            ConsoleColor.TryParse(Console.ReadLine(), out color);

            Console.WriteLine("Ingrese marca: ");
            marca = Console.ReadLine();

            Console.WriteLine("Ingrese cantidad: ");
            int.TryParse(Console.ReadLine(), out cantidad);

            Tempera tempera6 = new Tempera(color, marca, cantidad);
            oPaleta.Colores.Add(tempera6);
        }
        //static void ListarTemperas(Paleta oPaleta)
        //{
        //    string listado = (string)oPaleta;
        //    Console.WriteLine(listado);
        //    Console.ReadLine();
        //}
    }
}
