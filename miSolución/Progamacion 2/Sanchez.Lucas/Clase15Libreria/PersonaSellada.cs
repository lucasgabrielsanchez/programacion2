using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;

namespace Clase15Libreria
{
    public static class PersonaSellada
    {
        public static void ObtenerInfo(this PersonaExternaSellada p)
        {
            Console.WriteLine("Nombre: {0} -- Apellido: {1} -- Edad: {2} -- Sexo: {3}", p.Nombre,p.Apellido, p.Edad, p.Sexo);
        }

        public static int Cantidad(this string s)
        {
            return s.Length;
        }


    }
}
