using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14
{
    public class ColectoraDeNumeros
    {
        protected List<Numero> _numeros;

        public ETipoNumero TipoNumero
        {
            get;
            set;
        }

        private ColectoraDeNumeros()
        {
            this._numeros = new List<Numero>();
        }

        public ColectoraDeNumeros(ETipoNumero tipoNumero) : this()
        {
            this.TipoNumero = tipoNumero;
        }

        public static bool operator ==(ColectoraDeNumeros colec, Numero num)
        {
            bool aux = false;

            foreach (Numero item in colec._numeros)
            {
                if (item.NumeroDetalle == num.NumeroDetalle)
                {
                    aux = true;
                }
            }

            return aux;
        }

        public static bool operator !=(ColectoraDeNumeros colec, Numero num)
        {
            return !(colec == num);
        }

        

        public static ColectoraDeNumeros operator +(ColectoraDeNumeros col, Numero num)
        {
            int cantInicialLista = col._numeros.Count();

            switch (col.TipoNumero)
            {
                case ETipoNumero.Par:
                    if (num.NumeroDetalle % 2 == 0)
                    {
                        col._numeros.Add(num);
                    }
                    break;
                case ETipoNumero.Impar:
                    if (num.NumeroDetalle % 2 != 0)
                    {
                        col._numeros.Add(num);
                    }
                    break;
                case ETipoNumero.Positivo:
                    if (num.NumeroDetalle > 0)
                    {
                        col._numeros.Add(num);
                    }
                    break;
                case ETipoNumero.Negativo:
                    if (num.NumeroDetalle < 0)
                    {
                        col._numeros.Add(num);
                    }
                    break;
                case ETipoNumero.Cero:
                    if (num.NumeroDetalle == 0)
                    {
                        col._numeros.Add(num);
                    }
                    break;
                default:
                    break;
            }

            if (col._numeros.Count() == cantInicialLista)
            {
                Console.WriteLine("El numero ingresado no es " + col.TipoNumero.ToString());
            }

            return col;
        }


        public static ColectoraDeNumeros operator -(ColectoraDeNumeros col, Numero num)
        {
            int cantInicialLista = col._numeros.Count();

            for (int i = 0; i < col._numeros.Count; i++)
            {
                if (col == num)
                {
                    col._numeros.Remove(num);
                    break;
                }
                
            }

            if (col._numeros.Count() == cantInicialLista)
            {
                Console.WriteLine("El numero no se encuentra en la coleccion");
            }

            return col;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("El tipo de números que contiene la lista es: " + this.TipoNumero.ToString());
            sb.AppendLine("---------------------");
            sb.AppendLine("Los números son:");

            foreach (Numero item in this._numeros)
            {
                sb.AppendLine(item.NumeroDetalle.ToString());
            }

            return sb.ToString();
        }
        
        
    }
}
