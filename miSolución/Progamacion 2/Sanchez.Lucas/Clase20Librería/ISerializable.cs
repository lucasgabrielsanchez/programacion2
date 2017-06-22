using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20Librería
{
    public interface ISerializable
    {
        bool SerializarXML(string path);

        bool DeserializarXML(string path);
    }
}
