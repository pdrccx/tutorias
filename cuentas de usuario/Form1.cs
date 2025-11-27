using System.Windows.Forms;

namespace cuentas_de_usuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar frm = new frmRegistrar(this);
            frm.ShowDialog();
        }
        public void CargarUsuarios()
        {
            BD mBD = new BD();
            dgvUsuarios.DataSource = mBD.ObtenerUsuarios();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
        private void BuscarUsuarios()
        {
            BD mBD = new BD();

            string usuario = txtBuscarUsuario.Text.Trim();

            if (string.IsNullOrEmpty(usuario))
            {
                dgvUsuarios.DataSource = mBD.ObtenerUsuarios();
                return;
            }

            dgvUsuarios.DataSource = mBD.BuscarPorUsuario(usuario);
        }

        public void BuscarUsuario()
        {
            BD mBD = new BD();
            string Usuario = txtBuscarUsuario.Text.Trim();

            if (string.IsNullOrEmpty(Usuario))
            {
                dgvUsuarios.DataSource = mBD.ObtenerUsuarios();
                return;
            }

            dgvUsuarios.DataSource = mBD.BuscarPorUsuario(Usuario);

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
        }
    }
}
