namespace ProyectoHospital.Frm
{
    partial class frmVisual
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
            this.cmbBox2Vs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtfechaAtVs = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBox1Vs = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "SEPARE SU CITA PARA UN EXAMEN VISUAL ";
            // 
            // cmbBox2Vs
            // 
            this.cmbBox2Vs.FormattingEnabled = true;
            this.cmbBox2Vs.Items.AddRange(new object[] {
            "7 AM",
            "10 AM",
            "12 PM",
            "3 PM",
            "5 PM",
            "7 PM"});
            this.cmbBox2Vs.Location = new System.Drawing.Point(345, 205);
            this.cmbBox2Vs.Name = "cmbBox2Vs";
            this.cmbBox2Vs.Size = new System.Drawing.Size(109, 21);
            this.cmbBox2Vs.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hora de la cita";
            // 
            // dtfechaAtVs
            // 
            this.dtfechaAtVs.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechaAtVs.Location = new System.Drawing.Point(345, 131);
            this.dtfechaAtVs.Name = "dtfechaAtVs";
            this.dtfechaAtVs.Size = new System.Drawing.Size(109, 20);
            this.dtfechaAtVs.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 130);
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
            this.label2.Location = new System.Drawing.Point(129, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Médico a atender";
            // 
            // cmbBox1Vs
            // 
            this.cmbBox1Vs.FormattingEnabled = true;
            this.cmbBox1Vs.Items.AddRange(new object[] {
            "Pedro",
            "Juan",
            "Gil"});
            this.cmbBox1Vs.Location = new System.Drawing.Point(345, 68);
            this.cmbBox1Vs.Name = "cmbBox1Vs";
            this.cmbBox1Vs.Size = new System.Drawing.Size(109, 21);
            this.cmbBox1Vs.TabIndex = 17;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(250, 303);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 28);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cmbBox2Vs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtfechaAtVs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBox1Vs);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVisual";
            this.Text = "frmVisual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBox2Vs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtfechaAtVs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBox1Vs;
        private System.Windows.Forms.Button btnAceptar;
    }
}