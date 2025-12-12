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

namespace Informes_MS
{
    public partial class Form2 : Form
    {
        string conexion = "Server=localhost;Database=Informes;Uid=root;Pwd=;SslMode=none;";
        int IdTutorSeleccionado;
        string NombreTutorSeleccionado;

        public Form2(int idTutor, string nombreTutor)
        {
            InitializeComponent();
            IdTutorSeleccionado = idTutor;
            NombreTutorSeleccionado = nombreTutor;

            CmbTutor.Items.Add(NombreTutorSeleccionado);
            CmbTutor.SelectedIndex = 0;
            CmbTutor.DropDownStyle = ComboBoxStyle.DropDownList;

            CargarInformes(); // <-- Llamada directa si Load no funciona
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            CargarInformes();
        }
        private void CargarInformes()
        {
            DgvMensuales.AutoGenerateColumns = true;
            DgvSemestrales.AutoGenerateColumns = true;

            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();
                string q1 = "SELECT id_informe, id_tutor, tipo, fecha, descripcion FROM informe WHERE id_tutor=@id AND tipo='Mensual'";
                MySqlCommand cmd1 = new MySqlCommand(q1, con);
                cmd1.Parameters.AddWithValue("@id", IdTutorSeleccionado);

                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                DgvMensuales.DataSource = dt1;
            }

            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();
                string q2 = "SELECT id_informe, id_tutor, tipo, fecha, descripcion FROM informe WHERE id_tutor=@id AND tipo='Semestral'";
                MySqlCommand cmd2 = new MySqlCommand(q2, con);
                cmd2.Parameters.AddWithValue("@id", IdTutorSeleccionado);

                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                DgvSemestrales.DataSource = dt2;
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
