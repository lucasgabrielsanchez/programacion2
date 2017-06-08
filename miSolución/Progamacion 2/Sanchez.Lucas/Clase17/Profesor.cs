using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17
{
    public class Profesor : Persona
    {
        private string _titulo;

        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }

        public Profesor():base()
        {
        }
        
        public Profesor(string nombre, string apellido, int dni, string titulo) : base(nombre,apellido)
        {
            this.Dni = dni;
            this.Titulo = titulo;
        }
        
    }
}
