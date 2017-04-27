using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Paletas.Entidades
{
    public class Paleta
    {
        #region ATRIBUTOS
        private List<Tempera> _colores;
        //private int _cantidadMaximaColores;
        #endregion ATRIBUTOS

        #region PROPIEDADES
        public List<Tempera> Colores
        {
            set 
            {
                _colores = value;
            }
            get 
            {
                return _colores;
            }
        }
        #endregion PROPIEDADES

        #region CONSTRUCTORES
        public Paleta()
        {
            _colores = new List<Tempera>();
           //_cantidadMaximaColores = _colores.Capacity;
        }
        /* NO SE CREA CONSTRUCTOR CON CANTIDAD DE ELEMENTOS EN LIST
        public Paleta()
            : this(5)
        {
        }
         */
        #endregion CONSTRUCTORES

        #region CASTEO
        /* 
        public static implicit operator Paleta(int cantidadColores)
        {
            Paleta paletita = new Paleta(cantidadColores);
            return paletita;
        }
        */

        private string Mostrar()
        {
            StringBuilder datosPaleta = new StringBuilder();
            foreach (Tempera temp in _colores)
            {
                datosPaleta.AppendLine((string)temp);
            }
            //datosPaleta.AppendLine("Cantidad maxima de colores: " + _cantidadMaximaColores.ToString());

            return datosPaleta.ToString();
        }

        public static explicit operator string(Paleta datosPaleta)
        {
            return datosPaleta.Mostrar();
        }
        #endregion CASTEO

        #region SOBRECARGA DE OPERADORES
        /* SE PUEDE REEMPLAZAR POR> paleta._colores.Contains(temp)
        public static bool operator ==(Paleta paleta, Tempera temp)
        {
            bool retorno = false;
            foreach (Tempera temp1 in paleta._colores)
            {
                if (temp1 == temp)
                {
                    retorno = true;
                    break;
                }  
            }
            return retorno;
        }
         

        public static bool operator !=(Paleta paleta, Tempera temp)
        {
            return !(paleta == temp);
        }
        */

        /* SE DESCARTA PORQUE NO EXISTE INDICE NULO
        private int ObtenerIndice()
        {
            int indice = -1;
            for (int i = 0; i < _cantidadMaximaColores; i++)
            {
                if (_colores[i] == null)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }
        /*
        /* LO REEEMPLAZO POR .INDEXOF()
        private int ObtenerIndice(Tempera tempera)
        {
            int indice = -1;
            for (int i = 0; i < _cantidadMaximaColores; i++)
            {
                if (_colores[i] == tempera)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }
         */

        public static Paleta operator +(Paleta paleta, Tempera temp)
        {
            if (paleta._colores.Contains(temp))
                paleta._colores[paleta._colores.IndexOf(temp)] += temp;
            else
                //paleta._colores[paleta._colores.IndexOf()] = temp;
                paleta._colores.Add(temp);

            return paleta;
        }

        public static Paleta operator -(Paleta paleta, Tempera temp)
        {
            if (paleta._colores.Contains(temp))
            {
                paleta._colores[paleta._colores.IndexOf(temp)] += -temp;
                int cantidad = paleta._colores[paleta._colores.IndexOf(temp)];
                if (cantidad <= 0)
                {
                    //paleta._colores[paleta._colores.IndexOf(temp)] = null;
                    paleta._colores.Remove(temp);
                }
            }
            return paleta;
        }


        public static Paleta operator +(Paleta paletaUno, Paleta paletaDos)
        {
            Paleta paletaTres = new Paleta();

            for (int i = 0; i < paletaUno._colores.Count; i++)
            {
                paletaTres += paletaUno._colores[i];
            }

            for (int i = 0; i < paletaUno._colores.Count; i++)
            {
                paletaTres += paletaDos._colores[i];
            }

            return paletaTres;
        }
        #endregion SOBRECARGA DE OPERADORES
    }
}
