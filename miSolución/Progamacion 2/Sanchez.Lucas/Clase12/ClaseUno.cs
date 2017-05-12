using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12
{
    public class ClaseUno
    {
        protected string _atributoClaseUno; //atributo

        public ClaseUno(string atrib) //constructor
        {
            this._atributoClaseUno = atrib;
        }

        //public string TipoClaseUno //propiedad solo lectura
        //{
        //    get { return "Clase Uno"; } 
        //}

        //public string MostrarClaseUno() //metodo
        //{
        //    return this._atributoClaseUno;
        //}

        public virtual string Tipo //propiedad solo lectura
        {
            get { return "Clase Uno \n"; }
        }

        public virtual string Mostrar() //metodo
        {
            return this._atributoClaseUno;
        }

        public override string ToString() //sobreescribiendo el funcionamiento del metodo ToString que es virtual
        {                                 //y se desprende de la clase nativa Object para que retorne el Mostrar() de esta clase
            return this.Mostrar();
        }
    }
}
