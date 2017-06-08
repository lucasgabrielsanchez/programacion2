using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //agrego esta librería de clases para poder serializar/deserializar archivos.
using System.Xml.Serialization; //se usa para serializar en XML

namespace Clase17
{
    public class Persona : Humano
    {
        public string nombre;
        public string apellido;

        public Persona()
        {       
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;

            //Método SteamWriter: se usa para definir la ruta donde se creará el archivo, ejemplo: "D:\\Personas.txt"
            //StreamWriter sw = new StreamWriter(@"C:\Users\gustavo\Desktop\Personas.txt", true); //se colocan 2 / para que el compilador no confunda la 
            ////StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Personas.txt", true);
            //barra con una secuencia de escape. Sin embargo si coloco
            //un @ delante de la ruta, el compilador toma la barra normalmente.      
            //El segundo parámetro bool, en true hace un Append del archivo
            //caso contrario se sobreescribe la información.

            ////sw.WriteLine("Nombre: {0} -- Apellido: {1}", this.nombre,this.apellido);//Escribe en el archivo
            ////sw.Close(); //Se utiliza para cerrar el archivo que se está escribiendo, sino se pierde la información
        }

        

    }
}
