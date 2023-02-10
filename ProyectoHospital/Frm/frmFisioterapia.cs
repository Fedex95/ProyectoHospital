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
    public partial class frmFisioterapia : Form
    {
        public frmFisioterapia()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoHospital.DAO.Citas eci = new ProyectoHospital.DAO.Citas();
                eci.numCedula2 = this.textBox1.Text;
                eci.nombres2 = this.textBox2.Text;
                eci.apellidos2 = this.textBox3.Text;
                eci.medico = this.comboBox1.SelectedItem.ToString();
                eci.fechaAtencion = this.comboBox2.SelectedItem.ToString();

                ProyectoHospital.DAO.CitasFisioDAO objCita = new ProyectoHospital.DAO.CitasFisioDAO();

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
