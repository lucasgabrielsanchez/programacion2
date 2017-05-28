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

        public Gaseosa(int codBarra, EMarcaProducto marca, float precio, float litros)
            : base(codBarra, marca, precio)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto p, float litros)
            : this((int)p, p.Marca, p.Precio, litros)
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
    }
}
