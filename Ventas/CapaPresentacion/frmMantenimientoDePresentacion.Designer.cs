namespace CapaPresentacion
{
    partial class frmMantenimientoDePresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoDePresentacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxDscripcion = new System.Windows.Forms.RichTextBox();
            this.pictureBoxLupa = new System.Windows.Forms.PictureBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipMensajes = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewMantenimientoDePresentacion = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonBuscarxNombre = new System.Windows.Forms.Button();
            this.textBoxBuscarxNombre = new System.Windows.Forms.TextBox();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.tabPageListado = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCodigo2 = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.tabPageMantenimiento = new System.Windows.Forms.TabPage();
            this.tabControlPresentacion = new System.Windows.Forms.TabControl();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMantenimientoDePresentacion)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageListado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageMantenimiento.SuspendLayout();
            this.tabControlPresentacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.label1);
            this.groupBoxDatos.Controls.Add(this.richTextBoxDscripcion);
            this.groupBoxDatos.Controls.Add(this.pictureBoxLupa);
            this.groupBoxDatos.Controls.Add(this.textBoxCodigo);
            this.groupBoxDatos.Controls.Add(this.textBoxNombre);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Location = new System.Drawing.Point(25, 15);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(590, 287);
            this.groupBoxDatos.TabIndex = 103;
            this.groupBoxDatos.TabStop = false;
            this.toolTipMensajes.SetToolTip(this.groupBoxDatos, "¡ojo!!! Todos los campos deben ser llenados");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(52, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "Descripcion de la Presentacion :";
            // 
            // richTextBoxDscripcion
            // 
            this.richTextBoxDscripcion.Location = new System.Drawing.Point(218, 126);
            this.richTextBoxDscripcion.MaxLength = 40;
            this.richTextBoxDscripcion.Name = "richTextBoxDscripcion";
            this.richTextBoxDscripcion.Size = new System.Drawing.Size(239, 74);
            this.richTextBoxDscripcion.TabIndex = 122;
            this.richTextBoxDscripcion.Text = "";
            this.toolTipMensajes.SetToolTip(this.richTextBoxDscripcion, "Solo se permiten 40 carateres");
            this.richTextBoxDscripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxDscripcion_KeyPress);
            // 
            // pictureBoxLupa
            // 
            this.pictureBoxLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLupa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLupa.Image")));
            this.pictureBoxLupa.Location = new System.Drawing.Point(437, 99);
            this.pictureBoxLupa.Name = "pictureBoxLupa";
            this.pictureBoxLupa.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLupa.TabIndex = 121;
            this.pictureBoxLupa.TabStop = false;
            this.toolTipMensajes.SetToolTip(this.pictureBoxLupa, " Clic para buscar");
            this.pictureBoxLupa.Click += new System.EventHandler(this.pictureBoxLupa_Click);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxCodigo.Location = new System.Drawing.Point(218, 66);
            this.textBoxCodigo.MaxLength = 8;
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(64, 20);
            this.textBoxCodigo.TabIndex = 104;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(218, 99);
            this.textBoxNombre.MaxLength = 50;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(218, 20);
            this.textBoxNombre.TabIndex = 106;
            this.toolTipMensajes.SetToolTip(this.textBoxNombre, "Digite el nombre de la presentacion mas ENTER");
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(166, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Codigo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(71, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Nombre de la Presentacion :";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // dataGridViewMantenimientoDePresentacion
            // 
            this.dataGridViewMantenimientoDePresentacion.AllowUserToAddRows = false;
            this.dataGridViewMantenimientoDePresentacion.AllowUserToDeleteRows = false;
            this.dataGridViewMantenimientoDePresentacion.AllowUserToResizeColumns = false;
            this.dataGridViewMantenimientoDePresentacion.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Chocolate;
            this.dataGridViewMantenimientoDePresentacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMantenimientoDePresentacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMantenimientoDePresentacion.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMantenimientoDePresentacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMantenimientoDePresentacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMantenimientoDePresentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMantenimientoDePresentacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.Column1});
            this.dataGridViewMantenimientoDePresentacion.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMantenimientoDePresentacion.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMantenimientoDePresentacion.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewMantenimientoDePresentacion.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMantenimientoDePresentacion.MultiSelect = false;
            this.dataGridViewMantenimientoDePresentacion.Name = "dataGridViewMantenimientoDePresentacion";
            this.dataGridViewMantenimientoDePresentacion.ReadOnly = true;
            this.dataGridViewMantenimientoDePresentacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMantenimientoDePresentacion.Size = new System.Drawing.Size(600, 179);
            this.dataGridViewMantenimientoDePresentacion.TabIndex = 77;
            this.dataGridViewMantenimientoDePresentacion.TabStop = false;
            this.toolTipMensajes.SetToolTip(this.dataGridViewMantenimientoDePresentacion, "Doble clic en una fila para Modificar o Eliminar un registro");
            this.dataGridViewMantenimientoDePresentacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMantenimientoDePresentacion_CellClick);
            this.dataGridViewMantenimientoDePresentacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMantenimientoDePresentacion_CellContentClick);
            this.dataGridViewMantenimientoDePresentacion.DoubleClick += new System.EventHandler(this.dataGridViewMantenimientoDePresentacion_DoubleClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.FillWeight = 85.27919F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 1;
            this.dataGridViewTextBoxColumn4.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre de la Presentacion";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.FillWeight = 85.27919F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripcion de la Presentacion";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 237;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Eliminar";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 67;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonBuscarxNombre);
            this.groupBox4.Controls.Add(this.textBoxBuscarxNombre);
            this.groupBox4.Controls.Add(this.radioButtonNombre);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(17, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(604, 70);
            this.groupBox4.TabIndex = 76;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usted puede Buscar la Presentacion por su :";
            this.toolTipMensajes.SetToolTip(this.groupBox4, "Puede Buscar a Horario del Empleado");
            // 
            // buttonBuscarxNombre
            // 
            this.buttonBuscarxNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarxNombre.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarxNombre.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarxNombre.Image")));
            this.buttonBuscarxNombre.Location = new System.Drawing.Point(525, 29);
            this.buttonBuscarxNombre.Name = "buttonBuscarxNombre";
            this.buttonBuscarxNombre.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarxNombre.TabIndex = 5;
            this.buttonBuscarxNombre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipMensajes.SetToolTip(this.buttonBuscarxNombre, "Para buscar clientes por apellidos o nombres");
            this.buttonBuscarxNombre.UseVisualStyleBackColor = true;
            this.buttonBuscarxNombre.Click += new System.EventHandler(this.buttonBuscarxNombre_Click);
            // 
            // textBoxBuscarxNombre
            // 
            this.textBoxBuscarxNombre.Location = new System.Drawing.Point(137, 28);
            this.textBoxBuscarxNombre.MaxLength = 100;
            this.textBoxBuscarxNombre.Name = "textBoxBuscarxNombre";
            this.textBoxBuscarxNombre.Size = new System.Drawing.Size(385, 20);
            this.textBoxBuscarxNombre.TabIndex = 4;
            this.textBoxBuscarxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipMensajes.SetToolTip(this.textBoxBuscarxNombre, "Digite el nombre de la presentacion a Buscar");
            this.textBoxBuscarxNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBuscarxNombre_MouseClick);
            this.textBoxBuscarxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscarxNombre_KeyPress);
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Location = new System.Drawing.Point(50, 29);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(68, 17);
            this.radioButtonNombre.TabIndex = 0;
            this.radioButtonNombre.TabStop = true;
            this.radioButtonNombre.Text = "Nombre";
            this.toolTipMensajes.SetToolTip(this.radioButtonNombre, "Para buscar la Presentacion del producto ");
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            this.radioButtonNombre.Click += new System.EventHandler(this.radioButtonNombre_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonImprimir);
            this.groupBox2.Controls.Add(this.buttonEliminar);
            this.groupBox2.Controls.Add(this.buttonCancelar);
            this.groupBox2.Controls.Add(this.buttonEditar);
            this.groupBox2.Controls.Add(this.buttonGuardar);
            this.groupBox2.Controls.Add(this.buttonNuevo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(31, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 78);
            this.groupBox2.TabIndex = 109;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones : ";
            this.toolTipMensajes.SetToolTip(this.groupBox2, "Seleccione una accion");
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.White;
            this.buttonImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonImprimir.BackgroundImage")));
            this.buttonImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimir.ForeColor = System.Drawing.Color.Red;
            this.buttonImprimir.Location = new System.Drawing.Point(480, 20);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(54, 44);
            this.buttonImprimir.TabIndex = 110;
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.White;
            this.buttonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.BackgroundImage")));
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.Red;
            this.buttonEliminar.Location = new System.Drawing.Point(312, 19);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(54, 44);
            this.buttonEliminar.TabIndex = 109;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.BackgroundImage")));
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.Red;
            this.buttonCancelar.Location = new System.Drawing.Point(396, 20);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(54, 44);
            this.buttonCancelar.TabIndex = 107;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.White;
            this.buttonEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditar.BackgroundImage")));
            this.buttonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.Red;
            this.buttonEditar.Location = new System.Drawing.Point(228, 20);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(54, 44);
            this.buttonEditar.TabIndex = 105;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.White;
            this.buttonGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.BackgroundImage")));
            this.buttonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.Red;
            this.buttonGuardar.Location = new System.Drawing.Point(144, 19);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(54, 44);
            this.buttonGuardar.TabIndex = 104;
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.BackColor = System.Drawing.Color.White;
            this.buttonNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNuevo.BackgroundImage")));
            this.buttonNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.ForeColor = System.Drawing.Color.Red;
            this.buttonNuevo.Location = new System.Drawing.Point(60, 20);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(54, 44);
            this.buttonNuevo.TabIndex = 103;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // tabPageListado
            // 
            this.tabPageListado.BackColor = System.Drawing.Color.White;
            this.tabPageListado.Controls.Add(this.panel1);
            this.tabPageListado.Controls.Add(this.labelTotal);
            this.tabPageListado.Controls.Add(this.groupBox4);
            this.tabPageListado.ForeColor = System.Drawing.Color.Red;
            this.tabPageListado.Location = new System.Drawing.Point(4, 22);
            this.tabPageListado.Name = "tabPageListado";
            this.tabPageListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListado.Size = new System.Drawing.Size(637, 316);
            this.tabPageListado.TabIndex = 0;
            this.tabPageListado.Text = " Listado de Presentacion";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridViewMantenimientoDePresentacion);
            this.panel1.Controls.Add(this.textBoxCodigo2);
            this.panel1.Location = new System.Drawing.Point(13, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 206);
            this.panel1.TabIndex = 110;
            // 
            // textBoxCodigo2
            // 
            this.textBoxCodigo2.Location = new System.Drawing.Point(45, 3);
            this.textBoxCodigo2.Name = "textBoxCodigo2";
            this.textBoxCodigo2.Size = new System.Drawing.Size(55, 20);
            this.textBoxCodigo2.TabIndex = 111;
            this.textBoxCodigo2.Visible = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(452, 297);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(13, 13);
            this.labelTotal.TabIndex = 109;
            this.labelTotal.Text = "b";
            // 
            // tabPageMantenimiento
            // 
            this.tabPageMantenimiento.Controls.Add(this.groupBoxDatos);
            this.tabPageMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabPageMantenimiento.Name = "tabPageMantenimiento";
            this.tabPageMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMantenimiento.Size = new System.Drawing.Size(637, 316);
            this.tabPageMantenimiento.TabIndex = 1;
            this.tabPageMantenimiento.Text = "Mantenimiento de Presentacion";
            this.tabPageMantenimiento.UseVisualStyleBackColor = true;
            // 
            // tabControlPresentacion
            // 
            this.tabControlPresentacion.Controls.Add(this.tabPageListado);
            this.tabControlPresentacion.Controls.Add(this.tabPageMantenimiento);
            this.tabControlPresentacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlPresentacion.Location = new System.Drawing.Point(3, 3);
            this.tabControlPresentacion.Name = "tabControlPresentacion";
            this.tabControlPresentacion.SelectedIndex = 0;
            this.tabControlPresentacion.Size = new System.Drawing.Size(645, 342);
            this.tabControlPresentacion.TabIndex = 108;
            this.tabControlPresentacion.SelectedIndexChanged += new System.EventHandler(this.tabControlPresentacion_SelectedIndexChanged);
            // 
            // frmMantenimientoDePresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 434);
            this.Controls.Add(this.tabControlPresentacion);
            this.Controls.Add(this.groupBox2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMantenimientoDePresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Mantenimiento De Presentcion";
            this.Load += new System.EventHandler(this.frmMantenimientoDePresentacion_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMantenimientoDePresentacion)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPageListado.ResumeLayout(false);
            this.tabPageListado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageMantenimiento.ResumeLayout(false);
            this.tabControlPresentacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.PictureBox pictureBoxLupa;
        private System.Windows.Forms.ToolTip toolTipMensajes;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TabControl tabControlPresentacion;
        private System.Windows.Forms.TabPage tabPageListado;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridViewMantenimientoDePresentacion;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonBuscarxNombre;
        private System.Windows.Forms.TextBox textBoxBuscarxNombre;
        private System.Windows.Forms.RadioButton radioButtonNombre;
        private System.Windows.Forms.TabPage tabPageMantenimiento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDscripcion;
        private System.Windows.Forms.TextBox textBoxCodigo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}