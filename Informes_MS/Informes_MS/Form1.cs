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

    public partial class Form1 : Form
    {
        string conexion = "Server=localhost;Database=Informes;Uid=root;Pwd=;SslMode=none;";
        public Form1()
        {
            InitializeComponent();
            CargarTutores();
        }
        private void CargarTutores()
        {
            string query = "SELECT id_tutor, nombre FROM tutor";

            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                DgvTutores.DataSource = dt;
            }
        }

        private void BtnVerInformes_Click(object sender, EventArgs e)
        {
            if (DgvTutores.CurrentRow != null)
            {
                int idTutor = Convert.ToInt32(DgvTutores.CurrentRow.Cells[0].Value);
                string nombreCompleto = DgvTutores.CurrentRow.Cells[1].Value.ToString();

                Form2 frm = new Form2(idTutor, nombreCompleto);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un tutor primero.");
            }
        }
    }
}