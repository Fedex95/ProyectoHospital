namespace ProyectoHospital.Frm
{
    partial class frmLaboratorio
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
            this.cmbBox2Lb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtfechaAtLb = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBox1Lb = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEPARE SU CITA PARA LOS EXAMENES DE LABORATORIO  ";
            // 
            // cmbBox2Lb
            // 
            this.cmbBox2Lb.FormattingEnabled = true;
            this.cmbBox2Lb.Items.AddRange(new object[] {
            "7 AM",
            "10 AM",
            "12 PM",
            "3 PM",
            "5 PM",
            "7 PM"});
            this.cmbBox2Lb.Location = new System.Drawing.Point(340, 210);
            this.cmbBox2Lb.Name = "cmbBox2Lb";
            this.cmbBox2Lb.Size = new System.Drawing.Size(109, 21);
            this.cmbBox2Lb.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hora de la cita";
            // 
            // dtfechaAtLb
            // 
            this.dtfechaAtLb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaAtLb.Location = new System.Drawing.Point(340, 136);
            this.dtfechaAtLb.Name = "dtfechaAtLb";
            this.dtfechaAtLb.Size = new System.Drawing.Size(109, 20);
            this.dtfechaAtLb.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha de la cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Médico a atender";
            // 
            // cmbBox1Lb
            // 
            this.cmbBox1Lb.FormattingEnabled = true;
            this.cmbBox1Lb.Items.AddRange(new object[] {
            "Pedro",
            "Juan",
            "Gil"});
            this.cmbBox1Lb.Location = new System.Drawing.Point(340, 73);
            this.cmbBox1Lb.Name = "cmbBox1Lb";
            this.cmbBox1Lb.Size = new System.Drawing.Size(109, 21);
            this.cmbBox1Lb.TabIndex = 17;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(245, 308);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 28);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cmbBox2Lb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtfechaAtLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBox1Lb);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLaboratorio";
            this.Text = "frmLaboratorio";
            this.Load += new System.EventHandler(this.frmLaboratorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBox2Lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtfechaAtLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBox1Lb;
        private System.Windows.Forms.Button btnAceptar;
    }
}