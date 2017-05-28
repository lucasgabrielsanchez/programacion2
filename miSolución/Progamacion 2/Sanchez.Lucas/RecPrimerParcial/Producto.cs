using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecPrimerParcial
{
    public abstract class Producto
    {
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;
        protected static bool DeConsumo;
        

        public Producto(int codBarra, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codBarra;
            this._marca = marca;
            this._precio = precio;
        }

        public EMarcaProducto Marca 
        { 
            get {return this._marca;}
        }

        public float Precio
        {
            get { return this._precio; }
        }

        public abstract float CalcularCostoDeProduccion { get; }

        public virtual string Consumir()
        {
            return "Parte de una mezcla.";
        }

        private static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("MARCA: {0}\nCÓDIGO DE BARRAS: {1}\nPRECIO: {2}",p._marca,p._codigoBarra,p._precio);
            return sb.ToString();
        }

        public static bool operator ==(Producto prodUno, Producto prodDos)
        {
            bool aux = false;

            if (prodUno.GetType() == prodDos.GetType())
            {
                if ((prodUno._marca == prodDos._marca) && (prodUno._codigoBarra == prodDos._codigoBarra))
                {
                    aux = true;
                }
            }

            return aux;
        }

        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            return !(prodUno == prodDos);
        }

        public static bool operator ==(Producto prodUno, EMarcaProducto marca)
        {
            bool aux = false;

            if (prodUno._marca == marca)
            {
                aux = true;
            }

            return aux;
        }

        public static bool operator !=(Producto prodUno, EMarcaProducto marca)
        {
            return !(prodUno == marca);
        }

        public static explicit operator int(Producto p)
        {
            return p._codigoBarra;
        }

        public static implicit operator string(Producto p)
        {
            return Producto.MostrarProducto(p);
        }

        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType());
        }


    }
}
