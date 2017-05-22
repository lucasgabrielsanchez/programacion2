using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Autor
    {

        #region Atributos
        private string _nombre;
        private string _apellido;
        #endregion

        #region Constructores
        public Autor(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Autor a1, Autor a2)
        {
            bool aux = false;

            if ((a1._nombre == a2._nombre) && (a1._apellido == a2._apellido))
            {
                aux = true;
            }

            return aux;
        }

        public static bool operator !=(Autor a1, Autor a2)
        {
            return !(a1 == a2);
        }

        public static implicit operator string (Autor aut)
        {
            return aut._nombre + " " + aut._apellido;
        }
        #endregion
    }
}
