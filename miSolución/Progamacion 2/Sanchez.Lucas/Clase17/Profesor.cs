using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        public Profesor()
        {
        }
        
        public Profesor(string nombre, string apellido, int dni, string titulo) : base(nombre,apellido,dni)
        {
            this.Titulo = titulo;
        }

        public override string ToString()
        {
            return base.ToString() + "*Título: " + this._titulo;
        }
    }
}
