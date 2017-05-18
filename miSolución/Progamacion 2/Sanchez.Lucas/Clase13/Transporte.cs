using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13
{
    public abstract class Transporte
    {
        protected int _cantidadPasajeros;
        protected Evelocidad _velocidadMaxima;

        public abstract string Detalle
        {
            get;
        }

        public Transporte(int canPasajeros, Evelocidad velocidadMaxima)
        {
            this._cantidadPasajeros = canPasajeros;
            this._velocidadMaxima = velocidadMaxima;
        }

        public abstract string Frenar();

        public virtual string Acelerar()
        {
           return ((int)this._velocidadMaxima).ToString();
        }
        

    }
}
