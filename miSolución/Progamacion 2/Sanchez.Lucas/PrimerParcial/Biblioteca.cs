using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }

        private Biblioteca(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public static string Mostrar(Biblioteca b)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad: " + b._capacidad);

            sb.AppendLine("*********************************************");
            sb.AppendLine("Listado de Libros");
            sb.AppendLine("*********************************************");

            foreach (Libro item in b._libros)
            {
                if (item is Novela)
                {
                    sb.AppendLine(((Novela)item).Mostrar());
                }

                else if (item is Manual)
                {
                    sb.AppendLine(((Manual)item).Mostrar());
                }

                else
                {
                    sb.AppendLine((string)item);
                }

            }

            return sb.ToString();
        }

        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca nuevaInstancia = new Biblioteca(capacidad);
            return nuevaInstancia;
        }

        public static bool operator ==(Biblioteca b, Libro l)
        {
            bool aux = false;
            //en este caso no es necesario preguntar dentro del foreach si el libro recibido por parámetro es de tipo Libro,Novela o manual
            //porque el == va a responder por si mismo dependiendo de que haya de cada lado de la igualdad, por la simple razón de que tanto
            //Libro,Novela y Manual tienen su propia sobrecarga de comparación del ==, podría decirse que esto es reutilizar código.
            foreach (Libro item in b._libros)
            {
                if (item is Manual)
                {
                    if (item == l)
                    aux = true;
                    break;//Hago un break ya que no necesito seguir recorriendo el foreach si ya se dió la igualdad.
                }

                else if (item is Novela)
                {
                    if (item == l)
                        aux = true;
                    break;//Hago un break ya que no necesito seguir recorriendo el foreach si ya se dió la igualdad.
                }

                else if (item == l)
                {
                    aux == true;
                }
            }

            return aux;
        }

        public static bool operator !=(Biblioteca b, Libro l)
        {
            return !(b == l);
        }

        public static Biblioteca operator +(Biblioteca b, Libro l)
        {
            if (b._libros.Count < b._capacidad)
            {
                if (b != l)
                {
                    b._libros.Add(l);
                }
                else
                {
                    Console.WriteLine("El libro ya está en la biblioteca!!");
                }
            }
            else
            {
                Console.WriteLine("No hay mas lugar en la biblioteca!!");
            }

            return b;
        }

        public double PrecioDeManuales 
        {
            get
            {
                double aux = 0;

                foreach (Manual item in this._libros)
                {
                    aux += item;
                }

                return aux;
            }       
        }

        public double PrecioDeNovelas
        {
            get
            {
                double aux = 0;

                foreach (Novela item in this._libros)
                {
                    aux += item;
                }

                return aux;
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.PrecioDeManuales + this.PrecioDeNovelas;
            }
        }



        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double aux = 0;

            switch (tipoLibro)
            {
                case ELibro.Manual:
                    aux += this.PrecioDeManuales;
                    break;
                case ELibro.Novela:
                    aux += this.PrecioDeNovelas;
                    break;
                case ELibro.Ambos:
                    aux += this.PrecioTotal;
                    break;
            }

            return aux;
        }

    }
}
