using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase22Entidades
{
    public delegate void DelegadoSueldo(); // <= 1 delegado

    public delegate void DelegadoSueldoMejorado(object asd, EventArgs df); // <= delegado similar a la firma de un evento de Form, el object
                                                                 //tiene un objeto de la clase que generó el evento, EventArgs tiene información
                                                                 //extra del evento que lo acompaña.
                                                                //puedo crear mi propio EventArgs, ejemplo EmpleadoEventArgs
    public class Empleado
    {
        public event DelegadoSueldo SueldoEvent; // <= 2 evento

        public event DelegadoSueldoMejorado SueldoEventMejorado; // evento del delegado DelegadoSueldoMejorado.

        public string nombre;
        public string apellido;
        public int legajo;
        private double _sueldo;

        public Empleado(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public double Sueldo 
        {
            get { return this._sueldo; }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("El número es negativo");
                }
                else if(value > 9500 && value < 20000)
                {
                    this.SueldoEvent();// <= 
                                       //ícono de rayo para un evento
                }
                else if (value > 20000)
                {
                   
                    this.SueldoEventMejorado(this, new EmpleadoEventArgs(value));
                    
                }

                this._sueldo = value;
            } 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Legajo: " + this.legajo);
            sb.AppendLine("Sueldo: " + this.Sueldo);

            return sb.ToString();
        }
    }
}
