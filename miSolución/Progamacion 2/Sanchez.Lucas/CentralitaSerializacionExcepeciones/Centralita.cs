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


        public Centralita(string nombreEmpresa): this()
        {
            this._razonSocial = nombreEmpresa;
        }

        private Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float total = 0;
            foreach (Llamada item in this._listaDeLlamadas)
            {
                switch (tipo)
                {
                    //case TipoLlamada.Local:
                    //    if (item is Local)
                    //    {
                    //        total += ((Local)item).CostoLlamada;
                    //    }
                    //    break;
                    //case TipoLlamada.Provincial:
                    //    if (item is Provincial)
                    //    {
                    //        total += ((Provincial)item).CostoLlamada;
                    //    }
                    //    break;
                    //default:
                    //    if (item is Local)
                    //    {
                    //        total += ((Local)item).CostoLlamada;
                    //    }

                    //    if (item is Provincial)
                    //    {
                    //        total += ((Provincial)item).CostoLlamada;
                    //    }
                        
                    //    break;

                    case TipoLlamada.Local:
                        if (item is Local)
                        {
                            total += item.CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if (item is Provincial)
                        {
                            total += item.CostoLlamada;
                        }
                        break;
                    default:
                        total += item.CostoLlamada;
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

        public string RazonSocial // agregado con respecto al ejercicio anterior
        {
            get { return this._razonSocial; }
            set { this._razonSocial = value; }
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
            try
            {
                this.GuardarEnArchivo(nuevaLlamada, true);
            }
            catch (Exception e)
            {
                CentralitaException CE = new CentralitaException(e.Message, this.GetType().Name, "Método AgregarLLamada",e);
                Console.WriteLine("La excepción es: {0} - La clase que la causó es: {1} - El método que lo causó es: {2}", CE.ExcepcionInterna.Message, CE.NombreClase, CE.NombreMetodo);
            }
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
                throw new CentralitaException("La central ya tiene esta llamada", typeof(Centralita).Name, "Operador +");
                //Console.WriteLine("La llamada ya existe dentro de la central");
                //Console.ReadLine();
            }

            return cen;
        }


        public bool Serializarse() //método implementado de la interfaz ISerializable
        {
            bool aux = false;
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Centralita));
                StreamWriter sw = new StreamWriter(this._ruta);
                xs.Serialize(sw, this);
                sw.Close();
                aux = true;
            }
            catch (Exception e)
            {
                throw new CentralitaException("Mi mensaje: No se pudo serializar", this.GetType().Name, "Método Serializarse", e);
                //CentralitaException ce = new CentralitaException("Mi mensaje: No se pudo serializar", e.Source.ToString(), e.TargetSite.ToString(), e);
                //aux = false;
            }

            return aux;
        }

        public bool Deserializarse() //método implementado de la interfaz ISerializable
        {
            bool aux = false;
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Centralita));
                StreamReader sr = new StreamReader(this.RutaDeArchivo);
                xs.Deserialize(sr);
                sr.Close();
                aux = true;
            }
            catch (Exception e)
            {
                CentralitaException CE = new CentralitaException(e.Message, this.GetType().Name, "Método Deserializarse", e);
                throw CE;
            }
            return aux;
        }

        private bool GuardarEnArchivo(Llamada unaLlamada, bool agrego)
        {
            bool aux = false;
            try
            {
                StreamWriter sw = new StreamWriter(this._ruta + "Llamadas.txt", agrego);//si la ruta es null o no está cargada, por defecto se guarda en la carpeta del programa.
                sw.WriteLine("Fecha y Hora: {0}" ,DateTime.Now);
                sw.WriteLine(unaLlamada);
                sw.Close();
                aux = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return aux;
        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);//cuando se llama a un método de ordenamiento no se le pasan parámetros, inclusive si este método los pidiese, como es este caso.
        }

    }
}
