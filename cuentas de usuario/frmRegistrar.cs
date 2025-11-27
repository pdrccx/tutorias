using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuentas_de_usuario
{
    public partial class frmRegistrar : Form
    {
        private Form1 _principal;

        public frmRegistrar(Form1 principal)
        {
            InitializeComponent();
            _principal = principal;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario mUsuario = new Usuario();
            mUsuario.UsuarioID = txtUsuarios.Text;
            mUsuario.Contrasena = txtContraseña.Text;
            mUsuario.Nombre = txtNombre.Text;
            mUsuario.Apellidos = txtApellidos.Text;
            mUsuario.Correo = txtCorreo.Text;
            mUsuario.Tipo = cmbTipo.Text;   

            // Crear instancia de BD y guardar
            BD mBD = new BD();

            if (mBD.Guardar(mUsuario))
            {
                MessageBox.Show("Usuario guardado correctamente.");

                _principal.CargarUsuarios(); 

                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar el usuario.");
            }
        
        }
    }
}
