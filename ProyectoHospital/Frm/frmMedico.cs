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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoHospital.Frm
{
    public partial class frmMedico : Form
    {
        DAO.CitasDAO conexion = new DAO.CitasDAO();
        SqlConnection consql = new SqlConnection();
        public frmMedico()
        {
            InitializeComponent();
            consql.ConnectionString = conexion.cadenaConexion2;

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoHospital.DAO.Citas eci = new ProyectoHospital.DAO.Citas();
                eci.medico = this.comboBox1.SelectedItem.ToString();
                eci.fechaAtencion = dtfechaAtencion.Value;
                eci.horaCita = this.comboBox2.SelectedItem.ToString();

                ProyectoHospital.DAO.CitasDAO objCita = new ProyectoHospital.DAO.CitasDAO();
            
                int x = objCita.aceptar(eci);
                if (x > 0)
                {
                    MessageBox.Show("Cita agendada con éxito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error, no se pudo agendar la cita");
                }
            }catch(SqlException)
            {
                MessageBox.Show("Esta hora ya esta agendada, por favor elija otra");
            }
        }
    }
}
