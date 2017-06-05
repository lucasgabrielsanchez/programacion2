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

        public Perro(string nombre, string raza, int edad, bool esAlfa): base(nombre, raza)
        {
            this._edad = edad;
            this._esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            string aux = base.DatosCompletos();

            if (this._esAlfa == true)
                aux += ", alfa de la manada, edad " + this._edad;
            else
                aux += ", edad " + this._edad;

            return aux;
        }

        public static explicit operator int(Perro p)
        {
            return p._edad;
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            return (p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1._edad == p2._edad);
        }


        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            //return ((this.GetType()) == (obj.GetType()));
            return (this == obj); //modificado a fin de que no genere un mal borrado de objetos dentro del método "Remove"
            //ubicado en la sobrecarga del operador "-" dentro de la clase "Grupo".
        }
    }
}
