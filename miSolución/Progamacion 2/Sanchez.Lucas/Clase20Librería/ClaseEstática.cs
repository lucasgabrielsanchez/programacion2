using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Clase20Librería
{
    public static class ClaseEstática
    {
        public static bool serializarXML(this ISerializable iser, string patch)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(iser.GetType());
                StreamWriter sw = new StreamWriter(patch);
                xs.Serialize(sw, iser);
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
