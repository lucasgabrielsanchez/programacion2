using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecPrimerParcial
{
    public class Gaseosa : Producto
    {
        protected float _litros;

        public Gaseosa(int codBarra, float precio, EMarcaProducto marca, float litros)
            : base(codBarra, marca, precio)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto p, float litros)
            : this((int)p, p.Precio, p.Marca, litros)
        {
        }

        static Gaseosa()
        {
            Gaseosa.DeConsumo = true;
        }

        private string MostrarGaseosa()
        {
            return ((Producto)this) + "\n" + "LITROS: " + this._litros + "\n";
        }

        public override float CalcularCostoDeProduccion
        {
            get { return this._precio * 0.42f; }
        }

        public override string ToString()
        {
            return this.MostrarGaseosa();
        }

        public override string Consumir()
        {
            return base.Consumir() + "Bebible\n";
        }

        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType());
        }
    }
}
