using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;


namespace Clase15Libreria
{
    public class HerenciaPersonaExterna : PersonaExterna
    {

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
