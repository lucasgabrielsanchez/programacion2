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


            Persona per = new Persona("Lucas", "Sanchez");

            Persona per1 = new Persona("Sabrina", "Veiga");
                                                                    
            //al.apellido = "Perez";                                  
            //al.nombre = "Ezequiel";
            //al.Legajo = 124578;
            //al.Dni = 784581;

            Profesor pro = new Profesor();

            //Console.WriteLine("Alumno {0} {1} -- Legajo: {2} -- Dni: {3}", al.apellido, al.nombre, al.Legajo, al.Dni);

            //Aula aulita = new Aula(5, true, "Aula 2ºC");

            //aulita.ListadoDePersonas.Add(al);
            //aulita.ListadoDePersonas.Add(pro);

            //foreach (Persona item in aulita.ListadoDePersonas)
            //{
            //    Console.WriteLine(item.GetType());
            //}

            //StreamReader sr = new StreamReader(@"D:\Personas.txt");
           
            //Console.WriteLine(sr.ReadToEnd());

            //sr.Close();

            using (StreamReader sr = new StreamReader(@"D:\Personas.txt"))
            {
                //todo código escrito dentro de un bloque using, al finalizar dicho bloque, se cierra automáticamente lo
                //que dependa del objeto "sr", ya sea cerrar un archivo, base de datos, etc.
                if (File.Exists(@"D:\Personas.txt"))
                Console.WriteLine(sr.ReadToEnd());
            }


            Program.SerializarPersona(per);
            Program.SerializarPersona(per1);

            Console.WriteLine((Program.DeserializarPersona()).apellido);

            //using (StreamReader sr = new StreamReader(@"D:\Personas.txt"))
            //{

            //}

            Console.ReadLine();
        }
    }
}
