namespace CapaPresentacion.Reportes
{
    partial class frmReporteGeneralIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteGeneralIngresos));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ingresoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxProveedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarFechas = new System.Windows.Forms.Button();
            this.comboBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ingresoTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.IngresoTableAdapter();
            this.radioButtonBoleta = new System.Windows.Forms.RadioButton();
            this.radioButtonFactura = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ingresoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ingresoBindingSource
            // 
            this.ingresoBindingSource.DataMember = "Ingreso";
            this.ingresoBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel1.TabIndex = 1;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscar.Enabled = false;
            this.textBoxBuscar.Location = new System.Drawing.Point(14, 367);
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
            this.checkBoxTodos.Location = new System.Drawing.Point(49, 344);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(94, 17);
            this.checkBoxTodos.TabIndex = 1;
            this.checkBoxTodos.Text = "Mostrar Todos";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            this.checkBoxTodos.CheckedChanged += new System.EventHandler(this.checkBoxTodos_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFactura);
            this.groupBox1.Controls.Add(this.radioButtonBoleta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxEstado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxProveedor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBuscarFechas);
            this.groupBox1.Controls.Add(this.comboBoxEmpleados);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFechaInicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(4, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar Reporte Por : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Fechas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Documentos:";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(10, 119);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(174, 21);
            this.comboBoxEstado.TabIndex = 63;
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Estado:";
            // 
            // comboBoxProveedor
            // 
            this.comboBoxProveedor.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxProveedor.FormattingEnabled = true;
            this.comboBoxProveedor.Location = new System.Drawing.Point(10, 77);
            this.comboBoxProveedor.Name = "comboBoxProveedor";
            this.comboBoxProveedor.Size = new System.Drawing.Size(174, 21);
            this.comboBoxProveedor.TabIndex = 61;
            this.comboBoxProveedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxProveedor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Proveedores:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Empleados:";
            // 
            // btnBuscarFechas
            // 
            this.btnBuscarFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFechas.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFechas.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarFechas.Image")));
            this.btnBuscarFechas.Location = new System.Drawing.Point(164, 235);
            this.btnBuscarFechas.Name = "btnBuscarFechas";
            this.btnBuscarFechas.Size = new System.Drawing.Size(20, 20);
            this.btnBuscarFechas.TabIndex = 58;
            this.btnBuscarFechas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscarFechas.UseVisualStyleBackColor = true;
            this.btnBuscarFechas.Click += new System.EventHandler(this.btnBuscarFechas_Click);
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Location = new System.Drawing.Point(10, 37);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Size = new System.Drawing.Size(174, 21);
            this.comboBoxEmpleados.TabIndex = 57;
            this.comboBoxEmpleados.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpleados_SelectedIndexChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(51, 236);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(107, 20);
            this.dtpFechaFin.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(7, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Hasta";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(51, 209);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(133, 20);
            this.dtpFechaInicio.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(4, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Desde";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.ingresoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rIngresisPorFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(199, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(881, 491);
            this.reportViewer1.TabIndex = 2;
            // 
            // ingresoTableAdapter
            // 
            this.ingresoTableAdapter.ClearBeforeFill = true;
            // 
            // radioButtonBoleta
            // 
            this.radioButtonBoleta.AutoSize = true;
            this.radioButtonBoleta.Location = new System.Drawing.Point(38, 166);
            this.radioButtonBoleta.Name = "radioButtonBoleta";
            this.radioButtonBoleta.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBoleta.TabIndex = 3;
            this.radioButtonBoleta.Text = "Boleta";
            this.radioButtonBoleta.UseVisualStyleBackColor = true;
            this.radioButtonBoleta.Click += new System.EventHandler(this.radioButtonBoleta_Click);
            // 
            // radioButtonFactura
            // 
            this.radioButtonFactura.AutoSize = true;
            this.radioButtonFactura.Location = new System.Drawing.Point(106, 166);
            this.radioButtonFactura.Name = "radioButtonFactura";
            this.radioButtonFactura.Size = new System.Drawing.Size(61, 17);
            this.radioButtonFactura.TabIndex = 66;
            this.radioButtonFactura.Text = "Factura";
            this.radioButtonFactura.UseVisualStyleBackColor = true;
            this.radioButtonFactura.CheckedChanged += new System.EventHandler(this.radioButtonFactura_CheckedChanged);
            // 
            // frmReporteGeneralIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 491);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteGeneralIngresos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Generde Ingresos";
            this.Load += new System.EventHandler(this.frmReporteGeneralIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ingresoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.CheckBox checkBoxTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarFechas;
        private System.Windows.Forms.ComboBox comboBoxEmpleados;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private dsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource ingresoBindingSource;
        private dsPrincipalTableAdapters.IngresoTableAdapter ingresoTableAdapter;
        private System.Windows.Forms.RadioButton radioButtonBoleta;
        private System.Windows.Forms.RadioButton radioButtonFactura;
    }
}