using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herencia_Vehiculo;

namespace Herencia_Vehiculo_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo autito = new Vehiculo("xD", 6, EMarcas.Zanella);
            Vehiculo autito2 = new Vehiculo("xD", 8, EMarcas.Zanella);
            Vehiculo autito3 = new Vehiculo(":P", 10, EMarcas.Iveco);
            Console.WriteLine(autito.Marca + "\n" + autito.Patente + "\n"); //Probando propiedades Marca y Patente
            

            if (autito + autito3) //probando funcionamiento del operador + sobrecargado
                Console.WriteLine("Son iguales\n");
            else
                Console.WriteLine("Son distintos\n");

            Moto motito = new Moto(4, 500, 900, "HGFTR", 4, EMarcas.Honda);

            Console.WriteLine(motito.MostrarMoto());
           

            Console.ReadKey();
        }
    }
}
