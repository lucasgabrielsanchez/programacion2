using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20Librería
{
    public abstract class Utiles
    {
        public abstract float Precio { get; set; }
        public abstract string Marca { get; set; }

        public Utiles(float precio, string marca)
        {
            this.Precio = precio;
            this.Marca = marca;
        }


        protected virtual string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.GetType().Name);
            sb.AppendLine("--------------------");
            sb.AppendLine("Precio: "+this.Precio);
            sb.AppendLine("Marca: "+this.Marca);

            return sb.ToString();
        }
        
    }
}
