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

namespace ProyectoHospital.Frm
{
    public partial class frmOdontologia : Form
    {
        public frmOdontologia()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoHospital.DAO.Citas eci = new ProyectoHospital.DAO.Citas();
                eci.medico = this.cmbBox1Od.SelectedItem.ToString();
                eci.fechaAtencion = dtfechaAtO.Value;
                eci.horaCita = this.cmbBox2O.SelectedItem.ToString();

                ProyectoHospital.DAO.CitasODAO objCita = new ProyectoHospital.DAO.CitasODAO();

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
            }
            catch (SqlException)
            {
                MessageBox.Show("Esta hora ya esta agendada, por favor elija otra");
            }
        }
    
    }
}
