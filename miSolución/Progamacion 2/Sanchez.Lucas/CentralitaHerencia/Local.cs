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

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Llamada Local: ");
            sb.AppendLine("-------------------------------");
            sb.Append(base.Mostrar());
            sb.AppendLine("El costo es de: $" + (this.CostoLlamada).ToString());

            return sb.ToString();
        }

        

       

    }
}
