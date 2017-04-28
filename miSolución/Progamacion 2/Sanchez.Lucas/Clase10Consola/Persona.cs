using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10Consola
{
    class Persona // Creamos esta clase para heredar elementos de las clases Aluno y Obrero, los constructores NO se comparten
    {
        protected string _nombre; // el protected hace que el atributo solo pueda ser accedido desde los hijos o las herencias
                                  // pero no desde otra clase cualquiera que no sea herencia de esta clase padre osea, Persona
        protected string _apellido;
        protected int _dni;
       

        public Persona()
        {

        }

        public Persona(string nombreP, string apellidoP, int dniP)
        {
            this._nombre = nombreP;
            this._apellido = apellidoP;
            this._dni = dniP;
        }

        public string MostrarPersona()
        {
            return "\nPersona:" + "\nEl nombre es: " + this._nombre + "\nEl apellido es: " + this._apellido + "\nEl dni es: " + this._dni.ToString() + "\n";
        }
    }
}
