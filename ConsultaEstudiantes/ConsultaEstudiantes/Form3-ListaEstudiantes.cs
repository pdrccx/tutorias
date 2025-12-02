using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaEstudiantes
{
    public partial class Form3_ListaEstudiantes : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=estudiantes;");

        public Form3_ListaEstudiantes()
        {
            InitializeComponent();
        }

        private void CargarEstudiantes()
        {
            try
            {
                con.Open();

                string query = @"
            SELECT 
                e.id_estudiante AS 'ID',
                e.nombre AS 'Estudiante',
                t.nombre AS 'Tutor'
            FROM estudiantes e
            WERE e.id_tutor = t.id_tutor;
        ";

                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable tabla = new DataTable();
                da.Fill(tabla);

                DgvListaEstudiantes.DataSource = tabla;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando estudiantes: " + ex.Message);
            }
        }

        private void Form3_ListaEstudiantes_Load(object sender, EventArgs e)
        {
            DgvListaEstudiantes.Columns.Clear();

            DgvListaEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
        public void CargarEstudiantesPorTutor(int idTutor)
        {
            try
            {
                con.Open();

                string query = @"
            SELECT 
                e.id_estudiante AS 'ID', e.nombre AS 'Estudiante', e.id_tutor AS 'ID_Tutor', t.nombre AS 'Tutor'
            FROM estudiantes e
            INNER JOIN tutores t ON 
            e.id_tutor = t.id_tutor
            WHERE e.id_tutor = @idTutor;
        ";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idTutor", idTutor);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DgvListaEstudiantes.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando estudiantes: " + ex.Message);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
