namespace CapaPresentacion.Reportes
{
    partial class frmReporteGeneralDeComprobantes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteGeneralDeComprobantes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.radioButtonEmpleado = new System.Windows.Forms.RadioButton();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonFecha = new System.Windows.Forms.RadioButton();
            this.comboBoxPago = new System.Windows.Forms.ComboBox();
            this.radioButtonPago = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.radioButtonClientes = new System.Windows.Forms.RadioButton();
            this.radioButtonFactura = new System.Windows.Forms.RadioButton();
            this.radioButtonBoleta = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBuscarFechas = new System.Windows.Forms.Button();
            this.comprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.comprobanteTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.ComprobanteTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxBuscar);
            this.panel1.Controls.Add(this.checkBoxTodos);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 491);
            this.panel1.TabIndex = 0;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscar.Enabled = false;
            this.textBoxBuscar.Location = new System.Drawing.Point(14, 342);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(157, 13);
            this.textBoxBuscar.TabIndex = 3;
            this.textBoxBuscar.Visible = false;
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxTodos.ForeColor = System.Drawing.Color.Green;
            this.checkBoxTodos.Location = new System.Drawing.Point(49, 319);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(94, 17);
            this.checkBoxTodos.TabIndex = 1;
            this.checkBoxTodos.Text = "Mostrar Todos";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            this.checkBoxTodos.CheckedChanged += new System.EventHandler(this.checkBoxTodos_CheckedChanged);
            this.checkBoxTodos.Click += new System.EventHandler(this.checkBoxTodos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarFechas);
            this.groupBox1.Controls.Add(this.comboBoxEmpleados);
            this.groupBox1.Controls.Add(this.radioButtonEmpleado);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButtonFecha);
            this.groupBox1.Controls.Add(this.comboBoxPago);
            this.groupBox1.Controls.Add(this.radioButtonPago);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Controls.Add(this.textBoxNombres);
            this.groupBox1.Controls.Add(this.radioButtonClientes);
            this.groupBox1.Controls.Add(this.radioButtonFactura);
            this.groupBox1.Controls.Add(this.radioButtonBoleta);
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar Reporte Por : ";
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados.Enabled = false;
            this.comboBoxEmpleados.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Location = new System.Drawing.Point(10, 37);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Size = new System.Drawing.Size(174, 21);
            this.comboBoxEmpleados.TabIndex = 57;
            this.comboBoxEmpleados.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpleados_SelectedIndexChanged);
            // 
            // radioButtonEmpleado
            // 
            this.radioButtonEmpleado.AutoSize = true;
            this.radioButtonEmpleado.Checked = true;
            this.radioButtonEmpleado.Location = new System.Drawing.Point(10, 17);
            this.radioButtonEmpleado.Name = "radioButtonEmpleado";
            this.radioButtonEmpleado.Size = new System.Drawing.Size(72, 17);
            this.radioButtonEmpleado.TabIndex = 56;
            this.radioButtonEmpleado.TabStop = true;
            this.radioButtonEmpleado.Text = "Empleado";
            this.radioButtonEmpleado.UseVisualStyleBackColor = true;
            this.radioButtonEmpleado.Click += new System.EventHandler(this.radioButtonEmpleado_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Enabled = false;
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(51, 270);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(107, 20);
            this.dtpFechaFin.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(7, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Hasta";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Enabled = false;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(51, 243);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(133, 20);
            this.dtpFechaInicio.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(4, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Desde";
            // 
            // radioButtonFecha
            // 
            this.radioButtonFecha.AutoSize = true;
            this.radioButtonFecha.Location = new System.Drawing.Point(10, 220);
            this.radioButtonFecha.Name = "radioButtonFecha";
            this.radioButtonFecha.Size = new System.Drawing.Size(60, 17);
            this.radioButtonFecha.TabIndex = 51;
            this.radioButtonFecha.Text = "Fechas";
            this.radioButtonFecha.UseVisualStyleBackColor = true;
            this.radioButtonFecha.Click += new System.EventHandler(this.radioButtonFecha_Click);
            // 
            // comboBoxPago
            // 
            this.comboBoxPago.Enabled = false;
            this.comboBoxPago.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxPago.FormattingEnabled = true;
            this.comboBoxPago.Location = new System.Drawing.Point(10, 193);
            this.comboBoxPago.Name = "comboBoxPago";
            this.comboBoxPago.Size = new System.Drawing.Size(174, 21);
            this.comboBoxPago.TabIndex = 50;
            this.comboBoxPago.SelectedIndexChanged += new System.EventHandler(this.comboBoxPago_SelectedIndexChanged);
            // 
            // radioButtonPago
            // 
            this.radioButtonPago.AutoSize = true;
            this.radioButtonPago.Location = new System.Drawing.Point(10, 172);
            this.radioButtonPago.Name = "radioButtonPago";
            this.radioButtonPago.Size = new System.Drawing.Size(102, 17);
            this.radioButtonPago.TabIndex = 49;
            this.radioButtonPago.Text = "Forma de Pagos";
            this.radioButtonPago.UseVisualStyleBackColor = true;
            this.radioButtonPago.Click += new System.EventHandler(this.radioButtonPago_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(4, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 12);
            this.label1.TabIndex = 48;
            this.label1.Text = "Escriba el  Nombre o Apelliodo del cliente";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Enabled = false;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(164, 133);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscar.TabIndex = 47;
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombres.Enabled = false;
            this.textBoxNombres.ForeColor = System.Drawing.Color.DarkOrange;
            this.textBoxNombres.Location = new System.Drawing.Point(10, 133);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(148, 20);
            this.textBoxNombres.TabIndex = 3;
            this.textBoxNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombres_KeyPress);
            // 
            // radioButtonClientes
            // 
            this.radioButtonClientes.AutoSize = true;
            this.radioButtonClientes.Location = new System.Drawing.Point(10, 109);
            this.radioButtonClientes.Name = "radioButtonClientes";
            this.radioButtonClientes.Size = new System.Drawing.Size(62, 17);
            this.radioButtonClientes.TabIndex = 2;
            this.radioButtonClientes.Text = "Clientes";
            this.radioButtonClientes.UseVisualStyleBackColor = true;
            this.radioButtonClientes.Click += new System.EventHandler(this.radioButtonClientes_Click);
            // 
            // radioButtonFactura
            // 
            this.radioButtonFactura.AutoSize = true;
            this.radioButtonFactura.Location = new System.Drawing.Point(10, 86);
            this.radioButtonFactura.Name = "radioButtonFactura";
            this.radioButtonFactura.Size = new System.Drawing.Size(61, 17);
            this.radioButtonFactura.TabIndex = 1;
            this.radioButtonFactura.Text = "Factura";
            this.radioButtonFactura.UseVisualStyleBackColor = true;
            this.radioButtonFactura.Click += new System.EventHandler(this.radioButtonFactura_Click);
            // 
            // radioButtonBoleta
            // 
            this.radioButtonBoleta.AutoSize = true;
            this.radioButtonBoleta.Location = new System.Drawing.Point(10, 63);
            this.radioButtonBoleta.Name = "radioButtonBoleta";
            this.radioButtonBoleta.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBoleta.TabIndex = 0;
            this.radioButtonBoleta.Text = "Boleta";
            this.radioButtonBoleta.UseVisualStyleBackColor = true;
            this.radioButtonBoleta.Click += new System.EventHandler(this.radioButtonBoleta_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.comprobanteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rComprobnatesPorDocumento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(199, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(881, 491);
            this.reportViewer1.TabIndex = 1;
            // 
            // btnBuscarFechas
            // 
            this.btnBuscarFechas.Enabled = false;
            this.btnBuscarFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFechas.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFechas.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarFechas.Image")));
            this.btnBuscarFechas.Location = new System.Drawing.Point(164, 269);
            this.btnBuscarFechas.Name = "btnBuscarFechas";
            this.btnBuscarFechas.Size = new System.Drawing.Size(20, 20);
            this.btnBuscarFechas.TabIndex = 58;
            this.btnBuscarFechas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscarFechas.UseVisualStyleBackColor = true;
            this.btnBuscarFechas.Click += new System.EventHandler(this.button1_Click);
            // 
            // comprobanteBindingSource
            // 
            this.comprobanteBindingSource.DataMember = "Comprobante";
            this.comprobanteBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprobanteTableAdapter
            // 
            this.comprobanteTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteGeneralDeComprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 491);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteGeneralDeComprobantes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteGeneralDeComprobantes";
            this.Load += new System.EventHandler(this.frmReporteGeneralDeComprobantes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.RadioButton radioButtonClientes;
        private System.Windows.Forms.RadioButton radioButtonFactura;
        private System.Windows.Forms.RadioButton radioButtonBoleta;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonFecha;
        private System.Windows.Forms.ComboBox comboBoxPago;
        private System.Windows.Forms.RadioButton radioButtonPago;
        private System.Windows.Forms.ComboBox comboBoxEmpleados;
        private System.Windows.Forms.RadioButton radioButtonEmpleado;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource comprobanteBindingSource;
        private dsPrincipalTableAdapters.ComprobanteTableAdapter comprobanteTableAdapter;
        private System.Windows.Forms.Button btnBuscarFechas;
    }
}