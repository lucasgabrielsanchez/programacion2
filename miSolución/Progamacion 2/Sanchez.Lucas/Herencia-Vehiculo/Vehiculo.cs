using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Vehiculo
{
    public class Vehiculo
    {
        protected string _patente;
        protected Byte _cantRuedas;
        protected EMarcas _marca;


        public string Patente
        {
            get { return this._patente; }
        }

        public EMarcas Marca
        {
            get { return this._marca; }
        }

        public Vehiculo(string patente, Byte cantRuedas, EMarcas marca)
        {
            this._patente = patente;
            this._cantRuedas = cantRuedas;
            this._marca = marca;
        }

        protected string Mostrar()
        {
            return "Patente: " + this._patente + "\n" + "Cantidad de Ruedas: " +  this._cantRuedas.ToString() + "\n" + "Marca: " + this._marca.ToString() + "\n";
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool aux = false;

            if ((v1._patente == v2.Patente) && (v1._marca == v2._marca))
            {
            aux = true;
            }

            return aux;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(object obj) //sobreescribo el metodo virtual derivado de object para
        {                                       //poder utilizar el metodo Equals para comparar objetos.
            //if (obj is Vehiculo && this == ((Vehiculo)obj))
            //{   
            //    return true;
            //}
            
            return (obj is Vehiculo && this == (Vehiculo)obj); 
        }

     

        
    }
}
