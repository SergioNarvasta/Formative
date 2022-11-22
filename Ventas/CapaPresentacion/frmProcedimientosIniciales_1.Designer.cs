namespace CapaPresentacion
{
    partial class frmProcedimientosIniciales_1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDni = new System.Windows.Forms.Label();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.label7SinRaya = new System.Windows.Forms.Label();
            this.label3SinRaya = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelDni);
            this.panel1.Controls.Add(this.pictureBoxImagen);
            this.panel1.Controls.Add(this.label7SinRaya);
            this.panel1.Controls.Add(this.label3SinRaya);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 521);
            this.panel1.TabIndex = 1;
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(388, 45);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(0, 13);
            this.labelDni.TabIndex = 8;
            this.labelDni.Visible = false;
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(371, 92);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(346, 400);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxImagen.TabIndex = 0;
            this.pictureBoxImagen.TabStop = false;
            // 
            // label7SinRaya
            // 
            this.label7SinRaya.AutoSize = true;
            this.label7SinRaya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7SinRaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7SinRaya.ForeColor = System.Drawing.Color.DarkGray;
            this.label7SinRaya.Location = new System.Drawing.Point(12, 127);
            this.label7SinRaya.Name = "label7SinRaya";
            this.label7SinRaya.Size = new System.Drawing.Size(149, 20);
            this.label7SinRaya.TabIndex = 5;
            this.label7SinRaya.Text = "Registro de clientes";
            this.label7SinRaya.Click += new System.EventHandler(this.label7SinRaya_Click);
            // 
            // label3SinRaya
            // 
            this.label3SinRaya.AutoSize = true;
            this.label3SinRaya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3SinRaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3SinRaya.ForeColor = System.Drawing.Color.DarkGray;
            this.label3SinRaya.Location = new System.Drawing.Point(12, 92);
            this.label3SinRaya.Name = "label3SinRaya";
            this.label3SinRaya.Size = new System.Drawing.Size(141, 20);
            this.label3SinRaya.TabIndex = 4;
            this.label3SinRaya.Text = "Realizar una venta";
            this.label3SinRaya.Click += new System.EventHandler(this.label3SinRaya_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "Procedimientos iniciales";
            // 
            // frmProcedimientosIniciales_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 521);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProcedimientosIniciales_1";
            this.Text = "frmProcedimientosIniciales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label7SinRaya;
        public System.Windows.Forms.Label label3SinRaya;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelDni;
    }
}