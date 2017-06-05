using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private int _edad;
        private bool _esAlfa;

        public Perro(string nombre, string raza) : this(nombre,raza,0,false)
        {
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa):base(nombre,raza)
        {
            this._edad = edad;
            this._esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();

            if (this._esAlfa == false)
                //sb.AppendFormat("{0} {1}, edad {2}", base.Nombre, base.Raza, this._edad);
                sb.AppendFormat(base.DatosCompletos() + " edad " + this._edad);
            else
                //sb.AppendFormat("{0} {1}, {2}, {3}", base.Nombre, base.Raza, "alfa de la manada", this._edad);
                sb.AppendFormat(base.DatosCompletos() + " alfa de la manada " + this._edad);
            return sb.ToString();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            return (p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1._edad == p2._edad);
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int(Perro p)
        {
            return p._edad;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType());
        }
    }
}
