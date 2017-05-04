using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Vehiculo
{
    public class Lavadero
    {
        public List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

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

        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2) //ascendente
        {
            //return string.Compare(v1._patente, v2._patente);
            return v1.Patente.CompareTo(v2.Patente);
        }

        public int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return v1.Marca.ToString().CompareTo(v2.Marca.ToString()); //paso la marca a String porque es del tipo EMarca
        }


    }
}
