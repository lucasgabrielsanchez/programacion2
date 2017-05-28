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
            //Temas de la clase: Métodos de extensión.
            //Objetivos de la clase: En esta clase lo que se busca es recibir 2 archivos .DLL (librerías de clase, ubicadas en miSolución\Progamacion 2\Sanchez.Lucas\Clase15Libreria), con el fin 
            //de utilizarlas y obtener de ellas utilidades, métodos, propiedades, etc. El desafío de esto está en que estas DLL, cada una de ellas tiene cierto grado de resticción, lo que nos
            //dificulta la tarea de poder extraer de ellas lo necesario para podes utilizarlas a nuestro gusto. Para utilizar dichas librerías, debemos referenciarlas tanto en el proyecto de Consola
            //como en nuestra librería. Para ello hacemos click derecho sobre nuestro proyecto de consola/librería -> agregar referencia -> examinar y buscamos y seleccionamos las dll deseadas.
            //Luego, se deben agregar las sentencias using para poder utilizar dichos dll sin hacer referencia a su ruta completa.

            Console.ForegroundColor = ConsoleColor.Cyan;

            Persona per = new Persona("Carlos", "Suarez", 45, ESexo.Femenino);

            Console.WriteLine("Nombre: {0} -- Apellido: {1} -- Edad: {2} -- Sexo: {3}", per.Nombre, per.Apellido, per.Edad, per.Sexo);

            Console.WriteLine("-----------------");

            per.ObtenerInfo();

            Console.WriteLine("-----------------");

            //Creamos una instancia de nuestra herencia que hereda del dll con atributos y propiedades protegidas.
            //Debemos marcar la ruta completa del enumerado porque tiene el mismo nombre en las 2 dll y en nuestra propia clase, sino, el compilador no sabe a cual ir.
            HerenciaPersonaExterna perE = new HerenciaPersonaExterna("Carlos", "Perez", 48, Entidades.Externa.ESexo.Masculino);

            perE.ObtenerInfo();

            Console.WriteLine("-----------------");

            //Creamos una instancia del dll que se encuentra sellado y luego utilizamos el método que agregamos forzadamente a dicha instancia.
            //Debemos marcar la ruta completa del enumerado porque tiene el mismo nombre en las 2 dll y en nuestra propia clase, sino, el compilador no sabe a cual ir.
            PersonaExternaSellada pES = new PersonaExternaSellada("Maria", "Gomes", 28, Entidades.Externa.Sellada.ESexo.Femenino);

            //Método de extensión, "agregado forzadamente".
            pES.ObtenerInfo();

            string hola = "equisDe";

            Console.WriteLine("");
            Console.WriteLine("Cantidad de letras de {0}: {1}", hola, hola.Cantidad());//Método de extensión,"agregado forzadamente".
                

            Console.ReadLine();
        }
    }
}
