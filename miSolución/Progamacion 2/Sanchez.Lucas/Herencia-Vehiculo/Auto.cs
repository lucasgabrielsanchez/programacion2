using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Vehiculo
{
    public class Auto : Vehiculo
    {
        protected int _cantidadAsientos;
        protected float _tara;
        protected float _cilindrada;

        public Auto(int cAsientos, float tara, float cilindrada,
        string patente, Byte cantRuedas, EMarcas marca) : base(patente, cantRuedas, marca)
        {
            this._cantidadAsientos = cAsientos;
            this._tara = tara;
            this._cilindrada = cilindrada;
        }
        
        public string MostrarAuto()
        {
            return "Auto:\n" + base.Mostrar() + "Cantidad de Asientos: " + this._cantidadAsientos.ToString() + "\n" + "Tara: " + this._tara.ToString() + "\n" + "Cilindrada: " + this._cilindrada.ToString() + "\n";

        }
    }
}
