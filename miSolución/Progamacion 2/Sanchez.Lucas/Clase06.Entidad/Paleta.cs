using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Entidad
{
    public class Paleta
    {
        private Tempera [] _colores;
        private int _cantidadMaximaColores;

        private Paleta() : this(5)
        {

        }

        private Paleta (int cant) 
        {
            this._colores = new Tempera[cant];
            this._cantidadMaximaColores = cant;
        }

        



    }
}
