﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private string _nombre;
        private string _raza;

        public string Nombre
        {
            get { return this._nombre; }
            
        }

        public string Raza 
        {
            get { return this._raza; }
        }

        public Mascota(string nombre, string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }

        abstract protected string Ficha();

        protected string DatosCompletos()
        {
            return this._nombre + " " + this._raza;
        }
        
        
        
    }
}
