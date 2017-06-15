using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19BaseDeDatosLibrería
{
    public class Persona
    {
        public int id;
        public string apellido;
        public string nombre;
        public int edad;

        public Persona()
        {
        }

        public Persona(int id, string nombre, string apellido, int edad)
        {
            this.id = id;
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
        }

        public override string ToString()
        {
            return "ID: " + this.id + " Nombre: " + this.nombre + " Apellido: " + this.apellido + " Edad: " + this.edad;
            //return this.id + this.nombre + this.apellido + this.edad;
        }
    }
}
