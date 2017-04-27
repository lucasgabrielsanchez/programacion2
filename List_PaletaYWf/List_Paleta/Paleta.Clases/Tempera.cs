using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Paletas.Entidades
{
    public class Tempera
    {
        #region ATRIBUTOS
        private ConsoleColor _color;
        private string _marca;
        private int _cantidad;
        #endregion ATRIBUTOS

        #region PROPIEDADES
        public ConsoleColor Color
        {
            set { _color = value; }
            get { return _color; }
        }
        public string Marca
        {
            set { _marca = value; }
            get { return _marca; }
        }
        public int Cantidad
        {
            set { _cantidad = value; }
            get { return _cantidad; }
        }
        #endregion PROPIEDADES

        #region CONSTRUCTOR
        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            _color = color;
            _marca = marca;
            _cantidad = cantidad;
        }
        #endregion CONSTRUCTOR

        #region METODOS MOSTRAR
        private string Mostrar()
        {
            return "\n--Color: " + _color.ToString() + "\n--Marca: " + _marca + "\n--Cantidad: " + _cantidad.ToString();
        }

        public static string Mostrar(Tempera temp)
        {
            return "\nColor: " + temp._color.ToString() + "\nMarca: " + temp._marca + "\nCantidad: " + temp._cantidad.ToString();
        }
        #endregion METODOS MOSTRAR

        #region CASTEOS
        public static implicit operator int(Tempera temp)
        {
            return temp._cantidad;
        }

        public static explicit operator string(Tempera temp)
        {
            return temp.Mostrar();
        }
        #endregion CASTEOS

        #region SOBRECARGA DE OPERADORES
        public static Boolean operator ==(Tempera temp1, Tempera temp2)
        {
            Boolean retorno = false;
            if (temp1._marca == temp2._marca & temp1._color == temp2._color)
                retorno = true;
            return retorno;
        }

        public static Boolean operator !=(Tempera temp1, Tempera temp2)
        {
            return !(temp1 == temp2);
        }

        public static Tempera operator +(Tempera temp1, Tempera temp2)
        {
            if (temp1 == temp2)
                temp1 = temp1 + temp2._cantidad;
            return temp1;
        }

        public static Tempera operator +(Tempera temp, int cantidad)
        {
            temp._cantidad += cantidad;
            return temp;
        }
        #endregion SOBRECARGA DE OPERADORES

    }
}
