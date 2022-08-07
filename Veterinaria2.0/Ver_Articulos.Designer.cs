namespace Veterinaria2._0
{
    partial class Ver_Articulos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_Articulos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textPiezas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Agregar_Articulo = new System.Windows.Forms.Button();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Regresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.idArticulosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piezas1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datMediBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datMediBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticulosDataGridViewTextBoxColumn,
            this.articulo1DataGridViewTextBoxColumn,
            this.precio1DataGridViewTextBoxColumn,
            this.piezas1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.datArticulosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(312, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 374);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(311, 484);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 56);
            this.panel3.TabIndex = 73;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 32);
            this.button3.TabIndex = 63;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 32);
            this.button2.TabIndex = 62;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 62;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::Veterinaria2._0.Properties.Resources.descarga__1_;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.textId);
            this.panel2.Controls.Add(this.textPiezas);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Agregar_Articulo);
            this.panel2.Controls.Add(this.textPrecio);
            this.panel2.Controls.Add(this.textNombre);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Regresar);
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 423);
            this.panel2.TabIndex = 72;
            // 
            // textPiezas
            // 
            this.textPiezas.Location = new System.Drawing.Point(168, 159);
            this.textPiezas.Name = "textPiezas";
            this.textPiezas.Size = new System.Drawing.Size(119, 20);
            this.textPiezas.TabIndex = 140;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 139;
            this.label5.Text = "Piezas";
            // 
            // Agregar_Articulo
            // 
            this.Agregar_Articulo.Location = new System.Drawing.Point(212, 318);
            this.Agregar_Articulo.Name = "Agregar_Articulo";
            this.Agregar_Articulo.Size = new System.Drawing.Size(75, 46);
            this.Agregar_Articulo.TabIndex = 137;
            this.Agregar_Articulo.Text = "Agregar Articulo";
            this.Agregar_Articulo.UseVisualStyleBackColor = true;
            this.Agregar_Articulo.Click += new System.EventHandler(this.Agregar_Articulo_Click);
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(168, 119);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(119, 20);
            this.textPrecio.TabIndex = 136;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(168, 79);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(119, 20);
            this.textNombre.TabIndex = 135;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 134;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 133;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 132;
            this.label2.Text = "Articulos";
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(33, 318);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(90, 32);
            this.Regresar.TabIndex = 63;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 120);
            this.panel1.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 43);
            this.label1.TabIndex = 60;
            this.label1.Text = "Veterinaria \"Perritos Sonrientes\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Veterinaria2._0.Properties.Resources.descarga__1_;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(638, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(33, 19);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(52, 20);
            this.textId.TabIndex = 75;
            this.textId.Visible = false;
            // 
            // idArticulosDataGridViewTextBoxColumn
            // 
            this.idArticulosDataGridViewTextBoxColumn.DataPropertyName = "IdArticulos";
            this.idArticulosDataGridViewTextBoxColumn.HeaderText = "IdArticulos";
            this.idArticulosDataGridViewTextBoxColumn.Name = "idArticulosDataGridViewTextBoxColumn";
            // 
            // articulo1DataGridViewTextBoxColumn
            // 
            this.articulo1DataGridViewTextBoxColumn.DataPropertyName = "Articulo1";
            this.articulo1DataGridViewTextBoxColumn.HeaderText = "Articulo1";
            this.articulo1DataGridViewTextBoxColumn.Name = "articulo1DataGridViewTextBoxColumn";
            // 
            // precio1DataGridViewTextBoxColumn
            // 
            this.precio1DataGridViewTextBoxColumn.DataPropertyName = "Precio1";
            this.precio1DataGridViewTextBoxColumn.HeaderText = "Precio1";
            this.precio1DataGridViewTextBoxColumn.Name = "precio1DataGridViewTextBoxColumn";
            // 
            // piezas1DataGridViewTextBoxColumn
            // 
            this.piezas1DataGridViewTextBoxColumn.DataPropertyName = "Piezas1";
            this.piezas1DataGridViewTextBoxColumn.HeaderText = "Piezas1";
            this.piezas1DataGridViewTextBoxColumn.Name = "piezas1DataGridViewTextBoxColumn";
            // 
            // datArticulosBindingSource
            // 
            this.datArticulosBindingSource.DataSource = typeof(Veterinaria2._0.DatArticulos);
            // 
            // datMediBindingSource
            // 
            this.datMediBindingSource.DataSource = typeof(Veterinaria2._0.DatMedi);
            // 
            // Ver_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 535);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ver_Articulos";
            this.Text = "Ver_Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datMediBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textPiezas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Agregar_Articulo;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource datMediBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticulosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piezas1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource datArticulosBindingSource;
        private System.Windows.Forms.TextBox textId;
    }
}