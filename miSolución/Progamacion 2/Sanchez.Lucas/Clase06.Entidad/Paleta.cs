using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Entidad
{
    public class Paleta
    {
        private Tempera[] _colores;
        private int _cantidadMaximaColores;

        private Paleta()
            : this(5)
        {

        }

        public Paleta(int cant)
        {
            this._colores = new Tempera[cant];
            this._cantidadMaximaColores = cant;
        }

        public static implicit operator Paleta(int cant)
        {
            Paleta Pal = new Paleta(cant);
            return Pal;
        }

        public static explicit operator string(Paleta pa)
        {
            return pa.Mostrar();
        }


        private string Mostrar()
        {
            string salida = null;

            foreach (Tempera t in this._colores)
            {
                salida += (string)t + "\n";
            }

            return "Cantidad de colores" + this._cantidadMaximaColores.ToString() + "\n" + salida;

            //for (int i = 0; i < this._colores.Length; i++)
            //{
            //    auxStr = this._colores[i];
            //    auxStr += i.ToString() + this._colores;
            //}

            //foreach (string carlos in this._colores)
            //{
            //    auxStr += carlos;
            //}
        }

        public static Boolean operator ==(Paleta p, Tempera t)
        {
            Boolean res = false;

            for (int i = 0; i < p._colores.GetLength(0); i++)
            {
                if (p._colores[i] == t)
                {
                    res = true;
                }
            }

            return res;
        }

        public static Boolean operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }


        public int obtenerIndice()
        {
            int res = -1;

            for (int i = 0; i < this._colores.GetLength(0); i++)
            {
                if (this._colores[i] == null)
                {
                    res = i;
                    break; //sino va a seguir iterando y devolviendo un índice erróneo.
                }
            }

            return res;
        }

        public int obtenerIndice(Tempera t)
        {
            int ret = -1;

            for (int i = 0; i < this._colores.GetLength(0); i++)
            {
                if (this._colores[i] == t)
                {
                    ret = i;
                    break;
                }
            }

            return ret;
        }

        public static Paleta operator +(Paleta p, Tempera t)
        {
            if (p == t)
            {
                p._colores[p.obtenerIndice(t)] += t; //es lo mismo que p._colores[p.obtenerIndice(t)] = p._colores[p.obtenerIndice(t)] + t
            }
            else if (p.obtenerIndice() != -1)
            {
                p._colores[p.obtenerIndice()] = t;

            }

            return p;
        }

        public static Paleta operator -(Paleta p, Tempera t)
        {
            int aux = 0;

            for (int i = 0; i < p._colores.GetLength(0); i++)
            {
                
                if (p._colores[i] == t)  
                {
                    aux = p._colores[i] += -t;
                }

                if (aux <= 0)
                {
                    p._colores[i] = null;
                }
            }

            return p;
            
        }


    }

}
