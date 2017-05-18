using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13
{
    public class Caballo : VehiculoTerrestre
    {
        //private int _cantidadPasajeros;
        //private Evelocidad _velocidadMaxima;
        private string _raza;

        //public string Detalle
        //{
        //    get
        //    {
        //        StringBuilder sb = new StringBuilder();

        //        sb.AppendLine("Caballo:");
        //        sb.AppendLine("---------------");
        //        sb.AppendLine("Cantidad de pasajeros: " + this._cantidadPasajeros);
        //        sb.AppendLine("Velocidad Máxima: " + ((int)this._velocidadMaxima).ToString());
        //        sb.Append("Raza: " + this._raza);

        //        return sb.ToString();
        //    }
        //}

        public override string Detalle
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Caballo:");
                sb.AppendLine("---------------");
                sb.AppendLine("Cantidad de pasajeros: " + base._cantidadPasajeros);
                sb.AppendLine("Velocidad Máxima: " + ((int)base._velocidadMaxima).ToString());
                sb.Append("Raza: " + this._raza);

                return sb.ToString();
            }
        }

        public Caballo(int cantPasajeros, Evelocidad velocidadMaxima, string raza) :base(cantPasajeros,velocidadMaxima)
        {
            //this._cantidadPasajeros = cantPasajeros;
            //this._velocidadMaxima = velocidadMaxima;
            this._raza = raza;
        }

        //public string Frenar()
        //{
        //    return "El caballo está frenando";
        //}

        //public string Acelerar()
        //{
        //    return "El caballo acelera hasta: " + ((int)this._velocidadMaxima).ToString();
        //}

        public override string Frenar()
        {
            return "El caballo está frenando";
        }

        public override string Acelerar()
        {
            return "El caballo acelera hasta: " + base.Acelerar();
        }
    }
}
