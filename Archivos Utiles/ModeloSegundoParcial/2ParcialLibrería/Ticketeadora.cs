using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2ParcialLibrería
{
    public static class Ticketeadora
    {
        /// <summary>
        /// Método de extensión que aparecerá en la lista de métodos propios al instanciar un Cajon de tipo Platano.
        /// returna true/false si se pudo o no se pudo crear el archivo.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="patch"></param>
        /// <returns></returns>
        public static bool ImprimirTicket(this Cajon<Platano> c, string patch)
        {
            try
            {
                StreamWriter sw = new StreamWriter(patch);
                sw.WriteLine("Fecha y hora: {0}",DateTime.Now);
                sw.WriteLine("Precio Total del Cajón: {0}", c.PrecioTotal);
                sw.Close();
                return true;
            }
            catch
            {

                return false;
            }

        }
    }
}
