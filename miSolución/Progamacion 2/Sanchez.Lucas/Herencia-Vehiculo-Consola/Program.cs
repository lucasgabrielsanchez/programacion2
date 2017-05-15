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
            //Vehiculo vehiculo = new Vehiculo("xD", 6, EMarcas.Zanella);
            //Vehiculo vehiculo1 = new Vehiculo("xD", 8, EMarcas.Zanella);
            //Vehiculo vehiculo2 = new Vehiculo("XP", 10, EMarcas.Iveco);

            Moto motito = new Moto(1, 500, 900, "CGFTR", 2, EMarcas.Honda);
            Moto motito1 = new Moto(2, 600, 300, "CHJRYF", 2, EMarcas.Zanella);
            Camion camionsito = new Camion(2, 9000, 500, "AUEDYTS", 8, EMarcas.Scania);
            Auto autito = new Auto(4, 6000, 600, "BSUDHE", 4, EMarcas.Ford);
            Auto autito1 = new Auto(6, 4500, 350, "LSOKDO", 4, EMarcas.Fiat);
            //Console.WriteLine(vehiculo.Marca + "\n" + vehiculo.Patente + "\n"); //Probando propiedades Marca y Patente
            

            //if (vehiculo == vehiculo1) //probando funcionamiento del operador + sobrecargado
            //    Console.WriteLine("Son iguales\n");
            //else
            //    Console.WriteLine("Son distintos\n");

           

            //Console.WriteLine(motito.MostrarMoto());

            Lavadero lav = new Lavadero(500, 600, 700);

            //lav._vehiculos.Add(motito); //antes probaba poniendo public a la lista
            //lav._vehiculos.Add(motito1);//de vehiculos para probar cargarle objetos
            //lav._vehiculos.Add(camionsito);
            //lav._vehiculos.Add(autito);

            //agregando vehiculos al lavadero con la propiedad que me trae la lista de vehiculos
            //lav.Vehiculos.Add(motito); //utilizo la propiedad Vehiculos definida en Lavadero
            //lav.Vehiculos.Add(motito1);//la cual en su get me retorna a la lista privada de vehiculos que tiene
            //lav.Vehiculos.Add(camionsito);//Lavadero adentro, para poder agregarle objetos.
            //lav.Vehiculos.Add(autito);

            //agregando vehiculos al lavadero con el operador +
            lav += motito;
            lav += autito;
            lav += autito1;
            lav += camionsito;
            lav += camionsito; //agrego el mismo camion al lavadero pero como ya existe no lo agrega y se demuestra
                               //en el resultado que arroja la consola.

            //ordeando vehiculos
            //lav._vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente); //Pasamos la direccion de memoria del metodo .OrdenarVehiculosPorPatente que va a funcionar en la lista
                                                                        //a la que le paso dicho metodo delante del Sort para ordenar sus elementos

            //lav._vehiculos.Sort(lav.OrdenarVehiculosPorMarca); //Pasamos la direccion de memoria del metodo OrdenarVehiculosPorMarca que va a funcionar en la lista
                                                                 //a la que le paso dicho metodo delante del Sort para ordenar sus elementos
            Console.WriteLine(lav.LavaderoString);

            Console.WriteLine("El total facturado es: " + lav.MostrarTotalFacturado());

            Console.WriteLine("El total facturado por motos es: " + lav.MostrarTotalFacturado(EVehiculos.Moto));


            // probando si tal vehiculo esta dentro del lavadero
            if (lav == motito)
                Console.WriteLine("\nLa motito existe en el lavadero\n");
            else
                Console.WriteLine("\nLa motito NO existe en el lavadero\n");

            if (lav == autito1)
                Console.WriteLine("\nEl autito existe en el lavadero\n");
            else
                Console.WriteLine("\nEl autito NO existe en el lavadero\n");


            Console.ReadKey();

            lav -= motito;
            lav -= autito1;

            Console.WriteLine(lav.LavaderoString);

            Console.ReadKey();
        }
    }
}
