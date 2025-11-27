using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace RegistroCanalizacion
{
    internal class BD
    {
        private MySqlConnection conexion;

        public BD()
        {
            string cadena = "Server=localhost;Database=tutorias;Uid=root;Pwd=1234;";
            conexion = new MySqlConnection(cadena);
        }

        public void Abrir()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
        }

        public void Cerrar()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }

        public bool InsertarCanalizacion(DateTime fecha, string numeroControl, string tipo)
        {
            bool resultado = false;

            try
            {
                Abrir();

                string query = @"INSERT INTO canalizacion (fecha, numeroControl, tipoCanalizacion)
                                 VALUES (@fecha, @nc, @tipo)";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@nc", numeroControl);
                cmd.Parameters.AddWithValue("@tipo", tipo);

                resultado = cmd.ExecuteNonQuery() > 0;

                Cerrar();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }

            return resultado;
        }
    }
}