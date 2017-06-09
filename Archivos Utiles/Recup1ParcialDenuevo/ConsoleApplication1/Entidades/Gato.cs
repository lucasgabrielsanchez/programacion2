using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza)
        { 
        }

        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            return (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza);
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {   
            bool aux = false; //return ((this.GetType()) == (obj.GetType()));

            if (obj is Gato) //modificado a fin de que no genere un mal borrado de objetos dentro del método "Remove"
                if (((Gato)obj) == this) //ubicado en la sobrecarga del operador "-" dentro de la clase "Grupo".
                    aux = true;

            return aux;
        }


    }
}
