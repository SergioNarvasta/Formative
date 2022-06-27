namespace CapaPresentacion
{
    partial class frmListarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxBuscarxApellidos = new System.Windows.Forms.TextBox();
            this.dataGridViewMantenimientoDeEmpleado = new System.Windows.Forms.DataGridView();
            this.ColumnUsuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonApellidoPaterno = new System.Windows.Forms.RadioButton();
            this.radioButtonDni = new System.Windows.Forms.RadioButton();
            this.textBoxBuscarxDni = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMantenimientoDeEmpleado)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBuscarxApellidos);
            this.groupBox1.Controls.Add(this.dataGridViewMantenimientoDeEmpleado);
            this.groupBox1.Controls.Add(this.radioButtonApellidoPaterno);
            this.groupBox1.Controls.Add(this.radioButtonDni);
            this.groupBox1.Controls.Add(this.textBoxBuscarxDni);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(106, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 59);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Usted puede Buscar al Cliente por su :";
            // 
            // textBoxBuscarxApellidos
            // 
            this.textBoxBuscarxApellidos.Location = new System.Drawing.Point(206, 24);
            this.textBoxBuscarxApellidos.MaxLength = 25;
            this.textBoxBuscarxApellidos.Name = "textBoxBuscarxApellidos";
            this.textBoxBuscarxApellidos.Size = new System.Drawing.Size(365, 20);
            this.textBoxBuscarxApellidos.TabIndex = 76;
            this.textBoxBuscarxApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBuscarxApellidos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBuscarxApellidos_MouseClick);
            this.textBoxBuscarxApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscarxApellidos_KeyPress);
            // 
            // dataGridViewMantenimientoDeEmpleado
            // 
            this.dataGridViewMantenimientoDeEmpleado.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Tomato;
            this.dataGridViewMantenimientoDeEmpleado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMantenimientoDeEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMantenimientoDeEmpleado.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMantenimientoDeEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMantenimientoDeEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMantenimientoDeEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMantenimientoDeEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUsuario_id,
            this.ColumnApellidoPaterno,
            this.ColumnApellidoMaterno,
            this.ColumnNombres,
            this.ColumnDireccion,
            this.ColumnCelular,
            this.ColumnSexo,
            this.Column2,
            this.ColumnSueldo,
            this.ColumnNick,
            this.ColumnPassword,
            this.Column1,
            this.ColumnFoto,
            this.Column3});
            this.dataGridViewMantenimientoDeEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMantenimientoDeEmpleado.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMantenimientoDeEmpleado.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewMantenimientoDeEmpleado.Location = new System.Drawing.Point(-83, 71);
            this.dataGridViewMantenimientoDeEmpleado.MultiSelect = false;
            this.dataGridViewMantenimientoDeEmpleado.Name = "dataGridViewMantenimientoDeEmpleado";
            this.dataGridViewMantenimientoDeEmpleado.ReadOnly = true;
            this.dataGridViewMantenimientoDeEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMantenimientoDeEmpleado.Size = new System.Drawing.Size(769, 185);
            this.dataGridViewMantenimientoDeEmpleado.TabIndex = 75;
            // 
            // ColumnUsuario_id
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ColumnUsuario_id.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnUsuario_id.HeaderText = "Dni";
            this.ColumnUsuario_id.MinimumWidth = 20;
            this.ColumnUsuario_id.Name = "ColumnUsuario_id";
            this.ColumnUsuario_id.ReadOnly = true;
            this.ColumnUsuario_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnApellidoPaterno
            // 
            this.ColumnApellidoPaterno.HeaderText = "Apellido Paterno";
            this.ColumnApellidoPaterno.Name = "ColumnApellidoPaterno";
            this.ColumnApellidoPaterno.ReadOnly = true;
            // 
            // ColumnApellidoMaterno
            // 
            this.ColumnApellidoMaterno.HeaderText = "Apellido Materno";
            this.ColumnApellidoMaterno.Name = "ColumnApellidoMaterno";
            this.ColumnApellidoMaterno.ReadOnly = true;
            // 
            // ColumnNombres
            // 
            this.ColumnNombres.HeaderText = "Nombres";
            this.ColumnNombres.Name = "ColumnNombres";
            this.ColumnNombres.ReadOnly = true;
            // 
            // ColumnDireccion
            // 
            this.ColumnDireccion.HeaderText = "Direccion";
            this.ColumnDireccion.Name = "ColumnDireccion";
            this.ColumnDireccion.ReadOnly = true;
            this.ColumnDireccion.Visible = false;
            // 
            // ColumnCelular
            // 
            this.ColumnCelular.HeaderText = "Celular";
            this.ColumnCelular.Name = "ColumnCelular";
            this.ColumnCelular.ReadOnly = true;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            this.ColumnSexo.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Email";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ColumnSueldo
            // 
            this.ColumnSueldo.HeaderText = "Sueldo";
            this.ColumnSueldo.Name = "ColumnSueldo";
            this.ColumnSueldo.ReadOnly = true;
            this.ColumnSueldo.Visible = false;
            // 
            // ColumnNick
            // 
            this.ColumnNick.HeaderText = "Usuario";
            this.ColumnNick.Name = "ColumnNick";
            this.ColumnNick.ReadOnly = true;
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.HeaderText = "Password";
            this.ColumnPassword.Name = "ColumnPassword";
            this.ColumnPassword.ReadOnly = true;
            this.ColumnPassword.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo De Usuario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // ColumnFoto
            // 
            this.ColumnFoto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnFoto.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnFoto.HeaderText = "Foto";
            this.ColumnFoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnFoto.MinimumWidth = 20;
            this.ColumnFoto.Name = "ColumnFoto";
            this.ColumnFoto.ReadOnly = true;
            this.ColumnFoto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnFoto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sucursal";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // radioButtonApellidoPaterno
            // 
            this.radioButtonApellidoPaterno.AutoSize = true;
            this.radioButtonApellidoPaterno.ForeColor = System.Drawing.Color.Red;
            this.radioButtonApellidoPaterno.Location = new System.Drawing.Point(85, 27);
            this.radioButtonApellidoPaterno.Name = "radioButtonApellidoPaterno";
            this.radioButtonApellidoPaterno.Size = new System.Drawing.Size(67, 17);
            this.radioButtonApellidoPaterno.TabIndex = 16;
            this.radioButtonApellidoPaterno.Text = "Apellidos";
            this.radioButtonApellidoPaterno.UseVisualStyleBackColor = true;
            this.radioButtonApellidoPaterno.Click += new System.EventHandler(this.radioButtonApellidoPaterno_Click);
            // 
            // radioButtonDni
            // 
            this.radioButtonDni.AutoSize = true;
            this.radioButtonDni.Checked = true;
            this.radioButtonDni.ForeColor = System.Drawing.Color.Red;
            this.radioButtonDni.Location = new System.Drawing.Point(33, 27);
            this.radioButtonDni.Name = "radioButtonDni";
            this.radioButtonDni.Size = new System.Drawing.Size(41, 17);
            this.radioButtonDni.TabIndex = 15;
            this.radioButtonDni.TabStop = true;
            this.radioButtonDni.Text = "Dni";
            this.radioButtonDni.UseVisualStyleBackColor = true;
            this.radioButtonDni.Click += new System.EventHandler(this.radioButtonDni_Click);
            // 
            // textBoxBuscarxDni
            // 
            this.textBoxBuscarxDni.Location = new System.Drawing.Point(206, 24);
            this.textBoxBuscarxDni.MaxLength = 8;
            this.textBoxBuscarxDni.Name = "textBoxBuscarxDni";
            this.textBoxBuscarxDni.Size = new System.Drawing.Size(365, 20);
            this.textBoxBuscarxDni.TabIndex = 14;
            this.textBoxBuscarxDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBuscarxDni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBuscarxDni_MouseClick);
            this.textBoxBuscarxDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscarxDni_KeyPress);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.White;
            this.labelTotal.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTotal.Location = new System.Drawing.Point(646, 326);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(27, 13);
            this.labelTotal.TabIndex = 76;
            this.labelTotal.Text = "total";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridViewCliente);
            this.panel1.Location = new System.Drawing.Point(11, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 207);
            this.panel1.TabIndex = 77;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Tomato;
            this.dataGridViewCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCliente.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCliente.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewCliente.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewCliente.Location = new System.Drawing.Point(3, 1);
            this.dataGridViewCliente.MultiSelect = false;
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCliente.Size = new System.Drawing.Size(769, 179);
            this.dataGridViewCliente.TabIndex = 78;
            this.dataGridViewCliente.DoubleClick += new System.EventHandler(this.dataGridViewCliente_DoubleClick_1);
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn4.FillWeight = 85.27919F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Dni";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 8;
            this.dataGridViewTextBoxColumn4.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 85.27919F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 85.27919F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Sucursal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Location = new System.Drawing.Point(766, 9);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(24, 24);
            this.buttonCerrar.TabIndex = 78;
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // frmListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.ListadoClientes;
            this.ClientSize = new System.Drawing.Size(801, 353);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMantenimientoDeEmpleado)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonApellidoPaterno;
        private System.Windows.Forms.RadioButton radioButtonDni;
        private System.Windows.Forms.TextBox textBoxBuscarxDni;
        public System.Windows.Forms.DataGridView dataGridViewMantenimientoDeEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNick;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn ColumnFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCerrar;
        public System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox textBoxBuscarxApellidos;
    }
}