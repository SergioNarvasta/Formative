namespace CapaPresentacion.Reportes
{
    partial class frmReporteProveedor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRazon = new System.Windows.Forms.RadioButton();
            this.radioButtonSector = new System.Windows.Forms.RadioButton();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.comboBoxRazon = new System.Windows.Forms.ComboBox();
            this.textBoxSector = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.proveedorTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.ProveedorTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxBuscar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 473);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.proveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(251, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(875, 473);
            this.reportViewer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Controls.Add(this.textBoxSector);
            this.groupBox1.Controls.Add(this.comboBoxRazon);
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonSector);
            this.groupBox1.Controls.Add(this.radioButtonRazon);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(6, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporte Por : ";
            // 
            // radioButtonRazon
            // 
            this.radioButtonRazon.AutoSize = true;
            this.radioButtonRazon.Location = new System.Drawing.Point(15, 34);
            this.radioButtonRazon.Name = "radioButtonRazon";
            this.radioButtonRazon.Size = new System.Drawing.Size(88, 17);
            this.radioButtonRazon.TabIndex = 0;
            this.radioButtonRazon.Text = "Razon Social";
            this.toolTip1.SetToolTip(this.radioButtonRazon, "reporte por razon social");
            this.radioButtonRazon.UseVisualStyleBackColor = true;
            this.radioButtonRazon.Click += new System.EventHandler(this.radioButtonRazon_Click);
            // 
            // radioButtonSector
            // 
            this.radioButtonSector.AutoSize = true;
            this.radioButtonSector.Checked = true;
            this.radioButtonSector.Location = new System.Drawing.Point(15, 84);
            this.radioButtonSector.Name = "radioButtonSector";
            this.radioButtonSector.Size = new System.Drawing.Size(105, 17);
            this.radioButtonSector.TabIndex = 2;
            this.radioButtonSector.TabStop = true;
            this.radioButtonSector.Text = "Sector Comercial";
            this.toolTip1.SetToolTip(this.radioButtonSector, "reporte por sector comercial");
            this.radioButtonSector.UseVisualStyleBackColor = true;
            this.radioButtonSector.Click += new System.EventHandler(this.radioButtonSector_Click);
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(15, 133);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodos.TabIndex = 3;
            this.radioButtonTodos.Text = "Todos";
            this.toolTip1.SetToolTip(this.radioButtonTodos, "mostrar todos los reportes");
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.Click += new System.EventHandler(this.radioButtonTodos_Click);
            // 
            // comboBoxRazon
            // 
            this.comboBoxRazon.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxRazon.FormattingEnabled = true;
            this.comboBoxRazon.Location = new System.Drawing.Point(30, 57);
            this.comboBoxRazon.Name = "comboBoxRazon";
            this.comboBoxRazon.Size = new System.Drawing.Size(204, 21);
            this.comboBoxRazon.TabIndex = 4;
            this.toolTip1.SetToolTip(this.comboBoxRazon, "seleccione una razon social");
            this.comboBoxRazon.Visible = false;
            this.comboBoxRazon.SelectedIndexChanged += new System.EventHandler(this.comboBoxRazon_SelectedIndexChanged);
            // 
            // textBoxSector
            // 
            this.textBoxSector.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxSector.Location = new System.Drawing.Point(30, 107);
            this.textBoxSector.Name = "textBoxSector";
            this.textBoxSector.Size = new System.Drawing.Size(178, 20);
            this.textBoxSector.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxSector, "escriba un sector comercial");
            this.textBoxSector.Visible = false;
            this.textBoxSector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSector_KeyPress);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.White;
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBuscar.Image = global::CapaPresentacion.Properties.Resources.lupa;
            this.buttonBuscar.Location = new System.Drawing.Point(214, 106);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscar.TabIndex = 93;
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonBuscar, "click para buscar");
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Visible = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscar.Enabled = false;
            this.textBoxBuscar.Location = new System.Drawing.Point(21, 126);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(219, 13);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBuscar.Visible = false;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 473);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteProveedor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes de los Proveedores";
            this.Load += new System.EventHandler(this.frmReporteProveedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSector;
        private System.Windows.Forms.ComboBox comboBoxRazon;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonSector;
        private System.Windows.Forms.RadioButton radioButtonRazon;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
    }
}