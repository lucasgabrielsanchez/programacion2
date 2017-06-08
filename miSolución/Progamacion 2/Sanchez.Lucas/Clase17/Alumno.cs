using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17
{
    public class Alumno: Persona
    {
        private int _legajo;

        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }

        
        
    }
}
