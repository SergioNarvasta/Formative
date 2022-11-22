namespace CapaPresentacion
{
    partial class frmMantenimientoDeHorario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoDeHorario));
            this.tabPageListado = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewHorario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonBuscarxApellidos = new System.Windows.Forms.Button();
            this.textBoxBuscarxApellidos = new System.Windows.Forms.TextBox();
            this.radioButtonEmpleado = new System.Windows.Forms.RadioButton();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.tabControlHorario = new System.Windows.Forms.TabControl();
            this.tabPageMantenimiento = new System.Windows.Forms.TabPage();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHEntrada = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTurno = new System.Windows.Forms.TextBox();
            this.textBoxHSalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTipMensajes = new System.Windows.Forms.ToolTip(this.components);
            this.tabPageListado.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorario)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControlHorario.SuspendLayout();
            this.tabPageMantenimiento.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
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
            this.tabPageListado.Size = new System.Drawing.Size(803, 316);
            this.tabPageListado.TabIndex = 0;
            this.tabPageListado.Text = " Listado de Horario";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridViewHorario);
            this.panel1.Location = new System.Drawing.Point(13, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 206);
            this.panel1.TabIndex = 110;
            // 
            // dataGridViewHorario
            // 
            this.dataGridViewHorario.AllowUserToAddRows = false;
            this.dataGridViewHorario.AllowUserToDeleteRows = false;
            this.dataGridViewHorario.AllowUserToResizeColumns = false;
            this.dataGridViewHorario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Chocolate;
            this.dataGridViewHorario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHorario.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.Column2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7});
            this.dataGridViewHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHorario.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewHorario.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewHorario.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewHorario.MultiSelect = false;
            this.dataGridViewHorario.Name = "dataGridViewHorario";
            this.dataGridViewHorario.ReadOnly = true;
            this.dataGridViewHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHorario.Size = new System.Drawing.Size(769, 179);
            this.dataGridViewHorario.TabIndex = 77;
            this.dataGridViewHorario.TabStop = false;
            this.toolTipMensajes.SetToolTip(this.dataGridViewHorario, "Doble clic en una fila para Modificar o Eliminar un registro");
            this.dataGridViewHorario.DoubleClick += new System.EventHandler(this.dataGridViewHorario_DoubleClick);
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
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 55;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "IdEmpleado";
            this.Column1.MaxInputLength = 8;
            this.Column1.MinimumWidth = 20;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Empleado";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 308;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cargo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.FillWeight = 85.27919F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Turno";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.FillWeight = 85.27919F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Hora de Entrada";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.HeaderText = "Hora de Salida";
            this.dataGridViewTextBoxColumn7.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 160;
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
            this.groupBox4.Controls.Add(this.radioButtonEmpleado);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(17, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(769, 70);
            this.groupBox4.TabIndex = 76;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usted puede Buscar el Horario por :";
            this.toolTipMensajes.SetToolTip(this.groupBox4, "Puede Buscar a Horario del Empleado");
            // 
            // buttonBuscarxApellidos
            // 
            this.buttonBuscarxApellidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarxApellidos.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarxApellidos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarxApellidos.Image")));
            this.buttonBuscarxApellidos.Location = new System.Drawing.Point(607, 29);
            this.buttonBuscarxApellidos.Name = "buttonBuscarxApellidos";
            this.buttonBuscarxApellidos.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscarxApellidos.TabIndex = 5;
            this.buttonBuscarxApellidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipMensajes.SetToolTip(this.buttonBuscarxApellidos, "Para buscar Empleados  por apellidos o nombres");
            this.buttonBuscarxApellidos.UseVisualStyleBackColor = true;
            this.buttonBuscarxApellidos.Click += new System.EventHandler(this.buttonBuscarxApellidos_Click);
            // 
            // textBoxBuscarxApellidos
            // 
            this.textBoxBuscarxApellidos.Location = new System.Drawing.Point(219, 28);
            this.textBoxBuscarxApellidos.MaxLength = 100;
            this.textBoxBuscarxApellidos.Name = "textBoxBuscarxApellidos";
            this.textBoxBuscarxApellidos.Size = new System.Drawing.Size(385, 20);
            this.textBoxBuscarxApellidos.TabIndex = 4;
            this.textBoxBuscarxApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipMensajes.SetToolTip(this.textBoxBuscarxApellidos, "Digite el Apellido o el Nombre del Empleado a Buscar");
            this.textBoxBuscarxApellidos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBuscarxApellidos_MouseClick);
            this.textBoxBuscarxApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscarxApellidos_KeyPress);
            // 
            // radioButtonEmpleado
            // 
            this.radioButtonEmpleado.AutoSize = true;
            this.radioButtonEmpleado.Location = new System.Drawing.Point(132, 29);
            this.radioButtonEmpleado.Name = "radioButtonEmpleado";
            this.radioButtonEmpleado.Size = new System.Drawing.Size(80, 17);
            this.radioButtonEmpleado.TabIndex = 0;
            this.radioButtonEmpleado.TabStop = true;
            this.radioButtonEmpleado.Text = "Empleado";
            this.toolTipMensajes.SetToolTip(this.radioButtonEmpleado, "Para buscar el Horario por Empleado");
            this.radioButtonEmpleado.UseVisualStyleBackColor = true;
            this.radioButtonEmpleado.Click += new System.EventHandler(this.radioButtonEmpleado_Click);
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
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.Red;
            this.buttonEliminar.Location = new System.Drawing.Point(312, 19);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(54, 44);
            this.buttonEliminar.TabIndex = 109;
            this.buttonEliminar.UseVisualStyleBackColor = false;
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
            // tabControlHorario
            // 
            this.tabControlHorario.Controls.Add(this.tabPageListado);
            this.tabControlHorario.Controls.Add(this.tabPageMantenimiento);
            this.tabControlHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlHorario.Location = new System.Drawing.Point(2, 3);
            this.tabControlHorario.Name = "tabControlHorario";
            this.tabControlHorario.SelectedIndex = 0;
            this.tabControlHorario.Size = new System.Drawing.Size(811, 342);
            this.tabControlHorario.TabIndex = 106;
            this.tabControlHorario.SelectedIndexChanged += new System.EventHandler(this.tabControlHorario_SelectedIndexChanged);
            // 
            // tabPageMantenimiento
            // 
            this.tabPageMantenimiento.Controls.Add(this.groupBoxDatos);
            this.tabPageMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabPageMantenimiento.Name = "tabPageMantenimiento";
            this.tabPageMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMantenimiento.Size = new System.Drawing.Size(803, 316);
            this.tabPageMantenimiento.TabIndex = 1;
            this.tabPageMantenimiento.Text = "Mantenimiento de Horario";
            this.tabPageMantenimiento.UseVisualStyleBackColor = true;
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.comboBoxEmpleado);
            this.groupBoxDatos.Controls.Add(this.label4);
            this.groupBoxDatos.Controls.Add(this.textBoxHEntrada);
            this.groupBoxDatos.Controls.Add(this.textBoxCodigo);
            this.groupBoxDatos.Controls.Add(this.label8);
            this.groupBoxDatos.Controls.Add(this.textBoxTurno);
            this.groupBoxDatos.Controls.Add(this.textBoxHSalida);
            this.groupBoxDatos.Controls.Add(this.label2);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Location = new System.Drawing.Point(107, 16);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(590, 287);
            this.groupBoxDatos.TabIndex = 103;
            this.groupBoxDatos.TabStop = false;
            this.toolTipMensajes.SetToolTip(this.groupBoxDatos, "¡ojo!!! Todos los campos deben ser llenados");
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEmpleado.ForeColor = System.Drawing.Color.DarkGray;
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Location = new System.Drawing.Point(218, 180);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new System.Drawing.Size(218, 21);
            this.comboBoxEmpleado.TabIndex = 120;
            this.toolTipMensajes.SetToolTip(this.comboBoxEmpleado, "Selecione un Empleado");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(152, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 118;
            this.label4.Text = "Empleado :";
            // 
            // textBoxHEntrada
            // 
            this.textBoxHEntrada.Location = new System.Drawing.Point(218, 114);
            this.textBoxHEntrada.MaxLength = 10;
            this.textBoxHEntrada.Name = "textBoxHEntrada";
            this.textBoxHEntrada.Size = new System.Drawing.Size(119, 20);
            this.textBoxHEntrada.TabIndex = 105;
            this.toolTipMensajes.SetToolTip(this.textBoxHEntrada, "Digite la hora de entrada del empleado");
            this.textBoxHEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHEntrada_KeyPress);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxCodigo.Location = new System.Drawing.Point(218, 48);
            this.textBoxCodigo.MaxLength = 1;
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(64, 20);
            this.textBoxCodigo.TabIndex = 104;
            this.toolTipMensajes.SetToolTip(this.textBoxCodigo, "Digite el dni del cliente mas ENTER");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(129, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 115;
            this.label8.Text = "Hora de Salida :";
            // 
            // textBoxTurno
            // 
            this.textBoxTurno.Location = new System.Drawing.Point(218, 81);
            this.textBoxTurno.MaxLength = 10;
            this.textBoxTurno.Name = "textBoxTurno";
            this.textBoxTurno.Size = new System.Drawing.Size(218, 20);
            this.textBoxTurno.TabIndex = 106;
            this.toolTipMensajes.SetToolTip(this.textBoxTurno, "Digite el turno del empleado");
            this.textBoxTurno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTurno_KeyPress);
            // 
            // textBoxHSalida
            // 
            this.textBoxHSalida.Location = new System.Drawing.Point(218, 147);
            this.textBoxHSalida.MaxLength = 10;
            this.textBoxHSalida.Name = "textBoxHSalida";
            this.textBoxHSalida.Size = new System.Drawing.Size(119, 20);
            this.textBoxHSalida.TabIndex = 114;
            this.toolTipMensajes.SetToolTip(this.textBoxHSalida, "Digite la hora de salida del empleado");
            this.textBoxHSalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHSalida_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(166, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "Codigo :";
            this.label2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(121, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 103;
            this.label5.Text = "Hora de Entrada :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(171, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "Turno :";
            // 
            // error
            // 
            this.error.ContainerControl = this;
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
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones : ";
            this.toolTipMensajes.SetToolTip(this.groupBox2, "Seleccione una accion");
            // 
            // frmMantenimientoDeHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 434);
            this.Controls.Add(this.tabControlHorario);
            this.Controls.Add(this.groupBox2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMantenimientoDeHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Mantenimiento De Horario";
            this.tabPageListado.ResumeLayout(false);
            this.tabPageListado.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorario)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControlHorario.ResumeLayout(false);
            this.tabPageMantenimiento.ResumeLayout(false);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageListado;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridViewHorario;
        private System.Windows.Forms.ToolTip toolTipMensajes;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonBuscarxApellidos;
        private System.Windows.Forms.TextBox textBoxBuscarxApellidos;
        private System.Windows.Forms.RadioButton radioButtonEmpleado;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TabControl tabControlHorario;
        private System.Windows.Forms.TabPage tabPageMantenimiento;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.ComboBox comboBoxEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHEntrada;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTurno;
        private System.Windows.Forms.TextBox textBoxHSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}