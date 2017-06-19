using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacionExcepeciones
{
    public class Local : Llamada//modificador de visibilidad "public" agregado para poder serializar esta clase
    {                           ////que además está dentro de la lista de llamadas de Centralita, igual es necesario que sea pública.
        private float _costo;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }

        }

        public Local() //Agregado para poder serializar
        {
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

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Llamada Local: ");
            sb.AppendLine("-------------------------------");
            sb.Append(base.Mostrar());
            sb.AppendLine("El costo es de: $" + (this.CostoLlamada).ToString());

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool aux = false;

            if (obj is Local && this == ((Local)obj))
            {
                aux = true;
            }

            return aux;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
