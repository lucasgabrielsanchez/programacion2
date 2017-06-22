using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace _2ParcialLibrería
{
    public class Cajon<T> : ISerializable
    {
        private int _capacidad;
        private List<T> _frutas;
        private float _precioUnitario;

        public List<T> Frutas
        {
            get {return this._frutas;}
        }

        public Cajon()
        {
            this._frutas = new List<T>();
        }

        public Cajon(int capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(int capacidad, float precio): this(capacidad)
        {
              this._precioUnitario = precio;
        }

        public float PrecioTotal
        {
            get
            {
                return (this._frutas.Count * this._precioUnitario);
            }
        }

        public static Cajon<T> operator + (Cajon<T> c, T f)
        {
            try
            {
                if (c._frutas.Count < c._capacidad)
                {
                    c._frutas.Add(f);
                }
                else
                {
                   throw new CajonLlenoException("El cajón se ha llenado\n");
                }
            }
            catch (CajonLlenoException e) { Console.WriteLine(e.Message); }
            return c;

        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cajón" + " de " + typeof(T).Name + "s");
            sb.AppendLine("------------------------");
            sb.AppendLine("Capacidad: " + this._capacidad);
            sb.AppendLine("Cantidad de frutas: " + this._frutas.Count);
            sb.AppendLine("Precio Total: $" + this.PrecioTotal + "\n");
            sb.AppendLine("Frutas contenidas:\n");
            foreach (T item in this._frutas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        #region Implementaciones de ISerializable
        public string RutaDeArchivo
        {
            get;
            set;
        }

        public bool SerializarXML()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Cajon<T>));
                StreamWriter sw = new StreamWriter(this.RutaDeArchivo);
                xs.Serialize(sw, this);
                sw.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Deserializar()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(this.GetType());
                StreamReader sr = new StreamReader(this.RutaDeArchivo);
                xs.Deserialize(sr);
                sr.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

    }
}
