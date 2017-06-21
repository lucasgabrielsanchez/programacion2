using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _2ParcialLibrería
{
    /*Agregado, no fué pedido en el parcial*/
    [XmlInclude(typeof(Manzana))]
    [XmlInclude(typeof(Platano))]

    public abstract class Fruta
    {
        protected ConsoleColor _color;
        protected float _peso;

        public abstract bool TieneCarozo
        {
            get;
        }

        /*Agregado, no fué pedido en el parcial*/
        public Fruta()
        {
        }

        public Fruta(float peso, ConsoleColor color)
        {
            this._peso = peso;
            this._color = color;
        }

        protected virtual string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            
            //sb.AppendLine("Fruta:");
            //sb.AppendLine("-----------------------");
            sb.AppendLine("Color: "+this._color);
            sb.AppendLine("Peso: "+this._peso);
            sb.AppendLine("Carozo: " + (this.TieneCarozo ? "Si" : "No"));

            return sb.ToString();
        }
    }
}
