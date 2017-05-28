using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecPrimerParcial
{
    public class Harina : Producto
    {
        private ETipoHarina _tipo;

        public Harina(int codigo, float precio, EMarcaProducto marca, ETipoHarina tipo)
            : base(codigo, marca, precio)
        {
            this._tipo = tipo;
        }

        static Harina()
        {
            Harina.DeConsumo = false;
        }

        private string MostrarHarina()
        {
            return ((Producto)this) + "\n" + "TIPO: " + this._tipo + "\n";
        }

        public override float CalcularCostoDeProduccion
        {
            get { return this._precio * 0.60f; }
        }

        public override string ToString()
        {
            return this.MostrarHarina();
        }

        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType());
        }
    }
}
