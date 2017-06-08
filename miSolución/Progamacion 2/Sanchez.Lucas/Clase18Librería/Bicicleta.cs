using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18Librería
{
    public class Bicicleta
    {
        public string marca;
        public float rodado;
        public float precio;

        public Bicicleta(string marca, float rodado, float precio)
        {
            this.marca = marca;
            this.rodado = rodado;
            this.precio = precio;
        }

        public override string ToString()
        {
            return "Marca: " + this.marca + " - Rodado: " + this.rodado + " - Precio: " + this.precio + "\n";
        }
    }
}
