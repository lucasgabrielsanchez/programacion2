using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10Consola
{
    class Alumno : Persona
    {
        private string _nombre;
        private string _apellido;
        private int _dni;
        private List<float> _notas;
        private string _curso;

        public Alumno(string nombre, string apellido, int dni) : base(nombre,apellido,dni)
        {
            //this._nombre = nombre;
            //this._apellido = apellido;
            //this._dni = dni;
            this._notas = new List<float>();
        }

        public Alumno(string nomb, string apell, int dni, string cur) : this(nomb,apell,dni)
        {
            this._curso = cur;
        }


        public string Mostrar()
        {
            return "Alumno:" + "\nEl nombre es: " + base._nombre + "\nEl apellido es: " + base._apellido + "\nEl dni es: " + base._dni.ToString() + "\nEl curso es: " + this._curso + "\nNotas:";
        }
    }
}
