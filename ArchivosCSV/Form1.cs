using MySqlConnector;

namespace ArchivosCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GuardarAlumno(string numero, string nombre, int edad, string carrera)
        {
            string connStr = "Server=localhost;Database=alumnos_db;Uid=pcc;Pwd=bismarck;";

            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                con.Open();

                string query = @"INSERT INTO alumnos (numero_control, nombre, edad, carrera)
                         VALUES (@numero, @nombre, @edad, @carrera)";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@edad", edad);
                cmd.Parameters.AddWithValue("@carrera", carrera);

                cmd.ExecuteNonQuery();
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "CSV (*.csv)|*.csv";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;

                    // Leer todas las líneas del archivo
                    string[] lines = File.ReadAllLines(filePath);

                    // Saltar la primera línea (encabezados)
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] datos = lines[i].Split(',');

                        string numero = datos[0];
                        string nombre = datos[1];
                        int edad = Convert.ToInt32(datos[2]);
                        string carrera = datos[3];

                        GuardarAlumno(numero, nombre, edad, carrera);
                    }

                    MessageBox.Show("Archivo cargado correctamente y datos guardados en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
