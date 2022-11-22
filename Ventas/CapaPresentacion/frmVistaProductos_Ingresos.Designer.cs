namespace CapaPresentacion
{
    partial class frmVistaProductos_Ingresos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaProductos_Ingresos));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonMarca = new System.Windows.Forms.RadioButton();
            this.textBoxBuscarxNombre = new System.Windows.Forms.TextBox();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.textBoxBuscarxMarca = new System.Windows.Forms.TextBox();
            this.buttonBuscarxNombre = new System.Windows.Forms.Button();
            this.buttonBuscarxMarca = new System.Windows.Forms.Button();
            this.dataGridViewMantenimientoDeProducto = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.ColumnUsuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMantenimientoDeProducto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonMarca);
            this.groupBox4.Controls.Add(this.textBoxBuscarxNombre);
            this.groupBox4.Controls.Add(this.radioButtonNombre);
            this.groupBox4.Controls.Add(this.textBoxBuscarxMarca);
            this.groupBox4.Controls.Add(this.buttonBuscarxNombre);
            this.groupBox4.Controls.Add(this.buttonBuscarxMarca);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(791, 63);
            this.groupBox4.TabIndex = 111;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usted puede Buscar el Producto  por :  ";
            // 
            // radioButtonMarca
            // 
            this.radioButtonMarca.AutoSize = true;
            this.radioButtonMarca.Location = new System.Drawing.Point(216, 29);
            this.radioButtonMarca.Name = "radioButtonMarca";
            this.radioButtonMarca.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMarca.TabIndex = 4;
            this.radioButtonMarca.Text = "Marca";
            this.radioButtonMarca.UseVisualStyleBackColor = true;
            this.radioButtonMarca.Click += new System.EventHandler(this.radioButtonMarca_Click);
            // 
            // textBoxBuscarxNombre
            // 
            this.textBoxBuscarxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscarxNombre.Location = new System.Drawing.Point(281, 28);
            this.textBoxBuscarxNombre.Name = "textBoxBuscarxNombre";
            this.textBoxBuscarxNombre.Size = new System.Drawing.Size(317, 20);
            this.textBoxBuscarxNombre.TabIndex = 2;
            this.textBoxBuscarxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBuscarxNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBuscarxNombre_MouseClick);
            this.textBoxBuscarxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscarxNombre_KeyPress);
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Location = new System.Drawing.Point(141, 29);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(68, 17);
            this.radioButtonNombre.TabIndex = 1;
            this.radioButtonNombre.Text = "Nombre";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            this.radioButtonNombre.Click += new System.EventHandler(this.radioButtonNombre_Click);
            // 
            // textBoxBuscarxMarca
            // 
            this.textBoxBuscarxMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscarxMarca.Location = new System.Drawing.Point(281, 28);
            this.textBoxBuscarxMarca.Name = "textBoxBuscarxMarca";
            this.textBoxBuscarxMarca.Size = new System.Drawing.Size(317, 20);
            this.textBoxBuscarxMarca.TabIndex = 7;
            this.textBoxBuscarxMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBuscarxMarca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBuscarxMarca_MouseClick);
            this.textBoxBuscarxMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscarxMarca_KeyPress);
            // 
            // buttonBuscarxNombre
            // 
            this.buttonBuscarxNombre.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.buttonBuscarxNombre.FlatAppearance.BorderSize = 0;
            this.buttonBuscarxNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarxNombre.Location = new System.Drawing.Point(601, 28);
            this.buttonBuscarxNombre.Name = "buttonBuscarxNombre";
            this.buttonBuscarxNombre.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarxNombre.TabIndex = 8;
            this.buttonBuscarxNombre.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonBuscarxNombre.UseVisualStyleBackColor = true;
            this.buttonBuscarxNombre.Click += new System.EventHandler(this.buttonBuscarxNombre_Click);
            // 
            // buttonBuscarxMarca
            // 
            this.buttonBuscarxMarca.BackgroundImage = global::CapaPresentacion.Properties.Resources.lupa;
            this.buttonBuscarxMarca.FlatAppearance.BorderSize = 0;
            this.buttonBuscarxMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarxMarca.Location = new System.Drawing.Point(598, 28);
            this.buttonBuscarxMarca.Name = "buttonBuscarxMarca";
            this.buttonBuscarxMarca.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarxMarca.TabIndex = 9;
            this.buttonBuscarxMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonBuscarxMarca.UseVisualStyleBackColor = true;
            this.buttonBuscarxMarca.Click += new System.EventHandler(this.buttonBuscarxMarca_Click);
            // 
            // dataGridViewMantenimientoDeProducto
            // 
            this.dataGridViewMantenimientoDeProducto.AllowUserToAddRows = false;
            this.dataGridViewMantenimientoDeProducto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Chocolate;
            this.dataGridViewMantenimientoDeProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMantenimientoDeProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMantenimientoDeProducto.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMantenimientoDeProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMantenimientoDeProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMantenimientoDeProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMantenimientoDeProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUsuario_id,
            this.ColumnApellidoMaterno,
            this.Column4,
            this.ColumnApellidoPaterno,
            this.ColumnNombres,
            this.ColumnDireccion,
            this.Column1,
            this.Column2,
            this.ColumnFoto});
            this.dataGridViewMantenimientoDeProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMantenimientoDeProducto.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMantenimientoDeProducto.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewMantenimientoDeProducto.Location = new System.Drawing.Point(6, 4);
            this.dataGridViewMantenimientoDeProducto.MultiSelect = false;
            this.dataGridViewMantenimientoDeProducto.Name = "dataGridViewMantenimientoDeProducto";
            this.dataGridViewMantenimientoDeProducto.ReadOnly = true;
            this.dataGridViewMantenimientoDeProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMantenimientoDeProducto.Size = new System.Drawing.Size(776, 174);
            this.dataGridViewMantenimientoDeProducto.TabIndex = 77;
            this.dataGridViewMantenimientoDeProducto.DoubleClick += new System.EventHandler(this.dataGridViewMantenimientoDeProducto_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.dataGridViewMantenimientoDeProducto);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 224);
            this.panel1.TabIndex = 112;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.DimGray;
            this.labelTotal.Location = new System.Drawing.Point(405, 193);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(40, 13);
            this.labelTotal.TabIndex = 110;
            this.labelTotal.Text = "dsdsd";
            // 
            // ColumnUsuario_id
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnUsuario_id.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnUsuario_id.HeaderText = "IdProducto";
            this.ColumnUsuario_id.MinimumWidth = 20;
            this.ColumnUsuario_id.Name = "ColumnUsuario_id";
            this.ColumnUsuario_id.ReadOnly = true;
            this.ColumnUsuario_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnUsuario_id.Visible = false;
            // 
            // ColumnApellidoMaterno
            // 
            this.ColumnApellidoMaterno.HeaderText = "IdPresentacion";
            this.ColumnApellidoMaterno.Name = "ColumnApellidoMaterno";
            this.ColumnApellidoMaterno.ReadOnly = true;
            this.ColumnApellidoMaterno.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Presentacion";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ColumnApellidoPaterno
            // 
            this.ColumnApellidoPaterno.HeaderText = "IdCatedoria";
            this.ColumnApellidoPaterno.Name = "ColumnApellidoPaterno";
            this.ColumnApellidoPaterno.ReadOnly = true;
            this.ColumnApellidoPaterno.Visible = false;
            // 
            // ColumnNombres
            // 
            this.ColumnNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnNombres.HeaderText = "Nombre del Producto";
            this.ColumnNombres.Name = "ColumnNombres";
            this.ColumnNombres.ReadOnly = true;
            this.ColumnNombres.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNombres.Width = 253;
            // 
            // ColumnDireccion
            // 
            this.ColumnDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDireccion.HeaderText = "Marca del Producto";
            this.ColumnDireccion.Name = "ColumnDireccion";
            this.ColumnDireccion.ReadOnly = true;
            this.ColumnDireccion.Width = 185;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre de la Categoria";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "P. Compra";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // ColumnFoto
            // 
            this.ColumnFoto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnFoto.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnFoto.FillWeight = 24.36548F;
            this.ColumnFoto.HeaderText = "Foto";
            this.ColumnFoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnFoto.MinimumWidth = 20;
            this.ColumnFoto.Name = "ColumnFoto";
            this.ColumnFoto.ReadOnly = true;
            this.ColumnFoto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnFoto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnFoto.Width = 80;
            // 
            // frmVistaProductos_Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 317);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVistaProductos_Ingresos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVsitaProductos_Ingresos";
            this.Load += new System.EventHandler(this.frmVistaProductos_Ingresos_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMantenimientoDeProducto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonMarca;
        private System.Windows.Forms.TextBox textBoxBuscarxNombre;
        private System.Windows.Forms.RadioButton radioButtonNombre;
        private System.Windows.Forms.TextBox textBoxBuscarxMarca;
        private System.Windows.Forms.Button buttonBuscarxNombre;
        private System.Windows.Forms.Button buttonBuscarxMarca;
        public System.Windows.Forms.DataGridView dataGridViewMantenimientoDeProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn ColumnFoto;
    }
}