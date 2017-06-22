using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20Librería
{
    public class Lapicera : Utiles
    {
        private ConsoleColor _color;
        protected string _trazo;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.UtilesToString());
            sb.AppendLine("Color: " + this._color);
            sb.AppendLine("Trazo: " + this._trazo);

            return sb.ToString();
        }

        public Lapicera(float precio, string marca, ConsoleColor color, string trazo) : base(precio,marca)
        {
            this._color = color;
            this._trazo = trazo;
        }

        public override float Precio
        {
            get;
            set;
        }

        public override string Marca
        {
            get;
            set;
        }
    }
}
