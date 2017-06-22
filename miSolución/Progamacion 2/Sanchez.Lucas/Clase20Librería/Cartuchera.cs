using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Clase20Librería
{
    [XmlType("Cartuchera")] //probando, sirve para ponerle nombres a las clases a ser serializadas.
    public class Cartuchera<T> : ISerializable
    {
        private int _capacidad;
        private List<T> _utiles;
        private string _marca;

        public int Capacidad { get { return this._capacidad; }  set { this._capacidad = value;} }

        public Cartuchera()
        {
            this._utiles = new List<T>();
        }

        public Cartuchera(int capacidad, string marca):this()
        {
            this._capacidad = capacidad;
            this._marca = marca;
        }

        public static Cartuchera<T> operator +(Cartuchera<T> c, T a)
        {
            if (c._utiles.Count < c._capacidad)
            {
                c._utiles.Add(a);
                return c;
            }
            else
            {
                throw new CartucheraLlenaException("La cartuchera está llena\n");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cartuchera: ");
            sb.AppendLine("--------------");
            sb.AppendLine("Capacidad: "+this._capacidad);
            sb.AppendLine("Marca: \n"+this._marca);
            sb.AppendLine("\nElementos contenidos: \n");

            foreach (T item in this._utiles)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public bool SerializarXML(string path)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(this.GetType());
                StreamWriter sw = new StreamWriter(path);
                xs.Serialize(sw, this);
                sw.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeserializarXML(string path)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(this.GetType());
                StreamReader sr = new StreamReader(path);
                xs.Deserialize(sr);
                sr.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeserializarXML(string path, out Cartuchera<T> c)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Cartuchera<T>));
                StreamReader sr = new StreamReader(path);
                c = (Cartuchera<T>)xs.Deserialize(sr);
                sr.Close();
                return true;
            }
            catch
            {
                c = null;
                return false;
            }
        }
    }
}
