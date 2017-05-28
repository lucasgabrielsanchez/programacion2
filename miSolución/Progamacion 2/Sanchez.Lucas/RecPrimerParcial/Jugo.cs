using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecPrimerParcial
{
    public class Jugo : Producto
    {
        protected ESaborJugo _sabor;

        public Jugo(int codBarra, EMarcaProducto marca, float precio, ESaborJugo sabor) : base(codBarra,marca,precio)
        {
            this._sabor = sabor;
        }

        static Jugo()
        {
            Jugo.DeConsumo = true;
        }

        private string MostrarJugo()
        {
            return ((Producto)this) + "\n" + "SABOR: " + this._sabor + "\n";
        }

        public override string ToString()
        {
            return this.MostrarJugo();
        }

        public override float CalcularCostoDeProduccion
        {
            get { return this._precio * 0.4f; }
        }

        public override string Consumir()
        {
            return base.Consumir() + "Bebible\n";
        }

    }
}
