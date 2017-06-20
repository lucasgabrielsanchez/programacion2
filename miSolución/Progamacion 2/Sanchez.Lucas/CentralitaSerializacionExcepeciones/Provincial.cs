using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacionExcepeciones
{
    public class Provincial : Llamada //modificador de visibilidad "public" agregado para poder serializar esta clase
    {                                 //que además está dentro de la lista de llamadas de Centralita, igual es necesario que sea pública.
        private Franja _franjaHoraria;

        public Provincial()//Agregado para poder serializar
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(origen,destino,duracion)
        {
            this._franjaHoraria = miFranja;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Llamada Provincial: ");
            sb.AppendLine("-------------------------------");
            sb.Append(base.Mostrar());
            sb.AppendLine("Franja horaria: " + this._franjaHoraria);
            sb.AppendLine("El Costo es de: $" + this.CalcularCosto());

            return sb.ToString();
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }

            set//agregado para ser serializado
            {
                ;
            }
        }

        private float CalcularCosto()
        {
            float retorno;

            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = (float)(base._duracion * 0.99);
                    break;
                case Franja.Franja_2:
                    retorno = (float)(base._duracion * 1.25);
                    break;
                case Franja.Franja_3:
                    retorno = (float)(base._duracion * 0.66);
                    break;
                default:
                    retorno = 0;
                    break;
            }

            return retorno;
        }

        public override bool Equals(object obj)
        {
            bool aux = false;

            if (obj is Provincial && this == ((Provincial)obj))
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
