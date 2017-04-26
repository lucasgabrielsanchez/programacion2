using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Entidad
{
    public class Tempera
    {
        //Atributos
        private ConsoleColor _color;
        private string _marca;
        private int _cantidad;

        //Constructor con 3 parámetros
        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this._cantidad = cantidad;
            this._marca = marca;
            this._color = color;
        }

        //Métodos de instancia
        private string Mostrar()
        {
            return "La marca es : " + this._marca + "\nEl color es : " + this._color.ToString() + "\nLa cantidad es : " + this._cantidad.ToString();
        }

        //Métodos de clase
        public static string Mostrar(Tempera objTempera)
        {
            return "La marca es : " + objTempera._marca + "\nEl color es : " + objTempera._color.ToString() + "\nLa cantidad es : " + objTempera._cantidad.ToString();
        }

        //sobrecargas:
        public static Boolean operator == (Tempera t1, Tempera t2)
        {
            if ((t1._marca == t2._marca) && (t1._color == t2._color))
                return true;
            else
                return false;

        }

        public static Boolean operator != (Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static implicit operator int(Tempera t)
        {
            return t._cantidad;
        }

        public static explicit operator string(Tempera t)
        {
            return t.Mostrar();
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            if (t1 == t2)
            {
                //t1._cantidad = t1._cantidad + t2._cantidad;
                t1._cantidad = t1 + t2._cantidad; // ahorro código porque el operador + en este caso llama al método de abajo "public static Tempera operator +(Tempera t1, int cant)"
                                                  // para comparar un objeto del tipo Tempera con un atributo de tipo entero y sumarse.
            }
            return t1;
        }

        public static Tempera operator +(Tempera t1, int cant)
        {
            t1._cantidad = t1._cantidad + cant;
            return t1;
        }


    }
}
