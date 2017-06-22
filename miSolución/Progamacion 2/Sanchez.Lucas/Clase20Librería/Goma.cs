using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20Librería
{
    public class Goma : Utiles
    {
        private bool _soloLapiz;

        public Goma(float precio, string marca, bool soloLapiz) : base(precio,marca)
        {
            this._soloLapiz = soloLapiz;
        }

        public override string Marca
        {
            get;
            set;
        }

        public override float Precio
        {
            get;
            set;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.UtilesToString());
            sb.AppendLine("Solo Lapiz: " + (this._soloLapiz ? "Si" : "No"));

            return sb.ToString();
        }
    }
}
