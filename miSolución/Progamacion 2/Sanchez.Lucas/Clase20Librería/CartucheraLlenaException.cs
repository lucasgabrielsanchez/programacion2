﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20Librería
{
    public class CartucheraLlenaException : Exception
    {
        public CartucheraLlenaException(string mensaje) : base(mensaje)
        {
        }
    }
}
