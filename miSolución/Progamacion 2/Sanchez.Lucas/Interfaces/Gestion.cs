using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Gestion
    {
        public static double MostrarImpuestoNacional(this IAFIP bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }

        public static double MostrarImpuestoProvincial(this IARBA bienPunible2)
        {
            return bienPunible2.CalcularImpuesto();
        }

    }
}
