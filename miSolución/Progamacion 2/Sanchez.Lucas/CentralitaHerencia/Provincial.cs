using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial : Llamada
    {
        private Franja _franjaHoraria;

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(origen,destino,duracion)
        {
            this._franjaHoraria = miFranja;
        }
        
    }
}
