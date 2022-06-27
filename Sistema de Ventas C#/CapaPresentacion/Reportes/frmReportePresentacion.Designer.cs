namespace CapaPresentacion.Reportes
{
    partial class frmReportePresentacion
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
            this.presentacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPresentacion = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.presentacionTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.PresentacionTableAdapter();
            this.comboBoxPresentacion = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // presentacionBindingSource
            // 
            this.presentacionBindingSource.DataMember = "Presentacion";
            this.presentacionBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxPresentacion);
            this.panel1.Controls.Add(this.textBoxPresentacion);
            this.panel1.Controls.Add(this.buttonBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 34);
            this.panel1.TabIndex = 93;
            // 
            // textBoxPresentacion
            // 
            this.textBoxPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPresentacion.Enabled = false;
            this.textBoxPresentacion.Location = new System.Drawing.Point(411, 7);
            this.textBoxPresentacion.Name = "textBoxPresentacion";
            this.textBoxPresentacion.Size = new System.Drawing.Size(66, 13);
            this.textBoxPresentacion.TabIndex = 93;
            this.textBoxPresentacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPresentacion.Visible = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.White;
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBuscar.Image = global::CapaPresentacion.Properties.Resources.lupa;
            this.buttonBuscar.Location = new System.Drawing.Point(385, 9);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(20, 20);
            this.buttonBuscar.TabIndex = 91;
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.buttonBuscar, "click para mostrar todos");
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(111, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Presentacion :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 427);
            this.panel2.TabIndex = 94;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.presentacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rPresentacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(560, 427);
            this.reportViewer1.TabIndex = 0;
            // 
            // presentacionTableAdapter
            // 
            this.presentacionTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxPresentacion
            // 
            this.comboBoxPresentacion.ForeColor = System.Drawing.Color.DimGray;
            this.comboBoxPresentacion.FormattingEnabled = true;
            this.comboBoxPresentacion.Location = new System.Drawing.Point(189, 7);
            this.comboBoxPresentacion.Name = "comboBoxPresentacion";
            this.comboBoxPresentacion.Size = new System.Drawing.Size(193, 21);
            this.comboBoxPresentacion.TabIndex = 94;
            this.toolTip1.SetToolTip(this.comboBoxPresentacion, "seleccione una opcion");
            this.comboBoxPresentacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxPresentacion_SelectedIndexChanged);
            // 
            // frmReportePresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReportePresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de las Presentacion";
            this.Load += new System.EventHandler(this.frmReportePresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource presentacionBindingSource;
        private dsPrincipalTableAdapters.PresentacionTableAdapter presentacionTableAdapter;
        private System.Windows.Forms.TextBox textBoxPresentacion;
        private System.Windows.Forms.ComboBox comboBoxPresentacion;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}