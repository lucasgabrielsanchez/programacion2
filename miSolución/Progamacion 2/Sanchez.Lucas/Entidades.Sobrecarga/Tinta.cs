using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Sobrecarga
{
    public class Tinta
    {
        //Atributos
        private ConsoleColor color;
        private ETipo tipo;
        public static int numeroPrueba;

        //Constructores sobrecargados
        public Tinta()
        {
            this.color = ConsoleColor.Blue;
            this.tipo = ETipo.Comun;
        }

        static Tinta()
        {
            Tinta.numeroPrueba = 5; //testeando el uso de un atributo estático, no se pide en el ejercicio, en el main también se uitiliza el atributo.
                                    //Este constructor hace que ni bien se ejecute el main, se inicialize el atributo estático en 5.
                                    //Nótese que un constructor estático lleva la palabra reservada "static".
        }

        public Tinta(ConsoleColor a) :this()
        {
            this.color = a;
        }

        public Tinta(ETipo b, ConsoleColor a) : this (a)
        {
            this.tipo = b;
        }

        //Métodos
        private string Mostrar()
        {
            return this.color.ToString() + this.tipo.ToString();
        }

        public static string Mostrar(Tinta obj)
        {
            return obj.color.ToString() + obj.tipo.ToString();
        }

        // Sobrecargando operador ==
        public static Boolean operator == (Tinta t1, Tinta t2)
        {
            if ((t1.color == t2.color) & (t1.tipo == t2.tipo))
                return true;
            else
                return false;
            
        }

        public static Boolean operator != (Tinta t1, Tinta t2) 
        //El operador requiere sobrecargar a su opuesto.

        {
            return !(t1 == t2);  //niego el resultado de la función de arriba;
        }


    }
}
