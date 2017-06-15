using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //Agregar para manipular SQL
using System.Data.SqlClient; //Agregar para manipular SQL

namespace Clase19BaseDeDatosLibrería
{
    public class ConexionABaseDeDatos
    {
        private SqlConnection _conexion;
        private SqlCommand _comando;
        private List<Persona> _listaPersonas;

        public ConexionABaseDeDatos()
        {
            this._conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion); //accedo a la propiedad que agregué. para instanciar al SqlConnection.
            
            this._comando = new SqlCommand(); //instancio el sqlcommand
            this._comando.CommandType = CommandType.Text; // le paso al CommandTye del sqlCommand instanciado, la propiedad del enumerado.
            this._comando.Connection = this._conexion; // le paso al Connection del sqlCommand instanciado, el objeto de tipo sqlConnection instanciado.

            this._listaPersonas = new List<Persona>();
        }

        
        public List<Persona> TraerTodos()
        {
            try
            {
                SqlDataReader auxDataReader;

                this._comando.CommandText = "SELECT * FROM Personas ORDER BY apellido"; //SELECT [Campos ej: id, nombre, apellido, edad] FROM Tabla [ORDER BY Campo]
                //this._comando.CommandText = "SELECT id,nombre,apellido,edad FROM Personas ORDER BY apellido,nombre";   
                this._conexion.Open();
                auxDataReader = this._comando.ExecuteReader(); //retorna un objeto del tipo sqlDataReader

                while (auxDataReader.Read())
                {
                    //this._listaPersonas.Add(new Persona((int)auxDataReader[0], (string)auxDataReader[1], (string)auxDataReader[2], (int)auxDataReader[3]));
                    this._listaPersonas.Add(new Persona(int.Parse(auxDataReader[0].ToString()),auxDataReader[1].ToString(), auxDataReader[2].ToString(), int.Parse(auxDataReader[3].ToString())));               
                }

                auxDataReader.Close();
                this._conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return this._listaPersonas;
            
        }

        public bool Agregar(Persona p)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("INSERT INTO Personas (apellido, nombre, edad) VALUES ('{0}','{1}',{2})", p.apellido, p.nombre, p.edad);

                this._comando.CommandText = sb.ToString();

                this._conexion.Open();

                this._comando.ExecuteNonQuery();

                this._conexion.Close();

                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Modificar(Persona p)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("UPDATE Personas SET apellido = '{0}', nombre ='{1}', edad = {2} WHERE ID = {3}", p.apellido, p.nombre, p.edad, p.id);

                this._comando.CommandText = sb.ToString();

                this._conexion.Open();

                this._comando.ExecuteNonQuery();

                this._conexion.Close();

                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Borrar(int id)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("DELETE Personas WHERE ID = {0}", id);

                this._comando.CommandText = sb.ToString();

                this._conexion.Open();

                this._comando.ExecuteNonQuery(); //retorna un entero que indica la cantidad de registros que fueron afectados
                                                 //por el comando que le pasamos a la base de datos.
                this._conexion.Close();

                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Persona item in this._listaPersonas)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

    }
}
