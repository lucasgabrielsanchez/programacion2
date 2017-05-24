using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase15Libreria;
using Entidades.Externa;
using Entidades.Externa.Sellada;

namespace Clase15Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Persona per = new Persona("Carlos", "Suarez", 45, ESexo.Femenino);

            Console.WriteLine("Nombre: {0} -- Apellido: {1} -- Edad: {2} -- Sexo: {3}", per.Nombre, per.Apellido, per.Edad, per.Sexo);

            Console.WriteLine("-----------------");

            per.ObtenerInfo();

            Console.WriteLine("-----------------");

            //PersonaExterna perE = new PersonaExterna("Carlos", "Perez", 48, Entidades.Externa.ESexo.Masculino);

            
            HerenciaPersonaExterna perE = new HerenciaPersonaExterna("Carlos", "Perez", 48, Entidades.Externa.ESexo.Masculino);

            perE.ObtenerInfo();

            Console.WriteLine("-----------------");

            PersonaExternaSellada pES = new PersonaExternaSellada("Maria", "Gomes", 28, Entidades.Externa.Sellada.ESexo.Femenino);

            pES.ObtenerInfo();

            string hola = "hola";

            Console.WriteLine("");
            Console.WriteLine("Cantidad de letras de {0}: {1}",hola,hola.Cantidad());
                

            Console.ReadLine();
        }
    }
}
