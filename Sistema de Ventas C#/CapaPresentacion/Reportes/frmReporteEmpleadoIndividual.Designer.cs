namespace CapaPresentacion.Reportes
{
    partial class frmReporteEmpleadoIndividual
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
            this.reporteEmpleadoPorDniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new CapaPresentacion.dsPrincipal();
            this.reporteEmpleadoPorDniTableAdapter = new CapaPresentacion.dsPrincipalTableAdapters.reporteEmpleadoPorDniTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dsPrincipal1 = new CapaPresentacion.dsPrincipal();
            this.reporteEmpleadoPorDniBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadoPorDniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadoPorDniBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteEmpleadoPorDniBindingSource
            // 
            this.reporteEmpleadoPorDniBindingSource.DataMember = "reporteEmpleadoPorDni";
            this.reporteEmpleadoPorDniBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteEmpleadoPorDniTableAdapter
            // 
            this.reporteEmpleadoPorDniTableAdapter.ClearBeforeFill = true;
            // 
            // dsPrincipal1
            // 
            this.dsPrincipal1.DataSetName = "dsPrincipal";
            this.dsPrincipal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteEmpleadoPorDniBindingSource1
            // 
            this.reporteEmpleadoPorDniBindingSource1.DataMember = "reporteEmpleadoPorDni";
            this.reporteEmpleadoPorDniBindingSource1.DataSource = this.dsPrincipal1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteEmpleadoPorDniBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rEmpleadoIndividual.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(664, 430);
            this.reportViewer1.TabIndex = 2;
            // 
            // frmReporteEmpleadoIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 430);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteEmpleadoIndividual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Del Empleado De Manera Individual";
            this.Load += new System.EventHandler(this.frmReporteEmpleadoIndividual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadoPorDniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEmpleadoPorDniBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource reporteEmpleadoPorDniBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.reporteEmpleadoPorDniTableAdapter reporteEmpleadoPorDniTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource reporteEmpleadoPorDniBindingSource1;
        private dsPrincipal dsPrincipal1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}