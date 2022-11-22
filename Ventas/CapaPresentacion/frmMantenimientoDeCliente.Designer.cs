namespace CapaPresentacion
{
    partial class frmMantenimientoDeCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoDeCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.pictureBoxLupa = new System.Windows.Forms.PictureBox();
            this.comboBoxSucursal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxCelular = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonBuscarxApellidos = new System.Windows.Forms.Button();
            this.textBoxBuscarxApellidos = new System.Windows.Forms.TextBox();
            this.buttonBuscarxDni = new System.Windows.Forms.Button();
            this.textBoxBuscarxDni = new System.Windows.Forms.TextBox();
            this.radioButtonApellidos = new System.Windows.Forms.RadioButton();
            this.radioButtonDni = new System.Windows.Forms.RadioButton();
            this.tabControlCliente = new System.Windows.Forms.TabControl();
            this.toolTipMensajes = new System.Windows.Forms.ToolTip(this.components);
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage2.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControlCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxDatos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento de Clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.pictureBoxLupa);
            this.groupBoxDatos.Controls.Add(this.comboBoxSucursal);
            this.groupBoxDatos.Controls.Add(this.label4);
            this.groupBoxDatos.Controls.Add(this.textBoxNombres);
            this.groupBoxDatos.Controls.Add(this.textBoxDni);
            this.groupBoxDatos.Controls.Add(this.label8);
            this.groupBoxDatos.Controls.Add(this.textBoxApellidos);
            this.groupBoxDatos.Controls.Add(this.textBoxCelular);
            this.groupBoxDatos.Controls.Add(this.textBoxDireccion);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Controls.Add(this.label1);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Location = new System.Drawing.Point(107, 16);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(590, 287);
            this.groupBoxDatos.TabIndex = 103;
            this.groupBoxDatos.TabStop = false;
            this.toolTipMensajes.SetToolTip(this.groupBoxDatos, "¡ojo!!! Todos los campos deben ser llenados");
            // 
            // pictureBoxLupa
            // 
            this.pictureBoxLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLupa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLupa.Image")));
            this.pictureBoxLupa.Location = new System.Drawing.Point(320, 21);
            this.pictureBoxLupa.Name = "pictureBoxLupa";
            this.pictureBoxLupa.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLupa.TabIndex = 121;
            this.pictureBoxLupa.TabStop = false;
            this.toolTipMensajes.SetToolTip(this.pictureBoxLupa, " ");
            this.pictureBoxLupa.Click += new System.EventHandler(this.pictureBoxLupa_Click);
            // 
            // comboBoxSucursal
            // 
            this.comboBoxSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSucursal.FormattingEnabled = true;
            this.comboBoxSucursal.Location = new System.Drawing.Point(218, 156);
            this.comboBoxSucursal.Name = "comboBoxSucursal";
            this.comboBoxSucursal.Size = new System.Drawing.Size(218, 21);
            this.comboBoxSucursal.TabIndex = 120;
            this.toolTipMensajes.SetToolTip(this.comboBoxSucursal, "Selecione en que tienda compra");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(103, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 118;
            this.label4.Text = "Compra realizada en :";
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(218, 75);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(218, 20);
            this.textBoxNombres.TabIndex = 105;
            this.toolTipMensajes.SetToolTip(this.textBoxNombres, "Digite los Nombres del cliente");
            this.textBoxNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombres_KeyPress);
            // 
            // textBoxDni
            // 
            this.textBoxDni.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxDni.Location = new System.Drawing.Point(218, 21);
            this.textBoxDni.MaxLength = 8;
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(99, 20);
            this.textBoxDni.TabIndex = 104;
            this.toolTipMensajes.SetToolTip(this.textBoxDni, "Digite el dni del cliente mas ENTER");
            this.textBoxDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDni_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(167, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 115;
            this.label8.Text = "Celular :";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(218, 48);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(218, 20);
            this.textBoxApellidos.TabIndex = 106;
            this.toolTipMensajes.SetToolTip(this.textBoxApellidos, "Digite los Apellidos completos del cliente");
            this.textBoxApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellidos_KeyPress);
            // 
            // textBoxCelular
            // 
            this.textBoxCelular.Location = new System.Drawing.Point(218, 102);
            this.textBoxCelular.MaxLength = 9;
            this.textBoxCelular.Name = "textBoxCelular";
            this.textBoxCelular.Size = new System.Drawing.Size(99, 20);
            this.textBoxCelular.TabIndex = 114;
            this.toolTipMensajes.SetToolTip(this.textBoxCelular, "Digite el nuemero de celular");
            this.textBoxCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCelular_KeyPress);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(218, 129);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(218, 20);
            this.textBoxDireccion.TabIndex = 109;
            this.toolTipMensajes.SetToolTip(this.textBoxDireccion, "Digite la direcion del cliente");
            this.textBoxDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDireccion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(183, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Dni :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(157, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 103;
            this.label5.Text = "Nombres :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(154, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "Direccion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(157, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Apellidos :";
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
            this.groupBox2.Location = new System.Drawing.Point(113, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 78);
            this.groupBox2.TabIndex = 105;
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
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.labelTotal);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.ForeColor = System.Drawing.Color.Red;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Listado de Clientes";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridViewCliente);
            this.panel1.Location = new System.Drawing.Point(13, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 206);
            this.panel1.TabIndex = 110;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            this.dataGridViewCliente.AllowUserToDeleteRows = false;
            this.dataGridViewCliente.AllowUserToResizeColumns = false;
            this.dataGridViewCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Chocolate;
            this.dataGridViewCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCliente.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.Column1});
            this.dataGridViewCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCliente.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewCliente.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewCliente.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCliente.MultiSelect = false;
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCliente.Size = new System.Drawing.Size(769, 179);
            this.dataGridViewCliente.TabIndex = 77;
            this.dataGridViewCliente.TabStop = false;
            this.toolTipMensajes.SetToolTip(this.dataGridViewCliente, "Doble clic en una fila para Modificar o Eliminar un registro");
            this.dataGridViewCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliente_CellClick);
            this.dataGridViewCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliente_CellContentClick);
            this.dataGridViewCliente.DoubleClick += new System.EventHandler(this.dataGridViewCliente_DoubleClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle11;
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
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Eliminar";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 77;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(646, 296);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 13);
            this.labelTotal.TabIndex = 109;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonBuscarxApellidos);
            this.groupBox4.Controls.Add(this.textBoxBuscarxApellidos);
            this.groupBox4.Controls.Add(this.buttonBuscarxDni);
            this.groupBox4.Controls.Add(this.textBoxBuscarxDni);
            this.groupBox4.Controls.Add(this.radioButtonApellidos);
            this.groupBox4.Controls.Add(this.radioButtonDni);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(17, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(769, 70);
            this.groupBox4.TabIndex = 76;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usted puede Buscar a los Clientes por su : ";
            this.toolTipMensajes.SetToolTip(this.groupBox4, "Puede Buscar a los Clientes por su");
            // 
            // buttonBuscarxApellidos
            // 
            this.buttonBuscarxApellidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarxApellidos.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarxApellidos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarxApellidos.Image")));
            this.buttonBuscarxApellidos.Location = new System.Drawing.Point(647, 29);
            this.buttonBuscarxApellidos.Name = "buttonBuscarxApellidos";
            this.buttonBuscarxApellidos.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarxApellidos.TabIndex = 5;
            this.buttonBuscarxApellidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipMensajes.SetToolTip(this.buttonBuscarxApellidos, "Para buscar clientes por apellidos o nombres");
            this.buttonBuscarxApellidos.UseVisualStyleBackColor = true;
            this.buttonBuscarxApellidos.Click += new System.EventHandler(this.buttonBuscarxApellidos_Click);
            // 
            // textBoxBuscarxApellidos
            // 
            this.textBoxBuscarxApellidos.Location = new System.Drawing.Point(259, 28);
            this.textBoxBuscarxApellidos.MaxLength = 25;
            this.textBoxBuscarxApellidos.Name = "textBoxBuscarxApellidos";
            this.textBoxBuscarxApellidos.Size = new System.Drawing.Size(385, 20);
            this.textBoxBuscarxApellidos.TabIndex = 4;
            this.textBoxBuscarxApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipMensajes.SetToolTip(this.textBoxBuscarxApellidos, "Digite el Apellido o el Nombre del Cliente a Buscar");
            this.textBoxBuscarxApellidos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBuscarxApellidos_MouseClick);
            this.textBoxBuscarxApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscarxApellidos_KeyPress);
            // 
            // buttonBuscarxDni
            // 
            this.buttonBuscarxDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarxDni.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarxDni.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarxDni.Image")));
            this.buttonBuscarxDni.Location = new System.Drawing.Point(647, 29);
            this.buttonBuscarxDni.Name = "buttonBuscarxDni";
            this.buttonBuscarxDni.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarxDni.TabIndex = 3;
            this.buttonBuscarxDni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipMensajes.SetToolTip(this.buttonBuscarxDni, "Para buscar clientes por su dni");
            this.buttonBuscarxDni.UseVisualStyleBackColor = true;
            this.buttonBuscarxDni.Click += new System.EventHandler(this.buttonBuscarxDni_Click);
            // 
            // textBoxBuscarxDni
            // 
            this.textBoxBuscarxDni.Location = new System.Drawing.Point(259, 28);
            this.textBoxBuscarxDni.MaxLength = 8;
            this.textBoxBuscarxDni.Name = "textBoxBuscarxDni";
            this.textBoxBuscarxDni.Size = new System.Drawing.Size(385, 20);
            this.textBoxBuscarxDni.TabIndex = 2;
            this.textBoxBuscarxDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipMensajes.SetToolTip(this.textBoxBuscarxDni, "Digite el Dni del Cliente a Buscar");
            this.textBoxBuscarxDni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBuscarxDni_MouseClick);
            this.textBoxBuscarxDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscarxDni_KeyPress);
            // 
            // radioButtonApellidos
            // 
            this.radioButtonApellidos.AutoSize = true;
            this.radioButtonApellidos.Location = new System.Drawing.Point(176, 28);
            this.radioButtonApellidos.Name = "radioButtonApellidos";
            this.radioButtonApellidos.Size = new System.Drawing.Size(76, 17);
            this.radioButtonApellidos.TabIndex = 1;
            this.radioButtonApellidos.TabStop = true;
            this.radioButtonApellidos.Text = "Apellidos";
            this.toolTipMensajes.SetToolTip(this.radioButtonApellidos, "Para buscar al cliente por sus Apellidos");
            this.radioButtonApellidos.UseVisualStyleBackColor = true;
            this.radioButtonApellidos.Click += new System.EventHandler(this.radioButtonApellidos_Click);
            // 
            // radioButtonDni
            // 
            this.radioButtonDni.AutoSize = true;
            this.radioButtonDni.Location = new System.Drawing.Point(112, 28);
            this.radioButtonDni.Name = "radioButtonDni";
            this.radioButtonDni.Size = new System.Drawing.Size(44, 17);
            this.radioButtonDni.TabIndex = 0;
            this.radioButtonDni.TabStop = true;
            this.radioButtonDni.Text = "Dni";
            this.toolTipMensajes.SetToolTip(this.radioButtonDni, "Para buscar al cliente por su Dni");
            this.radioButtonDni.UseVisualStyleBackColor = true;
            this.radioButtonDni.Click += new System.EventHandler(this.radioButtonDni_Click);
            // 
            // tabControlCliente
            // 
            this.tabControlCliente.Controls.Add(this.tabPage1);
            this.tabControlCliente.Controls.Add(this.tabPage2);
            this.tabControlCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlCliente.Location = new System.Drawing.Point(2, 3);
            this.tabControlCliente.Name = "tabControlCliente";
            this.tabControlCliente.SelectedIndex = 0;
            this.tabControlCliente.Size = new System.Drawing.Size(811, 342);
            this.tabControlCliente.TabIndex = 104;
            this.tabControlCliente.SelectedIndexChanged += new System.EventHandler(this.tabControlCliente_SelectedIndexChanged);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmMantenimientoDeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControlCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMantenimientoDeCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Mantenimiento de los Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.tabPage2.ResumeLayout(false);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLupa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControlCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.PictureBox pictureBoxLupa;
        private System.Windows.Forms.ComboBox comboBoxSucursal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxCelular;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonBuscarxDni;
        private System.Windows.Forms.TextBox textBoxBuscarxDni;
        private System.Windows.Forms.RadioButton radioButtonApellidos;
        private System.Windows.Forms.RadioButton radioButtonDni;
        private System.Windows.Forms.TabControl tabControlCliente;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.ToolTip toolTipMensajes;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox textBoxBuscarxApellidos;
        private System.Windows.Forms.Button buttonBuscarxApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}