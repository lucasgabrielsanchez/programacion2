using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ParcialLibrería
{
    public class Platano : Fruta
    {
        public string paisOrigen;

        /*Agregado, no fué pedido en el parcial*/
        public Platano()
        {
        }

        public Platano(float peso, ConsoleColor color, string pais): base(peso, color)
        {
            this.paisOrigen = pais;
        }

        public override bool TieneCarozo
        {
            get { return false; }
        }

        public string Tipo
        {
            get { return "Platano"; }
        }

        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Tipo);
            sb.AppendLine("------------------");
            sb.AppendFormat(base.FrutaToString());
            sb.AppendLine("País de origen: " + this.paisOrigen);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
