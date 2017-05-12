using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12
{
    public class ClaseTres : ClaseDos
    {
        protected string _atributoClaseTres;

        public ClaseTres(string a, string b, string c) : base(b,c)
        {
            this._atributoClaseTres = a;
        }

        //public string TipoClaseTres
        //{
        //    get { return "Clase Tres hereda de --> " + base.TipoClaseDos; }
        //}

        //public string MostrarClaseTres()
        //{
        //    return this._atributoClaseTres + base.MostrarClaseDos();
        //}

        public override string Tipo //propiedad solo lectura
        {
            get { return "Clase Tres hereda de --> " + base.Tipo; }
        }

        public override string Mostrar() //metodo
        {
            return this._atributoClaseTres + base.Mostrar();
        }

        public override string ToString() //sobreescribiendo el funcionamiento del metodo ToString que es virtual
                                          //y se desprende de la clase nativa Object para que retorne el Mostrar() de esta clase
        {
            return this.Mostrar();
        }



    }
}
