using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase22Entidades
{
    public class EmpleadoEventArgs : EventArgs
    {
        private double numDouble;

        public EmpleadoEventArgs(double num)
        {
            this.numDouble = num;
        }

        public double NumDouble { get { return this.numDouble;} }
    }
}
