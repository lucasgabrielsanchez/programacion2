using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Sobrecarga
{
    public class Pluma
    {
        //Atributos
        private string _marca;
        private int _cantidad;
        private Tinta _tinta;

        //Constructores Sobrecargados
        public Pluma()
        {
            this._marca = "Sin Marca";
            this._cantidad = 0;
            this._tinta = null;
        }

        /*El :this() llama a Pluma() para que se seteen los atributos como aparecen en dicho constructor
         * exceptuando el string marc que se pasa en este constructor nuevo. Des esta manera ahorramos
         * código ya que no hay que setear los demás atributos en este nuevo constructor. Por ejemplo
         * sino usase el :this () el constructor sobrecargado sería así:
         * public Pluma(string marc)  
        {
            this._marca = marc;
            this._cantidad = 0;
            this._tinta = null;
        }
        */
        public Pluma(string marc) : this()  
        {
            this._marca = marc;
        }

        /*Al igual que en el caso de arriba, :this (mark) llama al constructor sobrecargado  public Pluma(string marc)
         *y le pasa como parámetro mark que es el que se usa en estre constructor nuevo, entonces vuelvo a ahorrar
         *código y el único código que tipeo en este constructor es "this._cantidad = num" porque los demás atributos 
         *se cargan con los constructores anteriores.
         */
        public Pluma(int num, string mark) : this(mark)
        {
            this._cantidad = num;
        }

        public Pluma(int nume, string marq, Tinta tint): this(nume, marq)
        {
            this._tinta = tint;
        }


        //Métodos
        public string Mostrar()
        {
            return Tinta.Mostrar(this._tinta) + this._marca + this._cantidad;
        }

        //Sobrecargando operador ==
        public static Boolean operator ==(Tinta t1, Pluma p1)
        {
            return (t1 == p1._tinta); //Acá ya se utiliza el operador == sobrecargado
                                      //de la clase tinta
        }

        //Sobrecargando operador !=
        public static Boolean operator !=(Tinta t1, Pluma p1)
        {
            return !(t1 == p1._tinta);//Acá ya se utiliza el operador != sobrecargado
                                      //de la clase tinta
        }

        // Pluma p = new Pluma();
        // Tinta t = new Tinta();
        // p = p + t ;
        public static Pluma operator +(Pluma p, Tinta t)
        {
            if (p._tinta == t)
                p._cantidad++;
            return p;
        }

        /*
         *LO QUE HACE BASICAMENTE EL ALGORITMO DE ABAJO,
         * ES COMPARAR MEDIANTE EL OPERADOR SOBRECARGADO == (DE UNOS METODOS DE ARRIBA) EL ATRIBUTO DE TIPO
         * _tinta DE LA CLASE Pluma CON LA CLASE TINTA. EN CASO DE QUE SEA IGUAL, ES DECIR, QUE EN LA SENTENCIA:
         * Pluma p = new Pluma();
         * Tinta t = new Tinta();
         * p = p - t;
         * SE LE RESTE DEL ATRIBUTO CANTIDAD DE LA CLASE PLUMA, UNA UNIDAD. EN CASO DE QUE LA CANTIDAD SEA 0 O MENOR 
         * A 0 ( PORQUE POR AHI SE UTILIZO DE OTRA MANERA "INCORRECTA" QUE CAUSE QUE LA CANTIDAD SEA MENOR A 0), 
         * EL ATRIBUTO _tinta DE LA CLASE Pluma SE DECLARA null.
        */
        public static Pluma operator -(Pluma p, Tinta t)
        {
            if (p._tinta == t)
            {
                p._cantidad--;
                if (p._cantidad == 0 || p._cantidad < 0)
                {
                    p._tinta = null;
                }
            }
            return p;
        }

        /*
         * ABAJO ESTA LA SINTAXIS DE COMO HACER EL CASTEO IMPLICITO DE 
         * UNA CLASE DE TIPO Pluma. SU APLICACION SERIA PARA COMO POR EJEMPLO ASI:
         * Pluma pluma = new Pluma();
         * ConsoleWrite(pluma);
         * CALCULO QUE ES EL UNICO CASTEO EXPLICITO EN QUE SE PUEDE APLICAR YA QUE SU
         * SENTENCIA SOLO DEVUELVE EL METODO QUE MUESTRA CADA ATRIBUTO COMO UN STRING.
        */
        public static implicit operator string(Pluma p)
        {
            return p.Mostrar();
        }


        /*
             Tinta a = new Tinta();
             Pluma b = new Pluma();
             a=(Tinta) b ;
             
         * EL CODIGO DE ABAJO, ES LO QUE INTENTA HACER QUE SE PUEDA CASTEAR EXPLICITAMENTE UN OPERADOR.
        */
        public static explicit operator Tinta(Pluma y)
        {
            return y._tinta;
        }



    }
}

