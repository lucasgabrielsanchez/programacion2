using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecPrimerParcial
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        private Estante()
        {
            this._productos = new List<Producto>();
        }

        public Estante(sbyte capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public List<Producto> GetProducto()
        {
            return this._productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CAPACIDAD: {0}", e._capacidad);

            foreach (Producto item in e._productos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool aux = false;

            foreach (Producto item in e._productos)
            {
                if (item.Equals(p))
                {
                    if (((Producto)item) == ((Producto)p))
                    {
                        aux = true;
                        break; //para que no siga iterando el foreach
                    }
                }
            }

            return aux;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

    }
}
