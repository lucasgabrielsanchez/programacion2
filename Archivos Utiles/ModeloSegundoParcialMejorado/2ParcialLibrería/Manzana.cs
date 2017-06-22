using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace _2ParcialLibrería
{
    public class Manzana : Fruta , ISerializable
    {
        public string distribuidora;

        public override bool TieneCarozo
        {
            get { return true; }
        }

        public string Tipo
        {
            get {return "Manzana";}
        }

        /*Agregado, no fué pedido en el parcial*/
        public Manzana()
        {
        }

        public Manzana(float peso, ConsoleColor color, string distribuidora) : base (peso,color)
        {
            this.distribuidora = distribuidora;
        }

        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Tipo);
            sb.AppendLine("------------------");
            sb.AppendFormat(base.FrutaToString());
            sb.AppendLine("Distribuidora: " + this.distribuidora);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
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
                XmlSerializer xs = new XmlSerializer(typeof(Manzana));
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
                StreamReader sr = new StreamReader(this.RutaDeArchivo + "Manzana.xml");
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
