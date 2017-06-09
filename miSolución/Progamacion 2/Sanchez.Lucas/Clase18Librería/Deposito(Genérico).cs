using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18Librería
{
    public class Deposito_Genérico <T> //Una clase con esta firma se transforma en genérica, luego se le podrá pasar cualquier tipo;
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito_Genérico(int capacidad)
        {
            this._lista = new List<T>(); 
            this._capacidadMaxima = capacidad;
        }

        public static bool operator +(Deposito_Genérico<T> d, T a)
        {
            bool aux = false;

            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                aux = true;
            }

            return aux;
        }

        private int GetIndice(T a)
        {
            int aux = -1;

            for (int i = 0; i < this._lista.Count(); i++)
            {
                //if (this._lista[i] == a)
                if (this._lista.Equals(a))//en una clase genérica no se puede usar los operadores sobrecargados
                                          //por eso utilizamos el Equals
                {
                    aux = i;
                    break;
                }
            }

            return aux;
        }


        public static bool operator -(Deposito_Genérico<T> d, T a)
        {
            bool aux = false;
            int indice = d.GetIndice(a);

            if(indice >-1)
            {
                d._lista.RemoveAt(indice);
                aux = true;
            }

            return aux;
        }

        public bool Agregar(T a)
        {
            return (this + a);
        }

        public bool Remover(T a)
        {
            return (this - a);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Capacidad máxima: " + this._capacidadMaxima);
            sb.AppendLine("Listado de cocinas:");

            foreach (T item in this._lista)
            {
                sb.Append(item);
            }

            return sb.ToString();
        }
    }
}
