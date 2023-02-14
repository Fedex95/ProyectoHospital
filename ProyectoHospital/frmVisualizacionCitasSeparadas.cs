using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHospital
{
    public partial class frmVisualizacionCitasSeparadas : Form
    {
        private Form activeFrmCitasSeparadas;
        public frmVisualizacionCitasSeparadas()
        {
            InitializeComponent();
        }

        private void frmVisualizacionCitasSeparadas_Load(object sender, EventArgs e)
        {
            this.Text = DAO.Usuario.nombreUsuario;
            labelNombre.Text = DAO.Usuario.nombreUsuario;
            labelFecha.Text = System.DateTime.Now.ToLongDateString();
        }

        private void OpenChildFrmCitasSeparadas(Form childFrmCitasSeparadas, object btnSender)
        {
            if (activeFrmCitasSeparadas != null)
            {
                activeFrmCitasSeparadas.Close();
            }
            activeFrmCitasSeparadas = childFrmCitasSeparadas;
            childFrmCitasSeparadas.TopLevel = false;
            childFrmCitasSeparadas.FormBorderStyle = FormBorderStyle.None;
            childFrmCitasSeparadas.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(childFrmCitasSeparadas);
            this.panel_Contenedor.Tag = childFrmCitasSeparadas;
            childFrmCitasSeparadas.BringToFront();
            childFrmCitasSeparadas.Show();
        }

        private void btnCitasMedicas_Click(object sender, EventArgs e)
        {
            OpenChildFrmCitasSeparadas(new FrmCitasSeparadas.frmCitasMedicas(), sender);
        }

        private void btnCitasOdontologicas_Click(object sender, EventArgs e)
        {
            OpenChildFrmCitasSeparadas(new FrmCitasSeparadas.frmCitasOdontologicas(), sender);
        }

        private void btnCitasVisuales_Click(object sender, EventArgs e)
        {
            OpenChildFrmCitasSeparadas(new FrmCitasSeparadas.frmCitasVisuales(), sender);
        }

        private void btnCitasLaboratorio_Click(object sender, EventArgs e)
        {
            OpenChildFrmCitasSeparadas(new FrmCitasSeparadas.frmCitasLaboratorio(), sender);
        }

        private void btnCitasFisioterapia_Click(object sender, EventArgs e)
        {
            OpenChildFrmCitasSeparadas(new FrmCitasSeparadas.frmCitasFisioterapia(), sender);
        }

        private void btnCitasFisiatríaYRehabilitación_Click(object sender, EventArgs e)
        {
            OpenChildFrmCitasSeparadas(new FrmCitasSeparadas.frmCitasFisiatríaYRehabilitación(), sender);
        }
    }
}
    