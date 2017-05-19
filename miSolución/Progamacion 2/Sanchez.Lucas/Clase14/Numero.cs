using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14
{
    public class Numero
    {
        protected double _numero;

        public double NumeroDetalle
        {
            get
            {
                return this._numero;
            }
        }

        public Numero(double numero)
        {
            this._numero = numero;
        }

        public static double operator +(Numero uno, Numero dos)
        {
            return uno._numero + dos._numero;
        }

        public static double operator -(Numero uno, Numero dos)
        {
            return uno._numero - dos._numero;
        }

        public static double operator /(Numero uno, Numero dos)
        {
            return uno._numero / dos._numero;
        }

        public static double operator *(Numero uno, Numero dos)
        {
            return uno._numero * dos._numero;
        }
    }
}
