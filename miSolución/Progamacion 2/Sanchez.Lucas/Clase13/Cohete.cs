using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13
{
    public class Cohete : Transporte
    {
        //private int _cantidadPasajeros;
        //private Evelocidad _velocidadMaxima;
        private string _modelo;
        private int _cantidadVentanas;

        //public string Detalle
        //{
        //    get
        //    {
        //        StringBuilder sb = new StringBuilder();

        //        sb.AppendLine("Cohete:");
        //        sb.AppendLine("---------------");
        //        sb.AppendLine("Cantidad de pasajeros: " + this._cantidadPasajeros);
        //        sb.AppendLine("Velocidad Máxima: " + ((int)this._velocidadMaxima).ToString());
        //        sb.AppendLine("Modelo: " + this._modelo);
        //        sb.Append("Cantidad de Ventanas: " + this._cantidadVentanas);

        //        return sb.ToString();
        //    }
        
        //}

        public override string Detalle
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Cohete:");
                sb.AppendLine("---------------");
                sb.AppendLine("Cantidad de pasajeros: " + base._cantidadPasajeros);
                sb.AppendLine("Velocidad Máxima: " + ((int)base._velocidadMaxima).ToString());
                sb.AppendLine("Modelo: " + this._modelo);
                sb.Append("Cantidad de Ventanas: " + this._cantidadVentanas);

                return sb.ToString();
            }

        }

        public Cohete(int cantidadPasajeros, Evelocidad velocidadMaxima, string modelo, int cantVentanas):base(cantidadPasajeros,velocidadMaxima)
        {
            //this._cantidadPasajeros = cantidadPasajeros;
            //this._velocidadMaxima = velocidadMaxima;
            this._modelo = modelo;
            this._cantidadVentanas = cantVentanas;
        }

        //public string Frenar()
        //{
        //    return "El cohete está frenando";
        //}

        //public string Acelerar()
        //{
        //    return "El cohete acelera hasta: " + ((int)this._velocidadMaxima).ToString();
        //}

        public override string Frenar()
        {
            return "El cohete está frenando";
        }

        public override string Acelerar()
        {
            return "El cohete acelera hasta: " + base.Acelerar();
        }

    }
}
