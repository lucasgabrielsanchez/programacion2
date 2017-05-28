using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;


namespace Clase15Libreria
{
    //En este caso estamos utilizando la dll "Entidades.Externa", la cual posee métodos y propiedades del tipo protected y para poder ser utilizadas y/o modificadas
    //a nuestro gusto, la manera más apropiada es crear una clase que herede de dicha dll para poder acceder a estos elementos protected. Como se vé abajo, creamos
    //nuestro constructor reutilizando el código del padre y creamos propiedades que nos retornen el valor de los atributos. Por convención, es correcto acceder
    //a ellos mediante "base." pero como heredamos de la clase, también es posible acceder a ellos mediante "this.". Por último creamos un método que muestra por
    //consola, dichos atributos, en este caso usamos "this." y accedemos a nuestras propiedades.
    public class HerenciaPersonaExterna : PersonaExterna
    {
        //Debemos marcar la ruta completa del enumerado porque tiene el mismo nombre en las 2 dll y en nuestra propia clase, sino, el compilador no sabe a cual ir.
        public HerenciaPersonaExterna(string nombre, string apellido, int edad, Entidades.Externa.ESexo sexo) : base(nombre,apellido,edad,sexo)
        {

        }


        public string Nombre
        {
            get
            {
                return base._nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return base._apellido;
            }
        }


        public int Edad
        {
            get
            {
                return base._edad;
            }
        }

        //Debemos marcar la ruta completa del enumerado porque tiene el mismo nombre en las 2 dll y en nuestra propia clase, sino, el compilador no sabe a cual ir.
        public Entidades.Externa.ESexo Sexo
        {
            get
            {
                return base._sexo;
            }
        }

        public void ObtenerInfo()
        {
            Console.WriteLine("Nombre: {0} -- Apellido: {1} -- Edad: {2} -- Sexo: {3}", this.Nombre, this.Apellido, this.Edad, this.Sexo);
        }
    }
}
