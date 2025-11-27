using MySql.Data.MySqlClient;
using System;
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
                             "Database=usuarios;" +
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
        public bool Guardar(Usuario u)
        {
            if (!Conectar()) return false;

            string comando = "INSERT INTO usuarios (usuario, contrasena, nombre, apellidos, correo, tipo) " +
                             "VALUES (@usuario, @contrasena, @nombre, @apellidos, @correo, @tipo)";

            try
            {
                Consulta = new MySqlCommand(comando, Conexion);

                Consulta.Parameters.AddWithValue("@usuario", u.UsuarioID);
                Consulta.Parameters.AddWithValue("@contrasena", u.Contrasena);
                Consulta.Parameters.AddWithValue("@nombre", u.Nombre);
                Consulta.Parameters.AddWithValue("@apellidos", u.Apellidos);
                Consulta.Parameters.AddWithValue("@correo", u.Correo);
                Consulta.Parameters.AddWithValue("@tipo", u.Tipo);

                Consulta.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
                return false;
            }
            finally
            {
                Desconectar();
            }
        }

        // -------------------------------------------------------
        // ACTUALIZAR (UPDATE)
        // -------------------------------------------------------
        public bool Actualizar(Usuario u)
        {
            if (!Conectar()) return false;

            string comando = "UPDATE usuarios SET " +
                             "contrasena = @contrasena, " +
                             "nombre = @nombre, " +
                             "apellido = @apellido, " +
                             "correo = @correo, " +
                             "tipo = @tipo " +
                             "WHERE usuario = @usuario";

            try
            {
                Consulta = new MySqlCommand(comando, Conexion);

                Consulta.Parameters.AddWithValue("@contrasena", u.Contrasena);
                Consulta.Parameters.AddWithValue("@nombre", u.Nombre);
                Consulta.Parameters.AddWithValue("@apellido", u.Apellidos);
                Consulta.Parameters.AddWithValue("@correo", u.Correo);
                Consulta.Parameters.AddWithValue("@tipo", u.Tipo);
                Consulta.Parameters.AddWithValue("@usuario", u.UsuarioID);

                Consulta.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
                return false;
            }
            finally
            {
                Desconectar();
            }
        }

        // -------------------------------------------------------
        // ELIMINAR
        // -------------------------------------------------------
        public bool Eliminar(string usuarioID)
        {
            if (!Conectar()) return false;

            string comando = "DELETE FROM usuarios WHERE usuario = @usuario";

            try
            {
                Consulta = new MySqlCommand(comando, Conexion);
                Consulta.Parameters.AddWithValue("@usuario", usuarioID);
                Consulta.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
                return false;
            }
            finally
            {
                Desconectar();
            }
        }

        // -------------------------------------------------------
        // MOSTRAR TODOS (SELECT *)
        // -------------------------------------------------------
        public DataTable ObtenerUsuarios()
        {
            DataTable dt = new DataTable();

            if (!Conectar()) return dt;

            string comando = "SELECT * FROM usuarios";

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(comando, Conexion);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

            return dt;
        }

        // -------------------------------------------------------
        // BUSCAR POR USUARIO
        // -------------------------------------------------------
        public DataTable BuscarPorUsuario(string usuario)
        {
            DataTable dt = new DataTable();

            if (!Conectar()) return dt;

            string comando = "SELECT * FROM usuarios WHERE usuario LIKE @usuario";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(comando, Conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", "%" + usuario + "%");

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

            return dt;
        }
    }
}