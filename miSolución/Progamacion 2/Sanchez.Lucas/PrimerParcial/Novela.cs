using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Novela : Libro
    {
        public EGenero genero;

        public Novela(string titulo, float precio, Autor autor, EGenero genero) :base(titulo,autor,precio)
        {
            this.genero = genero;
        }

        public string Mostrar()
        {
            return (string)((Libro)this) + "Genero: " + this.genero.ToString() + "\n";
        }

        public static bool operator ==(Novela a, Novela b)
        {
            bool aux = false;

            if (((Libro)a) == ((Libro)b) && a.genero == b.genero)
            {
                aux = true;
            }

            return aux;
        }

        public static bool operator !=(Novela a, Novela b)
        {
            return !(a == b);
        }

        public static implicit operator double(Novela n)
        {
            return n._precio;
        }
    }
}
