using System.Windows.Forms;

namespace RegistroCanalizacion
{
    public partial class Form1 : Form
    {
        BD bd = new BD();

        public Form1()
        {
            InitializeComponent();

            // RELLENAR COMBOBOX DE CANALIZAR
            comboCanalizar.Items.Add("Psicología");
            comboCanalizar.Items.Add("Trabajo Social");
            comboCanalizar.Items.Add("Médico");
            comboCanalizar.Items.Add("Otros");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNumControl.Text))
            {
                MessageBox.Show("Ingrese el número de control.");
                return;
            }

            if (comboCanalizar.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de canalización.");
                return;
            }

            // Datos a insertar
            DateTime fecha = DtpFecha.Value;
            string numeroControl = TxtNumControl.Text.Trim();
            string tipo = comboCanalizar.SelectedItem.ToString();

            // Guardar en BD
            bool ok = bd.InsertarCanalizacion(fecha, numeroControl, tipo);

            if (ok)
                MessageBox.Show("Registro guardado correctamente.");
            else
                MessageBox.Show("No se pudo guardar el registro.");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNumControl_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
