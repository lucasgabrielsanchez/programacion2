using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita centralita = new Centralita("Telefonica");

            Local local1 = new Local("1234", "4321", 0.30f, 2.65f);
            Provincial provincial1 = new Provincial("4444", Franja.Franja_1, 0.21f, "5555");
            Local local2 = new Local("9999", "3333", 0.45f, 1.99f);

            //Utilizo los atributos desglozados del objeto provincial1 para pasarlos como parámetro a provincial2.
            Provincial provincial2 = new Provincial(provincial1.NroOrigen, Franja.Franja_3, provincial1.Duracion, provincial1.NroDestino);

            //mediante la propiedad de la clase Centralita que me trae a su List "listaDeLlamadas", agrego objetos
            //en dicha lista
            centralita.Llamadas.Add(local1);
            centralita.Llamadas.Add(provincial1);
            centralita.Llamadas.Add(local2);
            centralita.Llamadas.Add(provincial2);

            centralita.Mostrar();

            Console.ReadLine();

            centralita.Llamadas.Sort(Llamada.OrdenarPorDuracion);

            Console.Clear();

            centralita.Mostrar();

            Console.ReadLine();


        }
    }
}
