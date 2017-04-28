using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alumno asd = new Alumno("Pepe", "Suarez", 45879445);
            Alumno asd = new Alumno("Pepe", "Suarez", 45879445,"1º Gº");
            Alumno asd1 = new Alumno("Jorge", "Ramirez", 454679445, "5º Fº");
            Console.WriteLine(asd.Mostrar());

            //Obrero obr = new Obrero("Emiliano", 45332119, "Villalba");
            Obrero obr = new Obrero("Emiliano", 45332119, "Villalba",6,800);
            Obrero obr1 = new Obrero("Micaela", 45332543, "Gonzales", 7, 9000);
            Console.WriteLine(Obrero.Mostrar(obr));

            //if (asd is Persona)
            //    Console.WriteLine("Es una persona");
            //else
            //    Console.WriteLine("No es una persona");

            

            List<Persona> pList = new List<Persona>(); //Comprobando que Alumno y Obrero son personas porque permite
                                                       //guardar dichos objetos a la lista de Personas.
            pList.Add(asd);//admite asd, porque es una persona
            pList.Add(asd1);
            pList.Add(obr);//admite asd, porque es una persona
            pList.Add(obr1);

            foreach (Persona per in pList)
            {
                if (per is Alumno)
                {
                    Console.WriteLine("\nEs Alumno\n");
                    Console.WriteLine(((Alumno)per).Mostrar());
                }



                if (per is Obrero)
                {
                    Console.WriteLine("\nEs Obrero");
                    Console.WriteLine((Obrero.Mostrar((Obrero)per)));
                }
            }

            

            

            Console.ReadKey();
        }
    }
}
