using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio59Librería
{
    public abstract class Vehiculo
    {
        protected int _cantidadEjes;
        protected EColores _color = EColores.Sincolor;
        protected string _patente;

        public abstract string Patente
        {
            get;
        }

        public abstract EColores Colores
        {
            get;
            set;
        }

        public abstract int CantidadEjes
        {
            get;
            set;
        }

        public Vehiculo()
        {
        }

        public Vehiculo(string patente, int cantEjes)
        {
            this._patente = patente;
            this._cantidadEjes = cantEjes;
        }

        public virtual void TocarBocina()
        {
        }
    }
}
