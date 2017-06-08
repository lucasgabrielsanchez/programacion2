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
        private List<Persona> _listadoDePersonas;
        private string _nombre;
        private int _numero;

        public bool Internet
        {
            set { this._internet = value; }
        }

        public List<Persona> ListadoDePersonas
        {
            get { return this._listadoDePersonas; }
        }

        public string Nombre
        {
            get { return this._nombre; }
        }

        public int Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public Aula()
        {
            this._listadoDePersonas = new List<Persona>();
        }

        public Aula(int numero, bool internet, string nombre) : this()
        {
            this._numero = numero;
            this.Internet = internet;
            this._nombre = nombre;
        }

        public bool serializarMe()
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

        public Persona DeserializarMe()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Persona));

            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "ListaPersonas.xml");

            return (Persona)xs.Deserialize(sr);
        }
        
    }
}
