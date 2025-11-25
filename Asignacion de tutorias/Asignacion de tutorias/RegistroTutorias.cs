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

namespace Asignacion_de_tutorias
{
    public partial class RegistroTutorias : Form
    {
        BD bd = new BD();

        public RegistroTutorias()
        {
            InitializeComponent();
            CargarAlumnos();
            ConfigurarDgv();
        }


        // CONFIGURAR DGV 

        private void ConfigurarDgv()
        {
            DgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvAlumnos.MultiSelect = false;
            DgvAlumnos.ReadOnly = false;
        }

        // CARGAR ALUMNOS DESDE MYSQL

        private void CargarAlumnos()
        {
            try
            {
                if (bd.Conectar())
                {
                    string sql = "SELECT idEstudiante, nombreCompleto, carrera, grupo FROM estudiantes";

                    DataTable tabla = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, bd.conexion);
                    da.Fill(tabla);

                    DgvAlumnos.DataSource = tabla;

                    // Añadir columna checkbox solo si no existe
                    if (!DgvAlumnos.Columns.Contains("asistio"))
                    {
                        DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                        chk.Name = "asistio";
                        chk.HeaderText = "Asistió";
                        chk.Width = 60;
                        DgvAlumnos.Columns.Add(chk);
                    }

                    bd.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR al cargar alumnos: " + ex.Message);
            }
        }


        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtActividad_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtActividad.Text.Trim() == "")
            {
                MessageBox.Show("Debes escribir una actividad.");
                return;
            }

            try
            {
                if (!bd.Conectar())
                {
                    MessageBox.Show("No se pudo conectar a la base de datos.");
                    return;
                }

                foreach (DataGridViewRow fila in DgvAlumnos.Rows)
                {
                    if (fila.Cells["idEstudiante"].Value == null)
                        continue;

                    bool asistio = false;

                    if (fila.Cells["asistio"].Value != null)
                        asistio = (bool)fila.Cells["asistio"].Value;

                    if (asistio)
                    {
                        Secion s = new Secion();

                        s.idEstudiante = Convert.ToInt32(fila.Cells["idEstudiante"].Value);

                        s.fecha = DateTime.Parse(DtpFecha.Text).ToString("yyyy-MM-dd");

                        s.actividades = TxtActividad.Text.Trim();

                        bd.Guardar(s);
                    }
                }

                MessageBox.Show("Todo se guardó correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR al guardar: " + ex.Message);
            }
            finally
            {
                bd.Desconectar();
            }
        }

        
    }
}
