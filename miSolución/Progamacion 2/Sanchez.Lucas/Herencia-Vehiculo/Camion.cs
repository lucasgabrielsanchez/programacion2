using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Vehiculo
{
    public class Camion : Vehiculo
    {
        protected int _cantidadAsientos;
        protected float _tara;
        protected float _cilindrada;

        public Camion(int cAsientos, float tara, float cilindrada,
        string patente, Byte cantRuedas, EMarcas marca) : base(patente, cantRuedas, marca)
        {
            this._cantidadAsientos = cAsientos;
            this._tara = tara;
            this._cilindrada = cilindrada;
        }

        public string MostrarCamion()
        {
            return "Camion:\n" + base.Mostrar() + "Cantidad de Asientos: " + this._cantidadAsientos.ToString() + "\n" + "Tara: " + this._tara.ToString() + "\n" + "Cilindrada: " + this._cilindrada.ToString() + "\n";

        }
    }
}
