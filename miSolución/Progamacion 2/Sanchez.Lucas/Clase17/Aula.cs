using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Clase17
{
    public class Aula
    {
        private bool _internet;
        private string _nombre;
        private int _numero;
        private List<Persona> _listadoDePersonas;

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

        public bool Internet //propiedad pasada de solo "set", a "get y set" para que aparezca en el archivo serializado.
        {
            get { return this._internet; }
            set { this._internet = value; }
        }

        public string Nombre //propiedad pasada de solo "set", a "get y set" para que aparezca en el archivo serializado.
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public int Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public List<Persona> ListadoDePersonas
        {
            get { return this._listadoDePersonas; }
        }

        

        public Aula()
        {
            this._listadoDePersonas = new List<Persona>();
        }

        public Aula(int numero, bool internet, string nombre) : this()
        {
            this._numero = numero;
            this._internet = internet;
            this._nombre = nombre;
        }

        public bool serializarMeLista() //Serialización de la lista.
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Persona>));

            StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "ListaPersonas.xml");

            //foreach (Persona item in this._listadoDePersonas)
            //{
            //    xs.Serialize(sw, item);
            //}

            xs.Serialize(sw,this._listadoDePersonas);

            sw.Close();
            return true;
        }

        public List<Persona> DeserializarMeLista() //Deserialización de la lista.
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Persona>));

            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "ListaPersonas.xml");

            return (List<Persona>)xs.Deserialize(sr);
        }

        public bool serializarMe() //Serialización de Aula completa.
        {
            XmlSerializer xs = new XmlSerializer(typeof(Aula));

            StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Aula.xml");

            //foreach (Persona item in this._listadoDePersonas)
            //{
            //    xs.Serialize(sw, item);
            //}

            xs.Serialize(sw, this);

            sw.Close();
            return true;
        }

        public Aula DeserializarMe() //Deserialización de Aula completa.
        {
            XmlSerializer xs = new XmlSerializer(typeof(Aula));

            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Aula.xml");

            return (Aula)xs.Deserialize(sr);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre del Aula: {0} -- Curso: {1} -- Internet: {2}\n", this._nombre, this._numero, this._internet);
            sb.AppendLine("Integrantes del Aula: ");
            foreach (Persona item in this._listadoDePersonas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
