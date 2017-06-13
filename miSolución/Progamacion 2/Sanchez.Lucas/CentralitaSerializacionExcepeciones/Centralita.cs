using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace CentralitaSerializacionExcepeciones
{
    public class Centralita : ISerializable //modificador de visivilidad cambiado para poder ser serializado.
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        private string _ruta;

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

        //public void Mostrar()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendFormat("Razón Social: \"{0}\"\n\n", this._razonSocial); //con el /" alrededor del indice u objeto, hago que el objeto se rodee de comillas al imprimirse.
        //    sb.AppendLine("Ganancias:");
        //    sb.AppendLine("-------------------------------");
        //    sb.AppendFormat("Ganancia Total: ${0}\nGanancia Local: ${1}\nGanancia Provincial: ${2}\n\n", this.GananciaTotal, this.GananciaPorLocal, this.GananciaPorProvincial);
        //    foreach (Llamada item in this._listaDeLlamadas)
        //    {
        //        sb.AppendLine(item.ToString());
        //    }

        //    Console.WriteLine(sb);
        //}

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

        public List<Llamada> Llamadas //set agregado con respecto al ejercicio anterior
        {                             
            get
            {
                return this._listaDeLlamadas;
            }
            set
            {
                this._listaDeLlamadas = value;
            }
        }

        public string RazonSocial // agregado con respecto al ejercicio anterior
        {
            get { return this._razonSocial; }
            set { this._razonSocial = value; }
        }

        public string RutaDeArchivo // Agregado con respecto al ejercicio anterior.
        {                           // Propiedad escrita que pertenece a la interface ISerializable.
            get { return this._ruta; }
            set { this._ruta = value; }
        }
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Razón Social: \"{0}\"\n\n", this._razonSocial); //con el /" alrededor del indice u objeto, hago que el objeto se rodee de comillas al imprimirse.
            sb.AppendLine("Ganancias:");
            sb.AppendLine("-------------------------------");
            sb.AppendFormat("Ganancia Total: ${0}\nGanancia Local: ${1}\nGanancia Provincial: ${2}\n\n", this.GananciaTotal, this.GananciaPorLocal, this.GananciaPorProvincial);
            foreach (Llamada item in this._listaDeLlamadas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool aux = false;

            if (obj is Centralita && this == ((Centralita)obj))
            {
                aux = true;
            }

            return aux;
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita cent, Llamada llamadaNueva)
        {
            bool aux = false;

            foreach (Llamada item in cent._listaDeLlamadas)
            {
                //if (item == llamadaNueva)

                if (item.Equals(llamadaNueva))
                {
                    aux = true;
                }
            }

            return aux;
        }

        public static bool operator !=(Centralita cent, Llamada llam)
        {
            return !(cent == llam);
        }


        public static Centralita operator +(Centralita cen, Llamada llamadaNueva)
        {
            if (cen != llamadaNueva)
            {
                cen.AgregarLlamada(llamadaNueva);
            }
            else
            {
                Console.WriteLine("La llamada ya existe dentro de la central");
                Console.ReadLine();
            }

            return cen;

        }


        public bool Serializarse()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Centralita));
                StreamWriter sw = new StreamWriter(this._ruta);
                xs.Serialize(sw, this);
                sw.Close();
                return true;
            }
            catch (Exception e)
            {
                throw e;
                //Console.WriteLine(e.Message);
                //return false;
            }
        }

        public bool Deserializarse()
        {
            return true;
        }

    }
}
