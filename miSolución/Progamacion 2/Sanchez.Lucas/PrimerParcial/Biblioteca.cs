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

            sb.AppendFormat("Total por Manuales: $ {0:N2}\n", b.ObtenerPrecio(ELibro.Manual));
            sb.AppendFormat("Total por Novelas: $ {0:N2}\n", b.ObtenerPrecio(ELibro.Novela));
            sb.AppendFormat("Total: $ {0:N2}\n", b.ObtenerPrecio(ELibro.Ambos));

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
            
            //Debo discriminar entre los tipos para preguntar por la igualdad, ya que si no lo hago, por ejemplo un Manual, también
            //es un libro, entonces preguntaría por la igualdad de libro y por la igualdad de Manual.
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
                    aux = true;
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

                foreach (Libro item in this._libros)
                {
                    if (item is Manual)
                    {
                        aux += (Manual)item;
                    }
                }

                return aux;
            }       
        }

        public double PrecioDeNovelas
        {
            get
            {
                double aux = 0;

                foreach (Libro item in this._libros)
                {
                    if (item is Novela)
                    {
                        aux += (Novela)item;
                    }
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
