using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;

namespace Clase15Libreria
{
    public static class PersonaSellada
    {

        //Métodos de Extensión:
        //En este caso estamos utilizando la dll "Entidades.Externa.Sellada", la propiedades de la clase son del tipo públicas PERO es una clase sellada, por lo tanto no podremos heredar de dicha
        //clase para poder tener acceso a sus atributos. La opción que nos queda es crearnos una clase pública y estatica, la que en este caso denominamos "public static class PersonaSellada", 
        //porque es requisito para crear "Métodos de extensión", que sean creados en una clase estática y en este caso pública para poder ser usada en nuestro main. Un método de extensión es un 
        //método diseñado por nosotros, que se agrega FORZADAMENTE a una clase que recibimos de otro lado, y a la cual no podemos acceder para poder crearle métodos internamente. Es requisito para
        //crear este tipo de métodos, que sean estáticos, y que como parámetro lleve "this + nombreDeLaClase a la que agregamos el método + nombre de la instancia de dicha clase".

        //En este caso le agregamos un método forzado a la instancia de una PersonaExternaSellada, para que cuando hagamos en el main una instancia, y accedamos a sus métodos, aparezca este método
        //en la lista.
        public static void ObtenerInfo(this PersonaExternaSellada p)
        {
            Console.WriteLine("Nombre: {0} -- Apellido: {1} -- Edad: {2} -- Sexo: {3}", p.Nombre,p.Apellido, p.Edad, p.Sexo);
        }

        //En este caso le agregamos un método forzado a la instancia de un string común, para que cuando hagamos en el main un string, y accedamos a sus métodos, aparezca este método
        //en la lista.
        public static int Cantidad(this string s)
        {
            return s.Length;
        }


    }
}
