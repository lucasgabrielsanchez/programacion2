using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase17;
using System.IO; //agrego esta librería de clases para poder serializar/deserializar archivos. 
using System.Xml.Serialization;

namespace Clase17Consola
{
    /*[IMPORTANTE]: *Para serializar una clase se deben agregar las directivas using System.Xml.Serialization y using System.IO.
         * *El orden en el que estén los atributos públicos (si hay), y/o las propiedades completas (get y set)
         es el orden en el que aparecerán en el archivo serializado. Por ejemplo en este caso aparece pripero la propiedad Internet,
         luego la propiedad Nombre, luego la propiedad Numero, luego la propiedad ListaDePersonas
         *Una colección: ya sea List, Qeue, etc, en una propiedad no necesita tener (get y set) para ser serializada, alcanza con que
         tenga el set que traiga a la lista, como en este caso la propiedad (ListadoDePersonas)
         *Una clase para poder ser serializada debe ser pública y tener un constructor por default (REQUISITOS OBLIGATORIOS)
         *Los elementos que se pueden serializar de una clase, son aquellas propiedades completas (get y set) públicas y los atributos
         públicos, y las propiedades de solo lectura que invoquen a una lista(comentado arriba), si no posee ninguno de ellos, se generará 
         la serialización pero no se verán datos de la clase.
         *Al serializar una clase que contenga hijos, o una lista que contenga una clase con hijos, en la clase padre se deben agregar las sentencias
         [XmlInclude(typeof(ClaseHija))] por cada hijo que esa clase contenga. Sino el programa pincha.*/

    class Program
    {
        private static bool SerializarPersona(Persona p)//Para serializar una clase, la clase debe tener un constructor por defecto explícito,
                                                        //debe ser pública los atributos que quiero que se serialicen también, las propiedades deben
                                                        //tener get y set.
        {
            XmlSerializer xs = new XmlSerializer(p.GetType());// ó TypeOf(Persona);
            //el XmlSerializer puede serializar listas, clases, distintos elementos.
            //StreamWriter sw = new StreamWriter(@"D:\PersonasXML.xml", true);
            StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Personas.xml");
            //el AppDomain.CurrentDomain.BaseDirectory se usa para traer la ruta actual donde se encuentra el programa ejecutándose.
            //precisamente en la carpeta Debug.
            xs.Serialize(sw, p);

            sw.Close();
            return true;
        }

        private static Persona DeserializarPersona()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Persona));

            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Personas.xml");

            return (Persona)xs.Deserialize(sr); //devuelve un object, y en este caso lo casteamos a Persona.

        }
        
        static void Main(string[] args)
        {


            Persona per = new Persona("Lucas", "Sanchez",123345567);

            Persona per1 = new Persona("Sabrina", "Veiga", 098876764);

            Alumno al = new Alumno("Nose", "QuePoner", 6475847, 72674);
            Alumno al1 = new Alumno("Nosee", "QuePonerr", 64758478, 726748);

            Profesor pro = new Profesor("Juan", "Mediavilla",645376,"Técnico");
                                                                    
            //al.apellido = "Perez";                                  
            //al.nombre = "Ezequiel";
            //al.Legajo = 124578;
            //al.Dni = 784581;

            

            //Console.WriteLine("Alumno {0} {1} -- Legajo: {2} -- Dni: {3}", al.apellido, al.nombre, al.Legajo, al.Dni);

            Aula aulita = new Aula(5, true, "Aula Verde");


            aulita.ListadoDePersonas.Add(per);
            aulita.ListadoDePersonas.Add(per1);
            aulita.ListadoDePersonas.Add(al);
            aulita.ListadoDePersonas.Add(al1);
            aulita.ListadoDePersonas.Add(pro);


            aulita.serializarMeLista(); //serialización de la lista sola


            //recorro Personas en aulita.DeserializarMe() que invoca a la lista de Personas deserializada
            foreach (Persona item in aulita.DeserializarMeLista())  //deserialización de la lista sola
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            aulita.serializarMe(); //serialización aula completa

            Console.WriteLine(aulita.DeserializarMe()); //deserialización aula completa

            //aulita.ListadoDePersonas.Add(al);
            //aulita.ListadoDePersonas.Add(pro);

            //foreach (Persona item in aulita.ListadoDePersonas)
            //{
            //    Console.WriteLine(item.GetType());
            //}

            //StreamReader sr = new StreamReader(@"D:\Personas.txt");
           
            //Console.WriteLine(sr.ReadToEnd());

            //sr.Close();

            //using (StreamReader sr = new StreamReader(@"D:\Personas.txt"))
            //la ruta que devuelde AppDomain.CurrentDomain.BaseDirectory es la de la carpeta del proyecto de consola que se
            //está ejecutando y dentro de bin --> debug se encuentra el archivo. Le concatenamos un string con el nombre del archivo.
            ////using (StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Personas.txt"))
            //{
                //todo código escrito dentro de un bloque using, al finalizar dicho bloque, se cierra automáticamente lo
                //que dependa del objeto "sr", ya sea cerrar un archivo, base de datos, etc.
                //if (File.Exists(@"D:\Personas.txt"))
                ////if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Personas.txt"))
                ////Console.WriteLine(sr.ReadToEnd());
            //}


            //Program.SerializarPersona(per);
            //Program.SerializarPersona(per1);
            //Program.SerializarPersona(al);

            //Console.WriteLine((Program.DeserializarPersona()).apellido);

            //using (StreamReader sr = new StreamReader(@"D:\Personas.txt"))
            //{

            //}

            Console.ReadLine();
        }
    }
}
