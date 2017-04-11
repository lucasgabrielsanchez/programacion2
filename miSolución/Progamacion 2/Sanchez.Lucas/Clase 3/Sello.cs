using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase03
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {   
            return Sello.mensaje;
        }

        public static void Borrar()
        {
            Sello.mensaje = null;
        }

        public static string ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            return Sello.mensaje;
        }

        private static string ArmarMensaje()
        {

            string techo=null, mensaje=null;

            for (int i = 0; i < (Sello.mensaje.Length+2); i++)
            {
                techo += "*";
            }

            mensaje = "*" + Sello.mensaje + "*";

            Sello.mensaje = techo + "\n" + mensaje + "\n" + techo;

            return Sello.mensaje;
        }

        public static string MensajeArmado()
        {
            return ArmarMensaje();
        }




    }
}
