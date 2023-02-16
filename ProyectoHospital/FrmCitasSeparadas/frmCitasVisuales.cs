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
    public partial class frmCitasVisuales : Form
    {
        public frmCitasVisuales()
        {
            InitializeComponent();
        }

        private void frmCitasVisuales_Load(object sender, EventArgs e)
        {// Crea una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(
            "Data Source=DESKTOP-F; Initial Catalog=Proyecto;Integrated Security=true"))
            {
                connection.Open();
                // Ejecuta una consulta SQL

                string query = "SELECT * FROM sacarCitaVs";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Agregar el nombre del producto al ListBox
                    listBox1.Items.Add(reader["numCedula2"].ToString());
                    listBox2.Items.Add(reader["nombres2"].ToString());
                    listBox3.Items.Add(reader["apellidos2"].ToString());
                    listBox4.Items.Add(reader["medico"].ToString());
                    listBox5.Items.Add(reader["fechaAtencion"].ToString());

                }


                // Cierra la conexión a la base de datos
                reader.Close();
                connection.Close();
            }
        }
    }
}
