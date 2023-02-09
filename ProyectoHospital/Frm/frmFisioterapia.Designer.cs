namespace ProyectoHospital.Frm
{
    partial class frmFisioterapia
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
            this.cmbBox2Fs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtfechaAtFs = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBox1Fs = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBox2Fs
            // 
            this.cmbBox2Fs.FormattingEnabled = true;
            this.cmbBox2Fs.Items.AddRange(new object[] {
            "7 AM",
            "10 AM",
            "12 PM",
            "3 PM",
            "5 PM",
            "7 PM"});
            this.cmbBox2Fs.Location = new System.Drawing.Point(474, 261);
            this.cmbBox2Fs.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBox2Fs.Name = "cmbBox2Fs";
            this.cmbBox2Fs.Size = new System.Drawing.Size(144, 24);
            this.cmbBox2Fs.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Hora de la cita";
            // 
            // dtfechaAtFs
            // 
            this.dtfechaAtFs.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaAtFs.Location = new System.Drawing.Point(474, 170);
            this.dtfechaAtFs.Margin = new System.Windows.Forms.Padding(4);
            this.dtfechaAtFs.Name = "dtfechaAtFs";
            this.dtfechaAtFs.Size = new System.Drawing.Size(144, 22);
            this.dtfechaAtFs.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fecha de la cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Médico a atender";
            // 
            // cmbBox1Fs
            // 
            this.cmbBox1Fs.FormattingEnabled = true;
            this.cmbBox1Fs.Items.AddRange(new object[] {
            "Pedro",
            "Juan",
            "Gil"});
            this.cmbBox1Fs.Location = new System.Drawing.Point(474, 93);
            this.cmbBox1Fs.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBox1Fs.Name = "cmbBox1Fs";
            this.cmbBox1Fs.Size = new System.Drawing.Size(144, 24);
            this.cmbBox1Fs.TabIndex = 25;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(347, 382);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(149, 34);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "SEPARE SU CITA CON EL FISIOTERAPEUTA";
            // 
            // frmFisioterapia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbBox2Fs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtfechaAtFs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBox1Fs);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Name = "frmFisioterapia";
            this.Text = "frmFisioterapia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox2Fs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtfechaAtFs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBox1Fs;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
    }
}