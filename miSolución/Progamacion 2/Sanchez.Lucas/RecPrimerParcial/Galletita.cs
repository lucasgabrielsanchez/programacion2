using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecPrimerParcial
{
    public class Galletita : Producto
    {
        protected float _peso;

        public Galletita(int codBarra, EMarcaProducto marca, float precio, float peso)
            : base(codBarra, marca, precio)
        {
            this._peso = peso;
        }

        static Galletita()
        {
            Galletita.DeConsumo = true;
        }

        private static string MostrarGalletita(Galletita g)
        {
            return ((Producto)g) + "\n" + "PESO: " + g._peso + "\n";
        }

        public override float CalcularCostoDeProduccion
        {
            get { return this._precio * 0.33f; }
        }

        public override string Consumir()
        {
            return base.Consumir() + "Comestible";
        }

        public override string ToString()
        {
            return Galletita.MostrarGalletita(this);
        }
    }
}
