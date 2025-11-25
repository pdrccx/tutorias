using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignacion_de_tutorias
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrarTuto_Click(object sender, EventArgs e)
        {
            RegistroTutorias form = new RegistroTutorias();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
