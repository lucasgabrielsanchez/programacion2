using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
     abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        public abstract float CostoLlamada
        {
            get;
        }

        protected Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nro Origen: "+this.NroOrigen);
            sb.AppendLine("Nro Destino: " + this.NroDestino);
            sb.AppendLine("Duración: " + this.Duracion);

            return sb.ToString();
           
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return uno.Duracion.CompareTo(dos.Duracion);
        }


        public static bool operator == (Llamada llamada1,Llamada llamada2)
        {

         bool aux = false;

         if ((llamada1.GetType()) == (llamada2.GetType())) //compara los tipos de objeto para saber si las llamadas son del mismo tipo.
          {
              if ((llamada1.NroOrigen == llamada2.NroOrigen) && (llamada1.NroDestino == llamada2.NroDestino))
              {
                  aux = true;
              }
          }

          return aux;

         }

        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }

        public override bool Equals(object obj)
        {
            bool aux = false;

            if (obj is Llamada && this == ((Llamada)obj))
            {
                aux = true;
            }

            return aux;
        }

    }
}
