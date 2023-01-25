﻿using System;
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
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProyectoHospital.DAO.Cliente est = new ProyectoHospital.DAO.Cliente();
            est.numCedula = this.txtnumCedula.Text;
            est.nombres = this.txtNombres.Text;
            est.apellidos = this.txtApellidos.Text;
            est.fechaNacimiento = dtfechaNacimiento.Value;
            est.crearContraseña = this.txtContraseña.Text;

            ProyectoHospital.DAO.ClienteDAO objCliente = new ProyectoHospital.DAO.ClienteDAO();
            int x = objCliente.guardar(est);
            if (x > 0)
                MessageBox.Show("Cliente registrado con éxito");
            else
                MessageBox.Show("Error, no se pudo registrar el cliente");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}