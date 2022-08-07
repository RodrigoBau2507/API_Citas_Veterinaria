namespace Veterinaria2._0
{
    partial class Cita
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
            System.Windows.Forms.PictureBox pictureBox4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cita));
            System.Windows.Forms.PictureBox pictureBox3;
            this.textId = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.Agregar_Propietario = new System.Windows.Forms.Button();
            this.Servicio = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Ser = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Fecha_Cita = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboMascota = new System.Windows.Forms.ComboBox();
            this.Mascota = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Ver_Citas = new System.Windows.Forms.Button();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pictureBox4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.ErrorImage")));
            pictureBox4.Image = global::Veterinaria2._0.Properties.Resources.images1;
            pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            pictureBox4.Location = new System.Drawing.Point(586, 129);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(240, 386);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 95;
            pictureBox4.TabStop = false;
            pictureBox4.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            pictureBox3.Image = global::Veterinaria2._0.Properties.Resources.images__1_;
            pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            pictureBox3.Location = new System.Drawing.Point(0, 122);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(233, 386);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 94;
            pictureBox3.TabStop = false;
            pictureBox3.UseWaitCursor = true;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(263, 135);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(27, 20);
            this.textId.TabIndex = 108;
            this.textId.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.CustomFormat = "yyyy-MM-dd";
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha.Location = new System.Drawing.Point(480, 306);
            this.Fecha.MinDate = new System.DateTime(2022, 4, 17, 0, 0, 0, 0);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(80, 20);
            this.Fecha.TabIndex = 106;
            this.Fecha.ValueChanged += new System.EventHandler(this.Fecha_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 105;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Agregar_Propietario
            // 
            this.Agregar_Propietario.Location = new System.Drawing.Point(485, 421);
            this.Agregar_Propietario.Name = "Agregar_Propietario";
            this.Agregar_Propietario.Size = new System.Drawing.Size(75, 46);
            this.Agregar_Propietario.TabIndex = 104;
            this.Agregar_Propietario.Text = "Agendar Cita";
            this.Agregar_Propietario.UseVisualStyleBackColor = true;
            this.Agregar_Propietario.Click += new System.EventHandler(this.Agregar_Propietario_Click);
            // 
            // Servicio
            // 
            this.Servicio.FormattingEnabled = true;
            this.Servicio.Location = new System.Drawing.Point(439, 267);
            this.Servicio.Name = "Servicio";
            this.Servicio.Size = new System.Drawing.Size(121, 21);
            this.Servicio.TabIndex = 103;
            this.Servicio.SelectedIndexChanged += new System.EventHandler(this.Servicio_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(400, 180);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(180, 60);
            this.txtDescripcion.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 101;
            // 
            // Ser
            // 
            this.Ser.AutoSize = true;
            this.Ser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ser.Location = new System.Drawing.Point(272, 264);
            this.Ser.Name = "Ser";
            this.Ser.Size = new System.Drawing.Size(74, 22);
            this.Ser.TabIndex = 100;
            this.Ser.Text = "Servicio";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(272, 191);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(105, 22);
            this.Descripcion.TabIndex = 99;
            this.Descripcion.Text = "Descripcion";
            // 
            // Fecha_Cita
            // 
            this.Fecha_Cita.AutoSize = true;
            this.Fecha_Cita.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Cita.Location = new System.Drawing.Point(272, 304);
            this.Fecha_Cita.Name = "Fecha_Cita";
            this.Fecha_Cita.Size = new System.Drawing.Size(55, 22);
            this.Fecha_Cita.TabIndex = 98;
            this.Fecha_Cita.Text = "Fecha";
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(272, 158);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(50, 22);
            this.Hora.TabIndex = 97;
            this.Hora.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 96;
            this.label2.Text = "Cita";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 125);
            this.panel1.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 43);
            this.label1.TabIndex = 62;
            this.label1.Text = "Veterinaria \"Perritos Sonrientes\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Veterinaria2._0.Properties.Resources.descarga__1_;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(706, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::Veterinaria2._0.Properties.Resources.descarga__1_;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // comboMascota
            // 
            this.comboMascota.FormattingEnabled = true;
            this.comboMascota.Location = new System.Drawing.Point(430, 341);
            this.comboMascota.Name = "comboMascota";
            this.comboMascota.Size = new System.Drawing.Size(130, 21);
            this.comboMascota.TabIndex = 109;
            // 
            // Mascota
            // 
            this.Mascota.AutoSize = true;
            this.Mascota.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.Mascota.Location = new System.Drawing.Point(272, 340);
            this.Mascota.Name = "Mascota";
            this.Mascota.Size = new System.Drawing.Size(78, 22);
            this.Mascota.TabIndex = 110;
            this.Mascota.Text = "Mascota";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(461, 154);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 4, 17, 19, 30, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 4, 17, 9, 30, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 111;
            this.dateTimePicker1.Value = new System.DateTime(2022, 4, 17, 9, 30, 0, 0);
            // 
            // Ver_Citas
            // 
            this.Ver_Citas.Location = new System.Drawing.Point(271, 421);
            this.Ver_Citas.Name = "Ver_Citas";
            this.Ver_Citas.Size = new System.Drawing.Size(75, 46);
            this.Ver_Citas.TabIndex = 115;
            this.Ver_Citas.Text = "Ver Citas";
            this.Ver_Citas.UseVisualStyleBackColor = true;
            this.Ver_Citas.Click += new System.EventHandler(this.Ver_Citas_Click);
            // 
            // Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(826, 508);
            this.Controls.Add(this.Ver_Citas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Mascota);
            this.Controls.Add(this.comboMascota);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Agregar_Propietario);
            this.Controls.Add(this.Servicio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ser);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Fecha_Cita);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.label2);
            this.Controls.Add(pictureBox4);
            this.Controls.Add(pictureBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cita";
            this.Text = "Cita";
            this.Load += new System.EventHandler(this.Cita_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Agregar_Propietario;
        private System.Windows.Forms.ComboBox Servicio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Ser;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Fecha_Cita;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboMascota;
        private System.Windows.Forms.Label Mascota;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Ver_Citas;
    }
}