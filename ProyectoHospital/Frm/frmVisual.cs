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
    public partial class frmVisual : Form
    {
        public frmVisual()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoHospital.DAO.Citas eci = new ProyectoHospital.DAO.Citas();
                eci.medico = this.cmbBox1Vs.SelectedItem.ToString();
                eci.fechaAtencion = dtfechaAtVs.Value;
                eci.horaCita = this.cmbBox2Vs.SelectedItem.ToString();

                ProyectoHospital.DAO.CitasVsDAO objCita = new ProyectoHospital.DAO.CitasVsDAO();

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
