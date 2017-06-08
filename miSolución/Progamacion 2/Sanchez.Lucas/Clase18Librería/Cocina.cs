using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18Librería
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo
        {
            get { return _codigo; }
        }

        public bool EsIndustrial
        {
            get { return _esIndustrial; }
        }

        public double Precio
        {
            get { return _precio; }
        }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            return (a._codigo == b._codigo);
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            bool aux = false;

            if (obj.GetType() == this.GetType())
                if (((Cocina)obj) == this)
                    aux = true;

            return aux;
        }

        public override string ToString()
        {
            return "Código: " + this._codigo + " - Precio: " + this._precio + " - Es industrial?: " + this._esIndustrial + "\n";
        }
        
    }
}
