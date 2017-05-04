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
            Vehiculo vehiculo = new Vehiculo("xD", 6, EMarcas.Zanella);
            Vehiculo vehiculo1 = new Vehiculo("xD", 8, EMarcas.Zanella);
            Vehiculo vehiculo2 = new Vehiculo("XP", 10, EMarcas.Iveco);
            Moto motito = new Moto(1, 500, 900, "CGFTR", 2, EMarcas.Honda);
            Camion camionsito = new Camion(2, 9000, 500, "AUEDYTS", 8, EMarcas.Scania);
            Auto autito = new Auto(4, 6000, 600, "BSUDHE", 4, EMarcas.Ford);
            //Console.WriteLine(vehiculo.Marca + "\n" + vehiculo.Patente + "\n"); //Probando propiedades Marca y Patente
            

            //if (vehiculo == vehiculo1) //probando funcionamiento del operador + sobrecargado
            //    Console.WriteLine("Son iguales\n");
            //else
            //    Console.WriteLine("Son distintos\n");

           

            //Console.WriteLine(motito.MostrarMoto());

            Lavadero lav = new Lavadero(500, 600, 700);

            lav._vehiculos.Add(motito);
            lav._vehiculos.Add(camionsito);
            lav._vehiculos.Add(autito);

            //lav._vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente); //Pasamos la direccion de memoria del metodo .OrdenarVehiculosPorPatente que va a funcionar en la lista
                                                                        //a la que le paso dicho metodo delante del Sort para ordenar sus elementos

            //lav._vehiculos.Sort(lav.OrdenarVehiculosPorMarca); //Pasamos la direccion de memoria del metodo OrdenarVehiculosPorMarca que va a funcionar en la lista
                                                                 //a la que le paso dicho metodo delante del Sort para ordenar sus elementos
            Console.WriteLine(lav.LavaderoString);

            Console.ReadKey();
        }
    }
}
