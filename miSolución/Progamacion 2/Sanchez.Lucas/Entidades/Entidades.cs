using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TestSobrecarga
    {
        private int entero;
        private DateTime fecha;
        private string cadena;

        public string Mostrar()
        {
            return this.entero.ToString() + "\n" + this.fecha.ToString() + "\n" + this.cadena.ToString();
            
        }

        public void Inicializar(string a)
        {
            this.cadena = a;
        }

        public void Inicializar(DateTime b) //sobrecarga
        {
            this.fecha = b;
        }

        public void Inicializar(int c) //sobrecarga
        {
            this.entero = c;
        }

        public TestSobrecarga()
        {
            this.entero = 0;
            this.fecha = DateTime.Now;
            this.cadena = "sin valor";
        }

        public TestSobrecarga(int h, string j) //constructor sobrecargado con int y string como parametros con la fecha por default
        {
            this.entero = h;
            this.cadena = j;
            this.fecha = DateTime.Now;
        }

        public TestSobrecarga(string u) //constructor sobrecargado con string como parametro con la fecha y el entero por default
        {
            this.cadena = u;
            this.fecha = DateTime.Now;
            this.entero = 0;
        }
    }
}
