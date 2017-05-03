using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Vehiculo
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }

        public string Vehiculo

    }
}
