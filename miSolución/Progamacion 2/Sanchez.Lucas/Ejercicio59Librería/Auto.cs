using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio59Librería
{
    public class Auto : Vehiculo, IColoreable
    {
        private ETipoCombustible _tipoCombustible = ETipoCombustible.SinTipo;
        public int cantidadPuertas = 0;

        public ETipoCombustible TiposCombustible
        {
            get { return this._tipoCombustible; }
            set { this._tipoCombustible = value; }
        }

        public Auto()
        {
        }

        public Auto(string patente) : base(patente, 0)
        {
        }

        public bool CambiarDeColor(EColores color)
        {
            bool aux = false;
            if (this._color != color && color != EColores.Sincolor)
            {
                this._color = color;
                aux = true;
            }

            return aux;
        }

        public override int CantidadEjes
        {
            get
            {
                return base._cantidadEjes;
            }
            set
            {
                base._cantidadEjes = value;
            }
        }

        public override string Patente
        {
            get { return base._patente; }
        }

        public override EColores Colores
        {
            get
            {
                return base._color;
            }
            set
            {
                base._color = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Auto:");
            sb.AppendLine("--------------------------");
            sb.AppendLine("Cantidad de ejes: " + this._cantidadEjes);
            sb.AppendLine("Color: " + this._color);
            sb.AppendLine("Patente: " + this._patente);
            sb.AppendLine("Tipo de combustible: " + this._tipoCombustible);
            sb.AppendLine("Cantidad de puertas: " + this.cantidadPuertas);

            return sb.ToString();
        }

    }

}
