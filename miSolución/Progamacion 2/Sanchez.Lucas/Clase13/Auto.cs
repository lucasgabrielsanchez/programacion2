using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13
{
    public class Auto : VehiculoTerrestre
    {
        //private int _cantidadPasajeros;
        //private Evelocidad _velocidadMaxima;
        private int _cantRuedas;



        public override string Detalle
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Auto:");
                sb.AppendLine("---------------");
                sb.AppendLine("Cantidad de pasajeros: " + base._cantidadPasajeros);
                sb.AppendLine("Velocidad Máxima: " + ((int)base._velocidadMaxima).ToString());
                sb.Append("Cantidad de Ruedas: " + this._cantRuedas);

                return sb.ToString();
            }
        }

        public Auto(int cantPasajeros, Evelocidad velocidadMaxima, int cantRuedas) :base(cantPasajeros,velocidadMaxima)
        {
            //this._cantidadPasajeros = cantPasajeros;
            //this._velocidadMaxima = velocidadMaxima;
            this._cantRuedas = cantRuedas;
        }

        //public string Frenar()
        //{
        //    return "El auto está frenando";
        //}

        //public string Acelerar()
        //{
        //    return "El auto acelera hasta: " + ((int)this._velocidadMaxima).ToString();
        //}

        public override string Frenar()
        {
            return "El auto está frenando";
        }

        public override string Acelerar()
        {
            return "El auto acelera hasta: " + base.Acelerar();
        }
    }
}
