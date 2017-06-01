using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Familiar : Auto
    {
        protected int _cantAsientos;

        public Familiar(double precio, string patente, int cantidadAsientos) : base(precio,patente)
        {
            this._cantAsientos = cantidadAsientos;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine(base._precio);
        }

        public override void MostrarPatente()
        {
            Console.WriteLine(base._patente);
        }
    }
}
