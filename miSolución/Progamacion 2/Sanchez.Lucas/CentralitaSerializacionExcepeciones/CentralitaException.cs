using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacionExcepeciones
{
    public class CentralitaException : Exception
    {
        private Exception _excepcionInterna;
        private string _nombreClase;
        private string _nombreMetodo;

        public Exception ExcepcionInterna
        {
            get { return this._excepcionInterna; }
        }

        public string NombreClase
        {
            get { return this._nombreClase; }
        }

        public string NombreMetodo
        {
            get { return this._nombreMetodo; }
        }

        public CentralitaException(string mensaje, string clase, string metodo) : base(mensaje)
        {   
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException) : this(mensaje,clase,metodo)
        {
            this._excepcionInterna = innerException;
        }
    }
}
