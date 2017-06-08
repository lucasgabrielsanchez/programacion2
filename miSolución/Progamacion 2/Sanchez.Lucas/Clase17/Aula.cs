using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17
{
    public class Aula
    {
        private bool _internet;
        private List<Persona> _listadoDePersonas;
        private string _nombre;
        private int _numero;

        public bool Internet
        {
            set { this._internet = value; }
        }

        public List<Persona> ListadoDePersonas
        {
            get { return this._listadoDePersonas; }
        }

        public string Nombre
        {
            get { return this._nombre; }
        }

        public int Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }

        public Aula()
        {
            this._listadoDePersonas = new List<Persona>();
        }

        public Aula(int numero, bool internet, string nombre) : this()
        {
            this._numero = numero;
            this.Internet = internet;
            this._nombre = nombre;
        }

        public bool serializarMe()
        {
            return true;
        }
        
        
    }
}
