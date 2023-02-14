using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHospital.FrmCitasSeparadas
{
    public partial class frmCitasMedicas : Form
    {
        public frmCitasMedicas()
        {
            InitializeComponent();
        }

        private void frmCitasMedicas_Load(object sender, EventArgs e)
        {
            // Crea una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(
            "Data Source=DESKTOP-F; Initial Catalog=Proyecto;Integrated Security=true"))
            {
                connection.Open();
                // Ejecuta una consulta SQL
                string query = "SELECT * FROM sacarCitasGen";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                // Recorre los resultados de la consulta
                while (reader.Read())
                {
                    // Obtiene los valores de la columna
                    string numCedula2 = reader["numCedula2"].ToString();
                    string nombres2 = reader["nombres2"].ToString();
                    string apellidos2 = reader["apellidos2"].ToString();
                    string medico = reader["medico"].ToString();
                    string fechaAtencion = reader["fechaAtencion"].ToString();

                    // Asigna los valores a los controles
                    textBox1.Text = numCedula2;
                    textBox2.Text = nombres2;
                    textBox3.Text = apellidos2;
                    textBox4.Text = medico;
                    textBox5.Text = fechaAtencion;
                }

                // Cierra la conexión a la base de datos
                connection.Close();
            }
        }
    }
}
