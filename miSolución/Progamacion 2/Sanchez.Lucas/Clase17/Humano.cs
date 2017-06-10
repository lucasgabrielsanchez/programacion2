using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clase17
{
    public class Humano
    {
        private int _dni;

        public int Dni 
        {
            get
            {
                return this._dni;
            }
            set
            {
                this._dni = value;
            }
        }

    }
}
