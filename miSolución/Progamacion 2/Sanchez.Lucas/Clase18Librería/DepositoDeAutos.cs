using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18Librería
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>(); 
            this._capacidadMaxima = capacidad;
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool aux = false;

            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                aux = true;
            }

            return aux;
        }

        private int GetIndice(Auto a)
        {
            int aux = -1;

            for (int i = 0; i < this._lista.Count(); i++)
            {
                if (this._lista[i] == a)
                {
                    aux = i;
                    break;
                }
            }

            return aux;
        }


        public static bool operator -(DepositoDeAutos d, Auto a)
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

        public bool Agregar(Auto a)
        {
            return (this + a);
        }

        public bool Remover(Auto a)
        {
            return (this - a);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad máxima: " + this._capacidadMaxima);
            sb.AppendLine("Listado de autos:");

            foreach (Auto item in this._lista)
            {
                sb.Append(item);
            }

            return sb.ToString();
        }
    }
}
