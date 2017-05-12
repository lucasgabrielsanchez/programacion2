using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12
{
    public class ClaseDos : ClaseUno
    {
        protected string _atributoClaseDos; //atributo

        public ClaseDos(string a, string b) :base(b) //constructor
        {
            this._atributoClaseDos = a;
        }

        //public string TipoClaseDos //propiedad solo lectura
        //{
        //    get {return "Clase Dos Hereda de --> " + base.TipoClaseUno; }
        //}

        //public string MostrarClaseDos() //metodo
        //{
        //    return this._atributoClaseDos + base.MostrarClaseUno();
        //}

        public override string Tipo //propiedad solo lectura
        {
            get { return "Clase Dos Hereda de --> " + base.Tipo; }
        }

        public override string Mostrar() //metodo
        {
            return this._atributoClaseDos + base.Mostrar();
        }

        public override string ToString() //sobreescribiendo el funcionamiento del metodo ToString que es virtual
                                          //y se desprende de la clase nativa Object para que retorne el Mostrar() de esta clase
        {
            return this.Mostrar();
        }
    }
}
