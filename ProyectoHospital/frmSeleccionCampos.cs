
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;




namespace ProyectoHospital
{
    public partial class frmSeleccionCampos : Form
    {
        private Form activeFrm;
        public frmSeleccionCampos()
        {
            InitializeComponent();
        }

        private void frmSeleccionCampos_Load(object sender, EventArgs e)
        {
            this.Text = DAO.Usuario.nombreUsuario;
            labelNombre.Text = DAO.Usuario.nombreUsuario;
            labelFecha.Text = System.DateTime.Now.ToLongDateString();
            Size = new Size(1255, 700);
        }

        
        private void OpenChildFrm(Form childFrm, object btnSender)
        {
            if(activeFrm != null)
            {
                activeFrm.Close();
            }
            activeFrm = childFrm;
            childFrm.TopLevel = false;
            childFrm.FormBorderStyle = FormBorderStyle.None;
            childFrm.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(childFrm);
            this.panel_contenedor.Tag = childFrm;
            childFrm.BringToFront();
            childFrm.Show();
            Size = new Size(1210, 660);
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            OpenChildFrm(new Frm.frmMedico(),sender);
        }

        private void btnOdontologia_Click(object sender, EventArgs e)
        {
            OpenChildFrm(new Frm.frmOdontologia(), sender);
        }

        private void btnVisual_Click(object sender, EventArgs e)
        {
            OpenChildFrm(new Frm.frmVisual(), sender);
        }

        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
            OpenChildFrm(new Frm.frmLaboratorio(), sender);
        }

        private void btnFisioterapia_Click(object sender, EventArgs e)
        {
            OpenChildFrm(new Frm.frmFisioterapia(), sender);
        }

        private void btnFisiatríaYRehabilitación_Click(object sender, EventArgs e)
        {
            OpenChildFrm(new Frm.frmvFisiatríaYRehabilitación(), sender);
        }

        private void btnCitasSeparadas_Click(object sender, EventArgs e)
        {
            Form formulario = new frmVisualizacionCitasSeparadas();
            formulario.Show();
        }

      
    }
}
