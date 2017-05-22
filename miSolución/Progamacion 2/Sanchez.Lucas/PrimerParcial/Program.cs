using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Libro lib = new Libro(55f, "nose", "Juan", "Carlos");

            Libro lib1 = new Libro(60.45f, "nose", "Juan", "Carlos");

            Manual man = new Manual("Reparación de PC", 400.65f, "Guido", "Lopez", ETipo.Tecnico);
            Manual man1 = new Manual("Reparación de PC", 400.65f, "Guido", "Lopez", ETipo.Tecnico);

            Manual man2 = new Manual("Instrucciones", 234.65f, "Arnold", "Hey", ETipo.Finanzas);

            Novela nov = new Novela("Amores Nuevos", 349.90f, "Ricardo", "Gutierrez", EGenero.Romantica);
            Novela nov1 = new Novela("Espectros", 145.75f, "Carold", "Gomes", EGenero.CienciaFiccion);

            //Console.WriteLine(lib.CantidadDePaginas);
            //Console.WriteLine(lib1.CantidadDePaginas);

            //Console.WriteLine(man.Mostrar());

            //Console.WriteLine(Libro.Mostrar(lib));

            Biblioteca miBiblioteca = 4;

            miBiblioteca += lib;//<-- se agrega 1
            miBiblioteca += lib1;//no se agrega porque es repetido.
            miBiblioteca += man;//<-- se agrega 2
            miBiblioteca += man1;//no se agrega porque es repetido.
            miBiblioteca += man2;//<-- se agrega 3
            miBiblioteca += nov;//<-- se agrega 4
            miBiblioteca += nov1;//no queda lugar

            Console.WriteLine(Biblioteca.Mostrar(miBiblioteca));

            Console.ReadLine();
        }
    }
}
