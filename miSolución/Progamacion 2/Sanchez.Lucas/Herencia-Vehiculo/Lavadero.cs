using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Vehiculo
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        #region constructores
        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }
        #endregion

        #region propiedades
        public string LavaderoString
        {   
            get {
                string aux = null;

                aux += "Precio auto: " + this._precioAuto.ToString() + "\n" + "Precio camion: " + this._precioCamion.ToString() +
                "\n" + "Precio moto: " + this._precioMoto.ToString() + "\n\n" ;

                foreach (Vehiculo ve in this._vehiculos)
                {
                    if (ve is Moto)
                    {
                        
                        aux += ((Moto)ve).MostrarMoto() + "\n";
                    }

                    if (ve is Auto)
                    {
                        aux += ((Auto)ve).MostrarAuto() + "\n";
                    }

                    if (ve is Camion)
                    {
                        aux += ((Camion)ve).MostrarCamion() + "\n";
                    }
                }

                return aux;
                }
            
        }

        public List<Vehiculo> Vehiculos
        {
            get { return this._vehiculos;}
        }
        #endregion

        #region OrdenarVehiculos


        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2) //ascendente
        {
            //return string.Compare(v1._patente, v2._patente);
            return v1.Patente.CompareTo(v2.Patente);
        }

        public int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return v1.Marca.ToString().CompareTo(v2.Marca.ToString()); //paso la marca a String porque es del tipo EMarca
        }
        #endregion

        #region MostrarTotalFacturado
        public double MostrarTotalFacturado()
        {
            double total = 0;

            foreach (Vehiculo item in this._vehiculos)
            {
                if (item is Camion)
                {
                    total += this._precioCamion;
                }

                if (item is Auto)
                {
                    total += this._precioAuto;
                }

                if (item is Moto)
                {
                    total += this._precioMoto;
                }   
            }
            return total;
        }

        public double MostrarTotalFacturado(EVehiculos vehiculo)
        {
            double total = 0;

            foreach (Vehiculo item in this._vehiculos)
            {
                switch (vehiculo)
                {
                    case EVehiculos.Camion:
                        if (item is Camion)
                        total += this._precioCamion;
                        break;

                    case EVehiculos.Auto:
                        if (item is Auto)
                        total += this._precioAuto;
                        break;

                    case EVehiculos.Moto:
                        if (item is Moto)
                        total += this._precioMoto;
                        break;

                    default: total = 0;
                        break;
                }
            }
            //switch (vehiculo)
            //{
            //    case EVehiculos.Camion:
            //        {
            //            foreach (Camion item in this._vehiculos)
            //            {
            //                total += this._precioCamion;
            //            }
            //            break;
            //        }

            //    case EVehiculos.Auto:
            //        {
            //            foreach (Auto item in this._vehiculos)
            //            {
            //                total += this._precioAuto;
            //            }
            //            break;
            //        }

            //    case EVehiculos.Moto:
            //        {
            //            foreach (Moto item in this._vehiculos)
            //            {
            //                total += this._precioMoto;
            //            }
            //            break;
            //        }

            //}

            return total;
        }
        #endregion

        #region sobrecarga de operadores

        public static bool operator ==(Lavadero lav, Vehiculo ve)
        {
            bool retorno = false;

            foreach (Vehiculo item in lav._vehiculos)
            {
                if (item == ve)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Lavadero lav, Vehiculo ve)
        {
            return !(lav == ve);
        }

        public static Lavadero operator +(Lavadero lav, Vehiculo ve)
        {
            if (lav != ve)
            {
                lav._vehiculos.Add(ve);
            }

            return lav;
        }

        public static Lavadero operator -(Lavadero lav, Vehiculo ve)
        {
            if (lav == ve)
            {
                lav._vehiculos.Remove(ve);
            }

            return lav;
        }


        #endregion

        

    }
}
