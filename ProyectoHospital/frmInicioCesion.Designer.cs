namespace ProyectoHospital
{
    partial class frmInicioCesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnIniciarCesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CENTRO DE SALUD MEDICO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(815, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE SU NUM CEDULA Y CONTRASEÑA SI YA TIENE UNA CUENTA CREADA, CASO CONTARIO P" +
    "RESIONE CREAR CUENTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NUM. CEDULA DE IDENTIDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CONTRASEÑA";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(406, 122);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(202, 39);
            this.txtCedula.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(406, 245);
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(202, 39);
            this.txtContraseña.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(173, 377);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(209, 70);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnIniciarCesion
            // 
            this.btnIniciarCesion.Location = new System.Drawing.Point(526, 377);
            this.btnIniciarCesion.Name = "btnIniciarCesion";
            this.btnIniciarCesion.Size = new System.Drawing.Size(209, 70);
            this.btnIniciarCesion.TabIndex = 7;
            this.btnIniciarCesion.Text = "CREAR CUENTA";
            this.btnIniciarCesion.UseVisualStyleBackColor = true;
            this.btnIniciarCesion.Click += new System.EventHandler(this.btnIniciarCesion_Click);
            // 
            // frmInicioCesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 520);
            this.Controls.Add(this.btnIniciarCesion);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInicioCesion";
            this.Text = "INICIO DE CESION DEL CENTRO MEDICO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnIniciarCesion;
    }
}