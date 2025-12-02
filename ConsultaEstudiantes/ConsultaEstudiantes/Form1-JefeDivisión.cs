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

    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=estudiantes;");

        private int idTutorSeleccionado = -1;

        public Form1()
        {
            InitializeComponent();
            CargarTutores();
        }
        private void CargarTutores()
        {
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT nombre FROM tutores", con);
                MySqlDataReader dr = cmd.ExecuteReader();

                CmbTutores.Items.Clear();

                while (dr.Read())
                {
                    CmbTutores.Items.Add(dr["nombre"].ToString()); // TU COMBO REAL
                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando tutores: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idTutorSeleccionado == -1)
            {
                MessageBox.Show("Primero guarda un tutor.");
                return;
            }
            Form2_Tutor frm = new Form2_Tutor(this, idTutorSeleccionado);
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardarTutor_Click(object sender, EventArgs e)
        {
            if (CmbTutores.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un tutor antes de guardar.");
                return;
            }

            string nombreTutor = CmbTutores.SelectedItem.ToString();

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT id_tutor FROM tutores WHERE nombre = @nom", con);
                cmd.Parameters.AddWithValue("@nom", nombreTutor);

                object result = cmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("No se encontró el tutor.");
                    con.Close();
                    return;
                }

                idTutorSeleccionado = Convert.ToInt32(result); // ← GUARDAMOS EL TUTOR

                MessageBox.Show("Tutor asignado correctamente.");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
       
