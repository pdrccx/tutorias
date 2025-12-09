using cuentas_de_usuario;

namespace Generar_Informes_Mensuales
{
    public partial class FrmMes : Form
    {
        BD mBD;
        public FrmMes()
        {
            InitializeComponent();
            mBD = new BD(); 
            CmbMes.SelectedIndex = 0;
        }

        public void LlenarGrid()
        {
            // Lógica para llenar el DataGridView con los datos obtenidos de la base de datos
            DgvSesiones.DataSource = mBD.ConsultarMes(CmbMes.Text);
        }
        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if(mBD.Conectar())
            {
                try
                {
                    LlenarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el informe: " + ex.Message);
                }
            }

            }
  

        private void DgvSesiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
