namespace Veterinaria2._0
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Datos_Pro = new System.Windows.Forms.Button();
            this.Articulos = new System.Windows.Forms.Button();
            this.Datos_Doctor = new System.Windows.Forms.Button();
            this.Medicamentos = new System.Windows.Forms.Button();
            this.Mascota = new System.Windows.Forms.Button();
            this.butSalir = new System.Windows.Forms.Button();
            this.Recibo = new System.Windows.Forms.Button();
            this.Citas = new System.Windows.Forms.Button();
            this.AgendarCita = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Datos_Pro
            // 
            this.Datos_Pro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Datos_Pro.Location = new System.Drawing.Point(245, 336);
            this.Datos_Pro.Name = "Datos_Pro";
            this.Datos_Pro.Size = new System.Drawing.Size(90, 41);
            this.Datos_Pro.TabIndex = 87;
            this.Datos_Pro.Text = "Ver Datos del Propietario";
            this.Datos_Pro.UseVisualStyleBackColor = false;
            this.Datos_Pro.Click += new System.EventHandler(this.Datos_Pro_Click_1);
            // 
            // Articulos
            // 
            this.Articulos.Location = new System.Drawing.Point(546, 167);
            this.Articulos.Name = "Articulos";
            this.Articulos.Size = new System.Drawing.Size(91, 55);
            this.Articulos.TabIndex = 86;
            this.Articulos.Text = "Agregar Articulos";
            this.Articulos.UseVisualStyleBackColor = true;
            this.Articulos.Click += new System.EventHandler(this.Articulos_Click_1);
            // 
            // Datos_Doctor
            // 
            this.Datos_Doctor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Datos_Doctor.Location = new System.Drawing.Point(245, 241);
            this.Datos_Doctor.Name = "Datos_Doctor";
            this.Datos_Doctor.Size = new System.Drawing.Size(75, 41);
            this.Datos_Doctor.TabIndex = 84;
            this.Datos_Doctor.Text = "Doctor";
            this.Datos_Doctor.UseVisualStyleBackColor = false;
            this.Datos_Doctor.Click += new System.EventHandler(this.Datos_Doctor_Click_1);
            // 
            // Medicamentos
            // 
            this.Medicamentos.Location = new System.Drawing.Point(546, 67);
            this.Medicamentos.Name = "Medicamentos";
            this.Medicamentos.Size = new System.Drawing.Size(91, 55);
            this.Medicamentos.TabIndex = 82;
            this.Medicamentos.Text = "Agregar Medicamentos";
            this.Medicamentos.UseVisualStyleBackColor = true;
            this.Medicamentos.Click += new System.EventHandler(this.Medicamentos_Click_1);
            // 
            // Mascota
            // 
            this.Mascota.Location = new System.Drawing.Point(245, 147);
            this.Mascota.Name = "Mascota";
            this.Mascota.Size = new System.Drawing.Size(75, 42);
            this.Mascota.TabIndex = 81;
            this.Mascota.Text = "Agregar Mascota";
            this.Mascota.UseVisualStyleBackColor = true;
            this.Mascota.Click += new System.EventHandler(this.Mascota_Click_1);
            // 
            // butSalir
            // 
            this.butSalir.BackColor = System.Drawing.Color.Crimson;
            this.butSalir.DialogResult = System.Windows.Forms.DialogResult.No;
            this.butSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butSalir.Location = new System.Drawing.Point(369, 410);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(133, 51);
            this.butSalir.TabIndex = 80;
            this.butSalir.Text = "Salir";
            this.butSalir.UseVisualStyleBackColor = false;
            this.butSalir.Click += new System.EventHandler(this.butSalir_Click_1);
            // 
            // Recibo
            // 
            this.Recibo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Recibo.Location = new System.Drawing.Point(562, 371);
            this.Recibo.Name = "Recibo";
            this.Recibo.Size = new System.Drawing.Size(75, 24);
            this.Recibo.TabIndex = 79;
            this.Recibo.Text = "Recibo";
            this.Recibo.UseVisualStyleBackColor = false;
            this.Recibo.Visible = false;
            this.Recibo.Click += new System.EventHandler(this.Recibo_Click_1);
            // 
            // Citas
            // 
            this.Citas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Citas.Location = new System.Drawing.Point(562, 262);
            this.Citas.Name = "Citas";
            this.Citas.Size = new System.Drawing.Size(75, 23);
            this.Citas.TabIndex = 78;
            this.Citas.Text = "Citas";
            this.Citas.UseVisualStyleBackColor = false;
            this.Citas.Click += new System.EventHandler(this.Citas_Click_1);
            // 
            // AgendarCita
            // 
            this.AgendarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AgendarCita.Location = new System.Drawing.Point(245, 67);
            this.AgendarCita.Name = "AgendarCita";
            this.AgendarCita.Size = new System.Drawing.Size(75, 41);
            this.AgendarCita.TabIndex = 76;
            this.AgendarCita.Text = "Agendar Cita";
            this.AgendarCita.UseVisualStyleBackColor = false;
            this.AgendarCita.Click += new System.EventHandler(this.AgendarCita_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 53);
            this.panel2.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veterinaria \"Perritos Sonrientes\"";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.ErrorImage")));
            this.PictureBox1.Image = global::Veterinaria2._0.Properties.Resources.depositphotos_55249365_stock_photo_veterinary_black_circle_label_design;
            this.PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.InitialImage")));
            this.PictureBox1.Location = new System.Drawing.Point(1, 46);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(872, 467);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 74;
            this.PictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(399, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 88;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Datos_Pro);
            this.Controls.Add(this.Articulos);
            this.Controls.Add(this.Datos_Doctor);
            this.Controls.Add(this.Medicamentos);
            this.Controls.Add(this.Mascota);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.Recibo);
            this.Controls.Add(this.Citas);
            this.Controls.Add(this.AgendarCita);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Datos_Pro;
        private System.Windows.Forms.Button Articulos;
        private System.Windows.Forms.Button Datos_Doctor;
        private System.Windows.Forms.Button Medicamentos;
        private System.Windows.Forms.Button Mascota;
        private System.Windows.Forms.Button butSalir;
        private System.Windows.Forms.Button Recibo;
        private System.Windows.Forms.Button Citas;
        private System.Windows.Forms.Button AgendarCita;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button button1;
    }
}