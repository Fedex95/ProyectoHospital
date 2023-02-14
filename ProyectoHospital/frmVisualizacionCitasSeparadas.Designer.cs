namespace ProyectoHospital
{
    partial class frmVisualizacionCitasSeparadas
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_Lateral = new System.Windows.Forms.Panel();
            this.btnCitasFisiatríaYRehabilitación = new System.Windows.Forms.Button();
            this.btnCitasFisioterapia = new System.Windows.Forms.Button();
            this.btnCitasLaboratorio = new System.Windows.Forms.Button();
            this.btnCitasVisuales = new System.Windows.Forms.Button();
            this.btnCitasOdontologicas = new System.Windows.Forms.Button();
            this.btnCitasMedicas = new System.Windows.Forms.Button();
            this.panel_Margen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.panel_Lateral.SuspendLayout();
            this.panel_Margen.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelNombre,
            this.labelFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(928, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelNombre
            // 
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(37, 17);
            this.labelNombre.Text = "------";
            // 
            // labelFecha
            // 
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 17);
            this.labelFecha.Text = "------";
            // 
            // panel_Lateral
            // 
            this.panel_Lateral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Lateral.Controls.Add(this.btnCitasFisiatríaYRehabilitación);
            this.panel_Lateral.Controls.Add(this.btnCitasFisioterapia);
            this.panel_Lateral.Controls.Add(this.btnCitasLaboratorio);
            this.panel_Lateral.Controls.Add(this.btnCitasVisuales);
            this.panel_Lateral.Controls.Add(this.btnCitasOdontologicas);
            this.panel_Lateral.Controls.Add(this.btnCitasMedicas);
            this.panel_Lateral.Controls.Add(this.panel_Margen);
            this.panel_Lateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Lateral.Location = new System.Drawing.Point(779, 0);
            this.panel_Lateral.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Lateral.Name = "panel_Lateral";
            this.panel_Lateral.Size = new System.Drawing.Size(149, 490);
            this.panel_Lateral.TabIndex = 1;
            // 
            // btnCitasFisiatríaYRehabilitación
            // 
            this.btnCitasFisiatríaYRehabilitación.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitasFisiatríaYRehabilitación.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitasFisiatríaYRehabilitación.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitasFisiatríaYRehabilitación.Location = new System.Drawing.Point(0, 341);
            this.btnCitasFisiatríaYRehabilitación.Margin = new System.Windows.Forms.Padding(2);
            this.btnCitasFisiatríaYRehabilitación.Name = "btnCitasFisiatríaYRehabilitación";
            this.btnCitasFisiatríaYRehabilitación.Size = new System.Drawing.Size(149, 50);
            this.btnCitasFisiatríaYRehabilitación.TabIndex = 7;
            this.btnCitasFisiatríaYRehabilitación.Text = "Citas de Fisiatría y Rehabilitación";
            this.btnCitasFisiatríaYRehabilitación.UseVisualStyleBackColor = true;
            this.btnCitasFisiatríaYRehabilitación.Click += new System.EventHandler(this.btnCitasFisiatríaYRehabilitación_Click);
            // 
            // btnCitasFisioterapia
            // 
            this.btnCitasFisioterapia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitasFisioterapia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitasFisioterapia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitasFisioterapia.Location = new System.Drawing.Point(0, 291);
            this.btnCitasFisioterapia.Margin = new System.Windows.Forms.Padding(2);
            this.btnCitasFisioterapia.Name = "btnCitasFisioterapia";
            this.btnCitasFisioterapia.Size = new System.Drawing.Size(149, 50);
            this.btnCitasFisioterapia.TabIndex = 6;
            this.btnCitasFisioterapia.Text = "Citas de Fisioterapia";
            this.btnCitasFisioterapia.UseVisualStyleBackColor = true;
            this.btnCitasFisioterapia.Click += new System.EventHandler(this.btnCitasFisioterapia_Click);
            // 
            // btnCitasLaboratorio
            // 
            this.btnCitasLaboratorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitasLaboratorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitasLaboratorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitasLaboratorio.Location = new System.Drawing.Point(0, 241);
            this.btnCitasLaboratorio.Margin = new System.Windows.Forms.Padding(2);
            this.btnCitasLaboratorio.Name = "btnCitasLaboratorio";
            this.btnCitasLaboratorio.Size = new System.Drawing.Size(149, 50);
            this.btnCitasLaboratorio.TabIndex = 5;
            this.btnCitasLaboratorio.Text = "Citas de Laboratorio";
            this.btnCitasLaboratorio.UseVisualStyleBackColor = true;
            this.btnCitasLaboratorio.Click += new System.EventHandler(this.btnCitasLaboratorio_Click);
            // 
            // btnCitasVisuales
            // 
            this.btnCitasVisuales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitasVisuales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitasVisuales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitasVisuales.Location = new System.Drawing.Point(0, 191);
            this.btnCitasVisuales.Margin = new System.Windows.Forms.Padding(2);
            this.btnCitasVisuales.Name = "btnCitasVisuales";
            this.btnCitasVisuales.Size = new System.Drawing.Size(149, 50);
            this.btnCitasVisuales.TabIndex = 4;
            this.btnCitasVisuales.Text = "Citas Visuales";
            this.btnCitasVisuales.UseVisualStyleBackColor = true;
            this.btnCitasVisuales.Click += new System.EventHandler(this.btnCitasVisuales_Click);
            // 
            // btnCitasOdontologicas
            // 
            this.btnCitasOdontologicas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitasOdontologicas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitasOdontologicas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitasOdontologicas.Location = new System.Drawing.Point(0, 141);
            this.btnCitasOdontologicas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCitasOdontologicas.Name = "btnCitasOdontologicas";
            this.btnCitasOdontologicas.Size = new System.Drawing.Size(149, 50);
            this.btnCitasOdontologicas.TabIndex = 3;
            this.btnCitasOdontologicas.Text = "Citas Odontologicas";
            this.btnCitasOdontologicas.UseVisualStyleBackColor = true;
            this.btnCitasOdontologicas.Click += new System.EventHandler(this.btnCitasOdontologicas_Click);
            // 
            // btnCitasMedicas
            // 
            this.btnCitasMedicas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitasMedicas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCitasMedicas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitasMedicas.Location = new System.Drawing.Point(0, 91);
            this.btnCitasMedicas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCitasMedicas.Name = "btnCitasMedicas";
            this.btnCitasMedicas.Size = new System.Drawing.Size(149, 50);
            this.btnCitasMedicas.TabIndex = 2;
            this.btnCitasMedicas.Text = "Citas Medico General";
            this.btnCitasMedicas.UseVisualStyleBackColor = true;
            this.btnCitasMedicas.Click += new System.EventHandler(this.btnCitasMedicas_Click);
            // 
            // panel_Margen
            // 
            this.panel_Margen.Controls.Add(this.label1);
            this.panel_Margen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Margen.Location = new System.Drawing.Point(0, 0);
            this.panel_Margen.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Margen.Name = "panel_Margen";
            this.panel_Margen.Size = new System.Drawing.Size(149, 91);
            this.panel_Margen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONE EL CAMPO\r\nQUE DESEA SACAR UNA\r\nCITA MEDICA";
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenedor.Location = new System.Drawing.Point(0, 0);
            this.panel_Contenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(779, 490);
            this.panel_Contenedor.TabIndex = 3;
            // 
            // frmVisualizacionCitasSeparadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 512);
            this.Controls.Add(this.panel_Contenedor);
            this.Controls.Add(this.panel_Lateral);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVisualizacionCitasSeparadas";
            this.Text = "----------------";
            this.Load += new System.EventHandler(this.frmVisualizacionCitasSeparadas_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel_Lateral.ResumeLayout(false);
            this.panel_Margen.ResumeLayout(false);
            this.panel_Margen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelNombre;
        private System.Windows.Forms.ToolStripStatusLabel labelFecha;
        private System.Windows.Forms.Panel panel_Lateral;
        private System.Windows.Forms.Panel panel_Margen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCitasMedicas;
        private System.Windows.Forms.Button btnCitasOdontologicas;
        private System.Windows.Forms.Button btnCitasVisuales;
        private System.Windows.Forms.Button btnCitasLaboratorio;
        private System.Windows.Forms.Button btnCitasFisioterapia;
        private System.Windows.Forms.Button btnCitasFisiatríaYRehabilitación;
        private System.Windows.Forms.Panel panel_Contenedor;
    }
}