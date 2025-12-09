using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_de_usuario
{
    internal class BD
    {
        private MySqlConnection Conexion;
        private MySqlCommand Consulta;
        private string CadenaConexion;

        // -------------------------------------------------------
        // CONECTAR
        // -------------------------------------------------------
        public bool Conectar()
        {
            CadenaConexion = "Server=localhost;" +
                             "Database=reportes;" +
                             "Uid=pcc;" +
                             "Pwd=bismarck;";

            try
            {
                Conexion = new MySqlConnection(CadenaConexion);
                Conexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
                return false;
            }
        }

        // -------------------------------------------------------
        // DESCONECTAR
        // -------------------------------------------------------
        public void Desconectar()
        {
            if (Conexion != null && Conexion.State == ConnectionState.Open)
                Conexion.Close();
        }

        // -------------------------------------------------------
        // GUARDAR (INSERT)
        // -------------------------------------------------------
        public DataTable ConsultarMes(string filtro)
        {
            DataTable dt = new DataTable();

            if (!Conectar()) return dt;

            string comando = "SELECT * FROM reportesmes WHERE mes = @mes";

            try
            {
                MySqlCommand cmd = new MySqlCommand(comando, Conexion);
                cmd.Parameters.AddWithValue("@mes", filtro);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar informe: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

            return dt;
        }

    }
}