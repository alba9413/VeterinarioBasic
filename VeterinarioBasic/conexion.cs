using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VeterinarioBasic
{
    class conexion
    {
        public MySqlConnection Conexion;

        public conexion()
        {
            Conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd =; Port = 3306 ");

        }
        public bool loginVeterinario(String DNI, String contraseña)
        {
            try
            {
                Conexion.Open();
                MySqlCommand consulta =
               
               new MySqlCommand("SELECT * FROM usuario where DNI = @DNI AND contraseña = @contraseña" , Conexion);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@contraseña", contraseña);

                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    return true;

                }

                Conexion.Close();
                return false;
            }
            catch (MySqlException)
            {
                Conexion.Close();
                return false;
            }
            }
        public DataTable obtenerDatos(String str)
        {
            try
            {
                Conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand(str, Conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable tabla = new DataTable();
                tabla.Load(resultado);
                Conexion.Close();
                return tabla;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }


    }
}

            
    
    

