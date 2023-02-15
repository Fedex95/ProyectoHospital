using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoHospital
{
    public partial class frmInicioCesion : Form
    {
        DAO.ClienteDAO conexion = new DAO.ClienteDAO();
        SqlConnection consql = new SqlConnection();
        public frmInicioCesion()
        {
            InitializeComponent();
            consql.ConnectionString = conexion.cadenaConexion;
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                MessageBox.Show("Debe ingresar su numero de cedula para continuar");
                txtCedula.Focus();
                return;
            }
            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar su contraseña para continuar");
                txtContraseña.Focus();
                return;
            }

            try
            {
                string query;
                query = "SELECT * FROM Clientes WHERE numCedula='" + txtCedula.Text + "' AND crearContraseña='" + txtContraseña.Text + "'";
                SqlCommand con = new SqlCommand(query,consql);
                SqlDataReader drlogin;
                consql.Open();
                drlogin=con.ExecuteReader();

                if(drlogin.Read())
                {
                    DAO.Usuario.numCedula = drlogin["numCedula"].ToString();
                    DAO.Usuario.nombreUsuario = drlogin["nombres"].ToString() + " " + drlogin["apellidos"].ToString();

                    drlogin.Close();
                    con.Dispose();
                    consql.Close();

                    ProyectoHospital.frmSeleccionCampos llevar= new ProyectoHospital.frmSeleccionCampos();
                    this.Hide();
                    llevar.Show();
                }
                else
                {
                    MessageBox.Show("El usuario no existe, verifique si la contraseña o el Num. Cedula es correcto", "atencion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                drlogin.Close();
                con.Dispose();
                consql.Close();

            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                if(consql.State== ConnectionState.Open)
                {
                    consql.Close();
                }
            }

        }

        private void btnIniciarCesion_Click(object sender, EventArgs e)
        {
            Form formulario = new frmRegistrar();
            formulario.Show();
        }

        private void frmInicioCesion_Load(object sender, EventArgs e)
        {
            Size = new Size(1045, 622);
        }
    }
}
