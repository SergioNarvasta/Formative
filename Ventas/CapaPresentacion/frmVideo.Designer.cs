namespace CapaPresentacion
{
    partial class frmVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVideo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMaximizar = new System.Windows.Forms.Button();
            this.buttonRestaurar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.wmpVideo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 452);
            this.panel1.TabIndex = 0;
            // 
            // wmpVideo
            // 
            this.wmpVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(10, 34);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(687, 411);
            this.wmpVideo.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.buttonMaximizar);
            this.panel2.Controls.Add(this.buttonRestaurar);
            this.panel2.Controls.Add(this.buttonCerrar);
            this.panel2.Controls.Add(this.labelNombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 28);
            this.panel2.TabIndex = 0;
            // 
            // buttonMaximizar
            // 
            this.buttonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximizar.BackColor = System.Drawing.Color.White;
            this.buttonMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonMaximizar.FlatAppearance.BorderSize = 2;
            this.buttonMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMaximizar.ForeColor = System.Drawing.Color.Red;
            this.buttonMaximizar.Location = new System.Drawing.Point(658, 4);
            this.buttonMaximizar.Name = "buttonMaximizar";
            this.buttonMaximizar.Size = new System.Drawing.Size(20, 20);
            this.buttonMaximizar.TabIndex = 7;
            this.buttonMaximizar.Text = "M";
            this.toolTip1.SetToolTip(this.buttonMaximizar, "Maximizar");
            this.buttonMaximizar.UseVisualStyleBackColor = false;
            this.buttonMaximizar.Click += new System.EventHandler(this.buttonMaximizar_Click);
            // 
            // buttonRestaurar
            // 
            this.buttonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestaurar.BackColor = System.Drawing.Color.White;
            this.buttonRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRestaurar.FlatAppearance.BorderSize = 2;
            this.buttonRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRestaurar.ForeColor = System.Drawing.Color.Red;
            this.buttonRestaurar.Location = new System.Drawing.Point(658, 4);
            this.buttonRestaurar.Name = "buttonRestaurar";
            this.buttonRestaurar.Size = new System.Drawing.Size(20, 20);
            this.buttonRestaurar.TabIndex = 6;
            this.buttonRestaurar.Text = "R";
            this.toolTip1.SetToolTip(this.buttonRestaurar, "Restaurar");
            this.buttonRestaurar.UseVisualStyleBackColor = false;
            this.buttonRestaurar.Click += new System.EventHandler(this.buttonRestaurar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrar.BackColor = System.Drawing.Color.White;
            this.buttonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonCerrar.FlatAppearance.BorderSize = 2;
            this.buttonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCerrar.ForeColor = System.Drawing.Color.Red;
            this.buttonCerrar.Location = new System.Drawing.Point(684, 4);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(20, 20);
            this.buttonCerrar.TabIndex = 5;
            this.buttonCerrar.Text = "X";
            this.toolTip1.SetToolTip(this.buttonCerrar, "Cerrar");
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(5, 8);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(111, 13);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Ayuda - Video Turorial";
            // 
            // frmVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 452);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVideo";
            this.Load += new System.EventHandler(this.frmVideo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonMaximizar;
        private System.Windows.Forms.Button buttonRestaurar;
    }
}