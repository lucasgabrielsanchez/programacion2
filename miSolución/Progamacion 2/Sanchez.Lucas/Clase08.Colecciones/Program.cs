using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Clase08.Colecciones
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Stack pila = new Stack();
            //for (int i = 0; i < 5; i++)
            //{
            //    pila.Push(i);
            //}

            //int itemsPila = pila.Count;

            //for (int i = 0; i < itemsPila; i++)
            //{
            //    Console.WriteLine(pila.Pop());
            //}

            

            //Queue cola = new Queue();

            //for (int i = 0; i < 5; i++)
            //{
            //    cola.Enqueue(i);
            //}

            //itemsPila = cola.Count;

            //for (int i = 0; i < itemsPila; i++)
            //{
            //    Console.WriteLine(cola.Dequeue());
            //}

            
            //Console.ReadLine();

            Tempera Uno = new Tempera(ConsoleColor.Blue,"Faber",5);
            Tempera Dos = new Tempera(ConsoleColor.Cyan, "Bic", 3);
            Tempera Tres = new Tempera(ConsoleColor.DarkGreen, "Jota", 4);

            pila.Push(Uno);
            pila.Push(Dos);
            pila.Push(Tres);

            int itemsPila = pila.Count;

            Tempera tpAux = new Tempera(ConsoleColor.DarkGreen, "Jota", 4);

            for (int i = 0; i < itemsPila ; i++)
            {
                //pila.pop retorna object
                //Tempera.Mostrar((string)pila.Pop());
            }

            //Console.Read();


            ArrayList Lista = new ArrayList();

            for (int i = 0; i < 5; i++)//agrego cosas al ArrayList
            {
                Lista.Add(i);
            }

            Console.WriteLine(Lista[4]); //mostrando elemento especifico

            Console.WriteLine();

            foreach (int i in Lista) //mostrando todos los elementos
            {
                Console.WriteLine(i);
            }

            //Lista.Sort(

            Lista.Reverse();
            Console.WriteLine();

            foreach (int i in Lista) //mostrando todos los elementos
            {
                Console.WriteLine(i);
            }

            Lista.Sort();
            Console.WriteLine();

             foreach (int i in Lista) //mostrando todos los elementos
            {
                Console.WriteLine(i);
            }
             ArrayList ListaTempera = new ArrayList();

            ListaTempera.Add(Uno);
            ListaTempera.Add(Dos);
            ListaTempera.Add(Tres);

            //foreach (Tempera xD in ListaTempera) //mostrando todos los elementos
            //{
            //    Console.WriteLine(i);
            //}

            Hashtable HT = new Hashtable();

            HT.Add("valor1", 1);
            HT.Add("valor2", 2);
            HT.Add("valor3", 3);

            Console.WriteLine();

            //foreach (int i in HT.Values) //forma incorrecta de recorrerlo
            //{
            //    Console.WriteLine(i);
            //}

            foreach (string i in HT.Keys)
            {
                //Console.WriteLine(i);
                Console.WriteLine(HT[i]);
            }

            Console.Read();
        }
    }
}
