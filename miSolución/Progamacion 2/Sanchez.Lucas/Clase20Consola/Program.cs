using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase20Librería;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Clase20Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartuchera<Utiles> cu = new Cartuchera<Utiles>(3, "Pepino");

            Lapicera l1 = new Lapicera(25, "faber", ConsoleColor.Blue, "Fino");
            Lapicera l2 = new Lapicera(16, "bic", ConsoleColor.DarkBlue, "Grueso");

            Goma g1 = new Goma(13, "Fabersito", true);
            Goma g2 = new Goma(10, "Maped", false);

            try
            {
                cu += l1;
                cu += l2;
                cu += g1;
                cu += g2;
            }
                
            catch (CartucheraLlenaException c)
            {
                Console.WriteLine(c.Message);
                StreamWriter sw = new StreamWriter("Excepcion.log"); //Por default lo guarda en la carpeta del programa.
                sw.WriteLine(c.Message);
                sw.WriteLine(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Millisecond);
                sw.Close();
            }

            g1.Precio = 3;
            Console.WriteLine(cu);

            cu.SerializarXML("xD.xml");

            Cartuchera<Utiles> cAux; //= new Cartuchera<Utiles>(2,"asd");

            if (cu.DeserializarXML("xD.xml", out cAux))
                Console.WriteLine("Se deserializó bien");

            Console.WriteLine("Cartuchera Deserializada");
            Console.WriteLine(cAux);

            cu.serializarXML("Pepito.xml");

            Console.ReadLine();

            //serializar una goma: objGoma.SerializarXML("");


        }

        //static class BaseDeDatos
        //{
        //    //hacer base de datos.
        //    //intentar traer todos
        //    //traer por tipo(por tipo de parámetro)
        //    //si la goma es sololapiz o no tiene cosas o no
        //    private SqlConnection _conexion;
        //    private SqlCommand _comando;

        //    public void TraerTodos()
        //    {
        //        this._conexion = new SqlConnection(Properties.Settings.Default.Setting); //accedo a la propiedad que agregué. para instanciar al SqlConnection.

        //        this._comando = new SqlCommand("SELECT * FROM elementos", this._conexion); //instancio el sqlcommand

        //        SqlDataReader sqr = this._comando.ExecuteReader();

        //        while (sqr.Read())
        //        {
        //            Console.WriteLine("{");
        //        }
        //    }
        //}
    }
}
