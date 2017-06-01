using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deportivo : Auto, IAFIP, IARBA
    {
        protected int _caballosFuerza;

        public Deportivo(double precio, string patente, int hp) : base (precio, patente)
        {
            this._caballosFuerza = hp;
        }

        public double CalcularImpuesto()
        {
            return base._precio * 0.28;
        }

        public override void MostrarPatente()
        {
            Console.WriteLine(base._patente);
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine(base._precio);
        }

        double IARBA.CalcularImpuesto()
        {
            return base._precio * 0.23;
        }
    }
}
