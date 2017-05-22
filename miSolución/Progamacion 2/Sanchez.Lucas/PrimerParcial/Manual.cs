using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Manual : Libro
    {
        #region Atributos

        public ETipo tipo;

        #endregion

        #region Constructores

        public Manual(string titulo, float precio, string nombre, string apellido, ETipo tipo) :base(precio,titulo,nombre,apellido)
        {
            this.tipo = tipo;
        }

        #endregion


        #region Métodos
        public string Mostrar()
        {
            //Para reutilizar código lo que hacemos acá es primero castear a this (que representa a una instancia de la clase
            //en la cual estoy parado) a Libro para poder extraer lo que corresponde a un Libro dentro de Manual, entonces a este
            //Libro lo casteamos con el operador explícito string (que se encuentra sobrecargado en la clase Libro, para poder mostrar
            //lo que el Libro contiene, luego le concatenamos el atributo tipo de esta clase.
            return (string)((Libro)this) + "Tipo: " + this.tipo.ToString() + "\n";

        }
        #endregion

        #region Sobrecarga De Operadores

        public static bool operator ==(Manual a, Manual b)
        {
            bool aux = false;

            if (((Libro)a) == ((Libro)b) && (a.tipo == b.tipo))
            {
                aux = true;
            }

            return aux;
        }

        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }

        public static implicit operator double(Manual m)
        {
            return m._precio;
        }

        #endregion
    }
}
