using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio59Librería
{
    public class Moto : Vehiculo
    {
        private int _cilindrada;

        public int Cilindrada
        {
            get { return this._cilindrada; }
            set { this._cilindrada = value; }
        }

        public Moto(string patente)
        {
            base._patente = patente;
        }

        
        
    }
}
