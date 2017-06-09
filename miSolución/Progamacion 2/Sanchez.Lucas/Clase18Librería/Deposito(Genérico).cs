using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18Librería
{
    public class Deposito<T> //Una clase con esta firma se transforma en genérica, luego se le podrá pasar cualquier tipo;
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._lista = new List<T>(); 
            this._capacidadMaxima = capacidad;
        }

        public static bool operator +(Deposito<T> d, T a)
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
                if (this._lista[i].Equals(a))//en una clase genérica no se puede usar los operadores sobrecargados
                                          //por eso utilizamos el Equals
                {
                    aux = i;
                    break;
                }
            }

            return aux;
        }


        public static bool operator -(Deposito<T> d, T a)
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
            string tipoClase = typeof(T).ToString();//guardo en un string, el tipo de la clase que se recibe en esta clase genérica
                                                    //tiene el formato "Clase18Librería.Cocina"                    
            sb.AppendLine("Capacidad máxima: " + this._capacidadMaxima);
            sb.AppendFormat("Listado de {0}:\n", tipoClase.Substring((tipoClase.IndexOf('.'))+1));//Para mostrar sólo el tipo de Clase 
            //en la salida de la consola, uso el método Substring que selecciona y corta una parte de un string a partir de una posición
            //que le pasamos. Yo deseo guardar lo que sale despues del punto, osea de "Clase18Librería.Cocina", guardar solo "Cocina".
            //Para ello le paso como indice al Substring, el Indexof de '.' y le sumo 1 asi recorta la parte que dice "Cocina".
            foreach (T item in this._lista)
            {
                sb.Append(item);
            }

            return sb.ToString();
        }
    }
}
