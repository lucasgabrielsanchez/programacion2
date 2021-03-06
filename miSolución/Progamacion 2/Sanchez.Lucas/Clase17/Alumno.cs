﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17
{
    
    public class Alumno: Persona
    {
        public int _legajo;

        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }

        public Alumno()
        {
        }

        public Alumno(string nombre, string apellido, int dni, int legajo) : base(nombre,apellido,dni)
        {
            this.Legajo = legajo;
        }

        public override string ToString()
        {
            return base.ToString() + "*Legajo: " + this._legajo;
        }
    }
}
