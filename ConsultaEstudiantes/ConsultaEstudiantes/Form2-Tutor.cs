using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConsultaEstudiantes
{
    public partial class Form2_Tutor : Form
    {
        private Form1 formAnterior;

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=estudiantes;");

        private int idTutor;
        public Form2_Tutor(Form1 formAnteriorRecibido, int idTutorRecibido)
        {
            InitializeComponent();
            idTutor = idTutorRecibido;
            formAnterior = formAnteriorRecibido;
            //MessageBox.Show("Form2 recibe tutor ID = " + idTutor);
            CargarTutores();
        }
        private void CargarTutores()
        {
            try
            {
                con.Open();

                // Cargar todos los tutores
                MySqlCommand cmd = new MySqlCommand("SELECT nombre FROM tutores", con);
                MySqlDataReader dr = cmd.ExecuteReader();

                CmbTutor.Items.Clear();

                while (dr.Read())
                {
                    CmbTutor.Items.Add(dr["nombre"].ToString());
                }

                dr.Close();

                // Cargar tutor asignado del estudiante seleccionado
                MySqlCommand cmd2 = new MySqlCommand(
                    "SELECT nombre FROM tutores WHERE id_tutor = @id", con);

                cmd2.Parameters.AddWithValue("@id", idTutor);

                object result = cmd2.ExecuteScalar();
                if (result != null)
                {
                    string tutorNombre = result.ToString();
                    CmbTutor.SelectedItem = tutorNombre;  
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void BtnListadeEstudiantes_Click(object sender, EventArgs e)
        {
            if (CmbTutor.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un tutor primero.");
                return;
            }

            string tutorSeleccionado = CmbTutor.SelectedItem.ToString();
            int idTutor = ObtenerIdTutor(tutorSeleccionado);

            Form3_ListaEstudiantes frm = new Form3_ListaEstudiantes();
            frm.CargarEstudiantesPorTutor(idTutor);
            frm.Show();
        }
        private int ObtenerIdTutor(string nombreTutor)
        {
            int id = -1;
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT id_tutor FROM tutores WHERE nombre = @nom", con);
                cmd.Parameters.AddWithValue("@nom", nombreTutor);

                object result = cmd.ExecuteScalar();
                if (result != null)
                    id = Convert.ToInt32(result);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error obteniendo id del tutor: " + ex.Message);
            }

            return id;
        }
        

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            this.Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

        

