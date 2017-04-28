using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10Consola
{
    class Obrero : Persona
    {
        private string _nombre;
        private string _apellido;
        private int _dni;
        private int _legajo;
        private float _sueldo;
        

        public Obrero(string nombre, int dni, string apellido) : base(nombre,apellido,dni)
        {
            //this._nombre = nombre;
            //this._dni = dni;
            //this._apellido = apellido;
        }

        public Obrero(string nomb, int dni, string apell, int legajo, float sueldo) : this(nomb,dni,apell)
        {
            this._legajo = legajo;
            this._sueldo = sueldo;
        }

        public static string Mostrar(Obrero obrerito)
        {
            //return "\nObrero:" + "\nEl nombre es: " + obrerito._nombre + "\nEl dni es: " + obrerito._dni.ToString() + "\nEl apellido es: " + obrerito._apellido + "\nSu legajo es: " + obrerito._legajo.ToString() + "\nSu sueldo es: " + obrerito._sueldo.ToString();
            return obrerito.MostrarPersona() + "Su legajo es: " + obrerito._legajo.ToString() + "\nSu sueldo es: " + obrerito._sueldo.ToString() + "\n";
        
        }
    }
}
