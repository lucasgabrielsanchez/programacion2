using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public class Libro
    {
        #region Atributos
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;
        #endregion

        #region Constructores

        //Usamos el constructor estático para inicializar atributos estáticos. En este caso el único atributo estático que tenemos es 
        //_generadorDePaginas, como pertenece a la clase Random, la forma de iniciarlo para este caso es dándole espacio en memoria
        //osea instanciándolo.
        static Libro()
        {
            Libro._generadorDePaginas = new Random();
        }

        //En este constructor, a diferencia de lo que venimos acostumbrados (que es heredar de otra clase para invocar a sus
        //constructores), acá tenemos como parámetro de esta clase, a un Autor, y esta clase no hereda de ninguna, por lo tanto
        //dentro del constructor, instanciamos al Autor y como parámetros le pasamos los que el constructor recibe. (nombre y apellido).
        public Libro(float precio, string titulo, string nombreL, string apellidoL)
        {
            this._autor = new Autor(nombreL,apellidoL);
            this._precio = precio;
            this._titulo = titulo;
        }

        //public Libro(string titulo, Autor autor, float precio) :this(precio,titulo,"","")
        //{
        //    this._autor = autor;
        //}

        public Libro(string titulo, Autor autor, float precio)
        {
            this._titulo = titulo;
            this._autor = autor;
            this._precio = precio;
        }
        #endregion

        #region Propiedades
        public int CantidadDePaginas
        {
            get
            {
                if (this._cantidadDePaginas == 0)
                {
                    this._cantidadDePaginas = Libro._generadorDePaginas.Next(10,580);
                }

                return this._cantidadDePaginas;
            }
        }
        #endregion

        #region Métodos
        private static string Mostrar(Libro l)
        {
            StringBuilder sb = new StringBuilder();

            //sb.AppendLine("Autor del Libro: "+ l._autor); //con el Appendline pasándole el objeto Autor, implícitamente
                                                            //estoy invocando al operator implicit de la clase Autor, ya 
                                                            //que Appendline requiere de un string pasado como objeto.
            //sb.AppendLine("----------------------");


            //Dentro de este AppendFormat, para mostrar el valor de cantidad de paginas, en vez de acceder al atributo _cantidadDePaginas
            //accedo a la propiedad CantidadDePaginas ya que es la que calcula la cantidad Random de páginas si la cantidad inicial es 0;
            sb.AppendFormat("TÍTULO: {0}\nCANTIDAD DE PÁGINAS: {1}\nAUTOR: {2}\nPRECIO: {3}\n", l._titulo, l.CantidadDePaginas, (string)l._autor, l._precio);

            return sb.ToString();
        }
        #endregion

        #region Sobrecargas de Operadores
        public static bool operator ==(Libro a, Libro b)
        {
            bool aux = false;

            if (a._autor == b._autor && a._titulo == b._titulo)
            {
                aux = true;
            }

            return aux;
        }

        public static bool operator !=(Libro a, Libro b)
        {
           return !(a == b);
        }

        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }
        #endregion
    }
}
