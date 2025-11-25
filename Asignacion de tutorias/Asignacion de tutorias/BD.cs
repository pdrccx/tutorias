using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Asignacion_de_tutorias
{
    internal class BD
    {
        public MySqlConnection conexion;
        private MySqlCommand Consulta;
        private string CadenaConexion;

        public BD()
        {
            
            CadenaConexion = "server=localhost;database=tutorias;Uid=root;pwd=1234;";

            conexion = new MySqlConnection(CadenaConexion);
        }

        //  CONECTAR
        public bool Conectar()
        {
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                    conexion.Open();

                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
                return false;
            }
        }

        //  DESCONECTAR
        public void Desconectar()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }

        //  GUARDAR SESIÓN
        public bool Guardar(Secion mSecion)
        {
            string TextoComando =
                "INSERT INTO sesion (idEstudiante, fecha, actividades) " +
                "VALUES (@idEstudiante, @fecha, @actividades)";

            try
            {
                Consulta = new MySqlCommand(TextoComando, conexion);

                Consulta.Parameters.AddWithValue("@idEstudiante", mSecion.idEstudiante);
                Consulta.Parameters.AddWithValue("@fecha", mSecion.fecha);
                Consulta.Parameters.AddWithValue("@actividades", mSecion.actividades);

                Consulta.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar la sesión: " + ex.Message);
                return false;
            }
        }

        //  OBTENER LISTA DE ALUMNOS
        public List<Alumnos> ObtenerAlumnos()
        {
            List<Alumnos> lista = new List<Alumnos>();

            string query = "SELECT idEstudiante, nombreCompleto, carrera, grupo FROM estudiantes";

            try
            {
                Consulta = new MySqlCommand(query, conexion);
                MySqlDataReader reader = Consulta.ExecuteReader();

                while (reader.Read())
                {
                    Alumnos a = new Alumnos();

                    a.idEstudiante = reader.GetInt32("idEstudiante");
                    a.nombreCompleto = reader.GetString("nombreCompleto");
                    a.carrera = reader.GetString("carrera");
                    a.grupo = reader.GetString("grupo");

                    lista.Add(a);
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al obtener alumnos: " + ex.Message);
            }

            return lista;
        }

        
        //  PROBAR CONEXIÓN
        
        public bool ProbarConexion()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión exitosa");
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

    }
}
