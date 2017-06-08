using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18Librería
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color
        {
            get { return _color; }
        }

        public string Marca
        {
            get { return _marca; }
        }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            return (a._marca == b._marca && a._color == b._color);
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            bool aux = false;

            if (obj.GetType() == this.GetType())
                if (((Auto)obj) == this)
                    aux = true;

            return aux;
        }

        public override string ToString()
        {
            return "Marca: " + this._marca + " - Color: " + this._color + "\n";
        }
        
    }
}
