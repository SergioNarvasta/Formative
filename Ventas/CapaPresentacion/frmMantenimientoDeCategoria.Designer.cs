namespace CapaPresentacion
{
    partial class frmMantenimientoDeCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoDeCategoria));
            this.tabPageListado = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMantenimientoDeCategoria = new System.Windows.Forms.DataGridView();
            this.ColumnApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonBuscarxNombre = new System.Windows.Forms.Button();
            this.textBoxBuscarxNombre = new System.Windows.Forms.TextBox();
            this.buttonBuscarxCodigo = new System.Windows.Forms.Button();
            this.textBoxBuscarxCodigo = new System.Windows.Forms.TextBox();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.tabControlCategoria = new System.Windows.Forms.TabControl();
            this.tabPageMantenimiento = new System.Windows.Forms.TabPage();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.pictureBoxLupa = new System.Windows.Forms.PictureBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipMensajes = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.tabPageListado.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMantenimientoDeCategoria)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControlCategoria.SuspendLayout();
            this.tabPageMantenimiento.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.tabPageListado.Size = new System.Drawing.Size(803, 279);
            this.tabPageListado.TabIndex = 0;
            this.tabPageListado.Text = " Listado de Categorias";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridViewMantenimientoDeCategoria);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 171);
            this.panel1.TabIndex = 110;
            // 
            // dataGridViewMantenimientoDeCategoria
            // 
            this.dataGridViewMantenimientoDeCategoria.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Chocolate;
            this.dataGridViewMantenimientoDeCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMantenimientoDeCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMantenimientoDeCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMantenimientoDeCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMantenimientoDeCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMantenimientoDeCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMantenimientoDeCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnApellidoPaterno,
            this.ColumnNombres,
            this.Column1});
            this.dataGridViewMantenimientoDeCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMantenimientoDeCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMantenimientoDeCategoria.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewMantenimientoDeCategoria.Location = new System.Drawing.Point(4, 3);
            this.dataGridViewMantenimientoDeCategoria.MultiSelect = false;
            this.dataGridViewMantenimientoDeCategoria.Name = "dataGridViewMantenimientoDeCategoria";
            this.dataGridViewMantenimientoDeCategoria.ReadOnly = true;
            this.dataGridViewMantenimientoDeCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMantenimientoDeCategoria.Size = new System.Drawing.Size(774, 147);
            this.dataGridViewMantenimientoDeCategoria.TabIndex = 77;
            this.toolTipMensajes.SetToolTip(this.dataGridViewMantenimientoDeCategoria, "Listado de todas las categorias registradas");
            this.dataGridViewMantenimientoDeCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMantenimientoDeCategoria_CellClick);
            this.dataGridViewMantenimientoDeCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMantenimientoDeCategoria_CellContentClick);
            this.dataGridViewMantenimientoDeCategoria.DoubleClick += new System.EventHandler(this.dataGridViewMantenimientoDeCategoria_DoubleClick);
            // 
            // ColumnApellidoPaterno
            // 
            this.ColumnApellidoPaterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnApellidoPaterno.HeaderText = "Codigo";
            this.ColumnApellidoPaterno.Name = "ColumnApellidoPaterno";
            this.ColumnApellidoPaterno.ReadOnly = true;
            // 
            // ColumnNombres
            // 
            this.ColumnNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnNombres.HeaderText = "Nombre de la Categoria";
            this.ColumnNombres.Name = "ColumnNombres";
            this.ColumnNombres.ReadOnly = true;
            this.ColumnNombres.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNombres.Width = 567;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Eliminar";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 65;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(646, 259);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 13);
            this.labelTotal.TabIndex = 109;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonBuscarxNombre);
            this.groupBox4.Controls.Add(this.textBoxBuscarxNombre);
            this.groupBox4.Controls.Add(this.buttonBuscarxCodigo);
            this.groupBox4.Controls.Add(this.textBoxBuscarxCodigo);
            this.groupBox4.Controls.Add(this.radioButtonNombre);
            this.groupBox4.Controls.Add(this.radioButtonCodigo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(780, 70);
            this.groupBox4.TabIndex = 76;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usted puede Buscar a los Categorias  por su : ";
            this.toolTipMensajes.SetToolTip(this.groupBox4, "Puede Buscar a los Categorias por su");
            // 
            // buttonBuscarxNombre
            // 
            this.buttonBuscarxNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarxNombre.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarxNombre.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarxNombre.Image")));
            this.buttonBuscarxNombre.Location = new System.Drawing.Point(647, 29);
            this.buttonBuscarxNombre.Name = "buttonBuscarxNombre";
            this.buttonBuscarxNombre.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarxNombre.TabIndex = 5;
            this.buttonBuscarxNombre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipMensajes.SetToolTip(this.buttonBuscarxNombre, "Para buscar categorias por Nombres");
            this.buttonBuscarxNombre.UseVisualStyleBackColor = true;
            this.buttonBuscarxNombre.Click += new System.EventHandler(this.buttonBuscarxNombre_Click);
            // 
            // textBoxBuscarxNombre
            // 
            this.textBoxBuscarxNombre.Location = new System.Drawing.Point(259, 28);
            this.textBoxBuscarxNombre.MaxLength = 25;
            this.textBoxBuscarxNombre.Name = "textBoxBuscarxNombre";
            this.textBoxBuscarxNombre.Size = new System.Drawing.Size(385, 20);
            this.textBoxBuscarxNombre.TabIndex = 4;
            this.textBoxBuscarxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipMensajes.SetToolTip(this.textBoxBuscarxNombre, "Digite el Nombre del Categoria a Buscar");
            this.textBoxBuscarxNombre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBuscarxNombre_MouseClick);
            this.textBoxBuscarxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscarxNombre_KeyPress);
            // 
            // buttonBuscarxCodigo
            // 
            this.buttonBuscarxCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarxCodigo.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarxCodigo.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarxCodigo.Image")));
            this.buttonBuscarxCodigo.Location = new System.Drawing.Point(647, 29);
            this.buttonBuscarxCodigo.Name = "buttonBuscarxCodigo";
            this.buttonBuscarxCodigo.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarxCodigo.TabIndex = 3;
            this.buttonBuscarxCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipMensajes.SetToolTip(this.buttonBuscarxCodigo, "Para buscar Categorias por Codigos");
            this.buttonBuscarxCodigo.UseVisualStyleBackColor = true;
            this.buttonBuscarxCodigo.Click += new System.EventHandler(this.buttonBuscarxCodigo_Click);
            // 
            // textBoxBuscarxCodigo
            // 
            this.textBoxBuscarxCodigo.Location = new System.Drawing.Point(259, 28);
            this.textBoxBuscarxCodigo.MaxLength = 8;
            this.textBoxBuscarxCodigo.Name = "textBoxBuscarxCodigo";
            this.textBoxBuscarxCodigo.Size = new System.Drawing.Size(385, 20);
            this.textBoxBuscarxCodigo.TabIndex = 2;
            this.textBoxBuscarxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipMensajes.SetToolTip(this.textBoxBuscarxCodigo, "Digite el Codigo de la Categoria a Buscar");
            this.textBoxBuscarxCodigo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBuscarxCodigo_MouseClick);
            this.textBoxBuscarxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscarxCodigo_KeyPress);
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Location = new System.Drawing.Point(180, 29);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(68, 17);
            this.radioButtonNombre.TabIndex = 1;
            this.radioButtonNombre.TabStop = true;
            this.radioButtonNombre.Text = "Nombre";
            this.toolTipMensajes.SetToolTip(this.radioButtonNombre, "Para buscar la categoria por su nombre");
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            this.radioButtonNombre.Click += new System.EventHandler(this.radioButtonNombre_Click);
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(112, 29);
            this.radioButtonCodigo.Name = "radioButtonCodigo";
            this.radioButtonCodigo.Size = new System.Drawing.Size(64, 17);
            this.radioButtonCodigo.TabIndex = 0;
            this.radioButtonCodigo.TabStop = true;
            this.radioButtonCodigo.Text = "Codigo";
            this.toolTipMensajes.SetToolTip(this.radioButtonCodigo, "Para buscar la categoria por su codigo");
            this.radioButtonCodigo.UseVisualStyleBackColor = true;
            this.radioButtonCodigo.Click += new System.EventHandler(this.radioButtonCodigo_Click);
            // 
            // tabControlCategoria
            // 
            this.tabControlCategoria.Controls.Add(this.tabPageListado);
            this.tabControlCategoria.Controls.Add(this.tabPageMantenimiento);
            this.tabControlCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlCategoria.Location = new System.Drawing.Point(3, 2);
            this.tabControlCategoria.Name = "tabControlCategoria";
            this.tabControlCategoria.SelectedIndex = 0;
            this.tabControlCategoria.Size = new System.Drawing.Size(811, 305);
            this.tabControlCategoria.TabIndex = 106;
            this.tabControlCategoria.SelectedIndexChanged += new System.EventHandler(this.tabControlCategoria_SelectedIndexChanged);
            // 
            // tabPageMantenimiento
            // 
            this.tabPageMantenimiento.Controls.Add(this.groupBoxDatos);
            this.tabPageMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabPageMantenimiento.Name = "tabPageMantenimiento";
            this.tabPageMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMantenimiento.Size = new System.Drawing.Size(803, 279);
            this.tabPageMantenimiento.TabIndex = 1;
            this.tabPageMantenimiento.Text = "Mantenimiento de Categorias";
            this.tabPageMantenimiento.UseVisualStyleBackColor = true;
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.pictureBoxLupa);
            this.groupBoxDatos.Controls.Add(this.textBoxCodigo);
            this.groupBoxDatos.Controls.Add(this.textBoxNombre);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Location = new System.Drawing.Point(109, 90);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(590, 86);
            this.groupBoxDatos.TabIndex = 103;
            this.groupBoxDatos.TabStop = false;
            this.toolTipMensajes.SetToolTip(this.groupBoxDatos, "¡ojo!!! Todos los campos deben ser llenados");
            // 
            // pictureBoxLupa
            // 
            this.pictureBoxLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLupa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLupa.Image")));
            this.pictureBoxLupa.Location = new System.Drawing.Point(437, 47);
            this.pictureBoxLupa.Name = "pictureBoxLupa";
            this.pictureBoxLupa.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLupa.TabIndex = 121;
            this.pictureBoxLupa.TabStop = false;
            this.toolTipMensajes.SetToolTip(this.pictureBoxLupa, " Clic para buscar");
            this.pictureBoxLupa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLupa_MouseClick);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxCodigo.Location = new System.Drawing.Point(218, 21);
            this.textBoxCodigo.MaxLength = 8;
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(99, 20);
            this.textBoxCodigo.TabIndex = 104;
            this.toolTipMensajes.SetToolTip(this.textBoxCodigo, "Digite el dni del cliente mas ENTER");
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(218, 48);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(218, 20);
            this.textBoxNombre.TabIndex = 106;
            this.toolTipMensajes.SetToolTip(this.textBoxNombre, "Digite el Nombre de la Categoria");
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(166, 25);
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
            this.label3.Location = new System.Drawing.Point(88, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Nombre de la Categoria :";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonImprimir);
            this.groupBox2.Controls.Add(this.buttonEliminar);
            this.groupBox2.Controls.Add(this.buttonCancelar);
            this.groupBox2.Controls.Add(this.buttonModificar);
            this.groupBox2.Controls.Add(this.buttonGuardar);
            this.groupBox2.Controls.Add(this.buttonNuevo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(120, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 78);
            this.groupBox2.TabIndex = 107;
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
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.White;
            this.buttonModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonModificar.BackgroundImage")));
            this.buttonModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.Color.Red;
            this.buttonModificar.Location = new System.Drawing.Point(228, 20);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(54, 44);
            this.buttonModificar.TabIndex = 105;
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
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
            // frmMantenimientoDeCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 397);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControlCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMantenimientoDeCategoria";
            this.Text = "Formulario Mantenimiento De Las Categorias";
            this.Load += new System.EventHandler(this.frmMantenimientoDeCategoria_Load);
            this.tabPageListado.ResumeLayout(false);
            this.tabPageListado.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMantenimientoDeCategoria)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControlCategoria.ResumeLayout(false);
            this.tabPageMantenimiento.ResumeLayout(false);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageListado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTipMensajes;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonBuscarxNombre;
        private System.Windows.Forms.TextBox textBoxBuscarxNombre;
        private System.Windows.Forms.Button buttonBuscarxCodigo;
        private System.Windows.Forms.TextBox textBoxBuscarxCodigo;
        private System.Windows.Forms.RadioButton radioButtonNombre;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.TabControl tabControlCategoria;
        private System.Windows.Forms.TabPage tabPageMantenimiento;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.PictureBox pictureBoxLupa;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        public System.Windows.Forms.DataGridView dataGridViewMantenimientoDeCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombres;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}