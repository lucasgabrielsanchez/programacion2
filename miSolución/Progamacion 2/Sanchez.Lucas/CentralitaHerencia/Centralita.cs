using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        private Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float total = 0;
            foreach (Llamada item in this._listaDeLlamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if (item is Local)
                        {
                            total += ((Local)item).CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if (item is Provincial)
                        {
                            total += ((Provincial)item).CostoLlamada;
                        }
                        break;
                    default:
                        if (item is Local)
                        {
                            total += ((Local)item).CostoLlamada;
                        }

                        if (item is Provincial)
                        {
                            total += ((Provincial)item).CostoLlamada;
                        }
                        
                        break;
                }
            }

            return total;
        }

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }
    }
}
