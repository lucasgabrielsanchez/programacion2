using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local : Llamada
    {
        private float _costo;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Local(string origen, string destino, float duracion, float costo)
            : base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        private float CalcularCosto()
        {
            return (this._costo * base._duracion);
        }

        override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine((this.CostoLlamada).ToString());

            return sb.ToString();
        }

        

       

    }
}
