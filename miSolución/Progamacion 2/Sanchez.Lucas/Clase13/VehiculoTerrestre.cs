using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13
{
    public abstract class VehiculoTerrestre : Transporte
    {
        public VehiculoTerrestre(int cantPasajeros, Evelocidad velocidadMaxima)
            : base(cantPasajeros, velocidadMaxima)
        {
        }

    }
}
