using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        private List<Mascota> _manada;
        private string _nombre;
        private static EtipoManada _tipo;

        private Grupo()
        {
            this._manada = new List<Mascota>();
        }

        static Grupo()
        {
            Grupo._tipo = EtipoManada.Unica;
        }

        public Grupo(string nombre) : this()
        {
            this._nombre = nombre;
        }

        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            Grupo._tipo = tipo;
        }

        public EtipoManada Tipo
        {
            set {  Grupo._tipo = value; } 
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            bool aux = false;

            foreach (Mascota item in g._manada)
            {
                if (m.Equals(item))
                {
                    if (item == m)
                        aux = true;
               }
                   
            }

            return aux;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
                g._manada.Add(m);
            else
                Console.WriteLine("Ya está el {0} en el grupo.",m);
            
            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            
            if (g == m)
            {
                g._manada.Remove(m);
            }
            else 
            {
                Console.WriteLine("No está el {0} en el grupo.",m);
            }
            return g;
        }

        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Grupo: {0} - tipo: {1}\n", g._nombre, Grupo._tipo.ToString());
            sb.AppendFormat("Integrantes <{0}>:\n", g._manada.Count);

            foreach (Mascota item in g._manada)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
