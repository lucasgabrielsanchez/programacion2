using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class Persona
    {
        private string _apellido;
        private int _dni;
        private ENacionalidad _nacionalidad;
        private string _nombre;

        public enum ENacionalidad {Argentino, Extranjero};

        #region Propiedades
        public string Apellido
        {
            get
            { 
                return this._apellido; 
            }

            set 
            { 
                this._apellido = value; 
            }
        }

        public int DNI
        {
            get 
            { 
                return this._dni; 
            }

            set 
            { 
                this._dni = value; 
            }
        }

        public ENacionalidad Nacionalidad
        {
            get 
            { 
                return this._nacionalidad; 
            }

            set 
            { 
                this._nacionalidad = value; 
            }
        }

        public string Nombre
        {
            get 
            { 
                return this._nombre; 
            }

            set 
            { 
                this._nombre = value; 
            }
        }

        public string StringToDNI 
        {
            set
            {
                ;
            }
        }
        #endregion

        public Persona()
        {
        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
        : this(nombre,apellido,nacionalidad)
        {
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {
        }



    }
}
