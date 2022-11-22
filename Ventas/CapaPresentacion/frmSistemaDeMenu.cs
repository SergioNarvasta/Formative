using CapaDatos;
using CapaNegocio;
using CapaPresentacion.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmSistemaDeMenu : Form
    {
        //public string idEmpleado = "";
        public static int cambioDeEstado = 0;
       
        public frmSistemaDeMenu(Empleado oEmpleado)
        {
            InitializeComponent();
            NTipoDeUsuario oTipo = new NTipoDeUsuario();
            int busqueda = oEmpleado.getTipoDeUsuario();
            tipoDeUsuario oTipoDeUsuario = oTipo.consultarRegistro(busqueda);
            labelEmpleado.Text = "Empleado(a) : " + oEmpleado.getApellidoPaterno() + " " + oEmpleado.getApellidoMaterno() + " " + oEmpleado.getNombre();
            labelTipo.Text = "Cuenta de : " + oTipoDeUsuario.getNombreDeTipoDeUsuario();
            labelOcultar.Text = oEmpleado.getUsuario_id().ToString();
            label4.Text = oEmpleado.getNombre() + " " + oEmpleado.getApellidoPaterno();
            diaHora.Enabled = true;
            comboBoxOpciones.Text = "Seleccione una opcion";
           //para asignar imagen a un boton
            Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\menu.png");
            button1.Image = imagen;
            Bitmap i = new Bitmap(Application.StartupPath + @"\imagen\cerrar3.png");
            btnCerrar.Image = i;
            
           //cambia imagen
            btnCerrar.MouseHover += new System.EventHandler(this.pasa_encima);
            //quitar mouse del boton
            btnCerrar.MouseLeave += this.quitar_encima;
            //precionar boton
           // button1.MouseClick += this.button1_Click;
            
            
            
            label1.Text = oEmpleado.getApellidoPaterno() + " " + oEmpleado.getApellidoMaterno() + " " + oEmpleado.getNombre() +
                "\nusted tiene la cuenta de : "
                + "\n" + oTipoDeUsuario.getNombreDeTipoDeUsuario();
            MemoryStream ms = new MemoryStream(oEmpleado.getFoto());
            pictureBoxFotos.Image = Image.FromStream(ms);
            if(busqueda == 2)
            {

               this.btnProcesos.Visible = false;
               this.btnProvedor.Visible = false;
               this.btnRegistros.Visible = false;
               this.btnReporte.Visible = false;
               this.MnuAlmacen.Visible = false;
               this.MnuCompras.Visible = false;
               this.MnuMatenimiento.Visible = false;
               this.TSMBaseDatos.Visible = false;
                
            }

            else if (busqueda == 3)
            {
                this.btnProcesos_1.Visible = false;
                this.MnuVentas.Visible = false;
                this.MnuMatenimiento.Visible = false;
            }
            else
            {
                this.btnProcesos_1.Visible = false;
            }
           
        }
        

        //public void acomodarBotones()
        //{
        //    btn1.Location = new Point(184, 73);
        //    btn2.Location = new Point(230, 73);
        //    btn3.Location = new Point(276, 73);
        //    btn4.Location = new Point(322, 73);
        //    btn5.Location = new Point(368, 73);
        //}
        //public void acomodarBotones1()
        //{
        //    btn1.Location = new Point(3, 73);
        //    btn2.Location = new Point(49, 73);
        //    btn3.Location = new Point(95, 73);
        //    btn4.Location = new Point(141, 73);
        //    btn5.Location = new Point(187, 73);
        //}
        
       private void frmSistemaDeMenu_Load(object sender, EventArgs e)
        {
            abrirLogo();
        }

       private void abrirFromEnPanel(object fromHijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fh = fromHijo as Form;
            fh.TopLevel = false;
            fh.StartPosition = FormStartPosition.CenterScreen;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
          
        }

       private void diaHora_Tick_1(object sender, EventArgs e)
       {
           this.labelHora.Text = DateTime.Now.ToShortTimeString() + " : " + DateTime.Now.Second;
           this.labelFecha.Text = DateTime.Now.ToShortDateString();
       }

       private void btnProcesos_MouseClick_1(object sender, MouseEventArgs e)
       {
           btnProcesos.BackColor = Color.White;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
           frmProcedimientosIniciales fm = new frmProcedimientosIniciales();
           fm.labelDni.Text = this.labelOcultar.Text;
           abrirFromEnPanel(fm);
           
       }

       private void btnAyuda_MouseClick_1(object sender, MouseEventArgs e)
       {
           btnAyuda.BackColor = Color.White;
           btnProcesos.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
           abrirFromEnPanel(new frmNecesitasAyuda());
       }

       private void btnCambiar_MouseClick_1(object sender, MouseEventArgs e)
       {
           btnAyuda.BackColor = Color.Transparent;
           btnProcesos.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.White;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
           Empleado oDEmpleado = new Empleado();
           frmCambiarContraseña fc = new frmCambiarContraseña(oDEmpleado);
           ((PictureBox)fc.Controls["pictureBoxFoto"]).Image = this.pictureBoxFotos.Image;
           ((Label)fc.Controls["labelNombre"]).Text = this.label4.Text;
           fc.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           //fc.ShowDialog();
           abrirFromEnPanel(fc);
       }

       private void btnProvedor_MouseClick(object sender, MouseEventArgs e)
       {
           btnAyuda.BackColor = Color.Transparent;
           btnProcesos.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.White;
           btnProcesos_1.BackColor = Color.Transparent;

           frmMantenimientoDeProveedor fm = new frmMantenimientoDeProveedor();
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);
       }

       private void btnReporte_MouseClick(object sender, MouseEventArgs e)
       {
           btnAyuda.BackColor = Color.Transparent;
           btnProcesos.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.White;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
       }

       private void btnRegistros_MouseClick(object sender, MouseEventArgs e)
       {
           btnAyuda.BackColor = Color.Transparent;
           btnProcesos.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.White;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
           frmMantenimientoDeEmpleado fm = new frmMantenimientoDeEmpleado();
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);
           

       }

       private void comboBoxOpciones_SelectedIndexChanged_1(object sender, EventArgs e)
       {
           if (Convert.ToString(this.comboBoxOpciones.SelectedItem) == "Salir del programa")
           {
               
               if (MessageBox.Show("¿Esta Seguro de Salir del Programa?",
                   "CONFRMAR SALIDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               {

                   cambioDeEstado = 2; Dispose();
               }

           }
           else
           {
               cambioDeEstado = 0; Dispose();
           }
       }

       private void button1_Click(object sender, EventArgs e)
       {
           if(this.panelMenu.Width == 180)
           {
               timer1.Enabled = true;
               toolTip1.SetToolTip(this.button1, "Mostrar");
               //btnProcesos.Focus();  
           }
           else if (this.panelMenu.Width == 45)
           {
               timer2.Enabled = true;
               toolTip1.SetToolTip(this.button1, "Ocultar");
               //btnProcesos.Focus();
               
            }
           
       }

       private void timer1_Tick(object sender, EventArgs e)
       {
           if (panelMenu.Width <= 45)
           {
               timer1.Enabled = false;
               label1.Visible = false;
               Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\menu1.png");
               button1.Image = imagen;
               this.button1.Location = new Point(16, 5);
               //this.btnProcesos.Location = new Point(0,62);
               //this.btnAyuda.Location = new Point(0, 107);
               //this.btnCambiar.Location = new Point(0, 152);
               //this.btnProvedor.Location = new Point(0, 197);
               //this.btnReporte.Location = new Point(0, 242);
               //this.btnRegistros.Location = new Point(0, 287);
               
               btnProcesos.Focus();
               
               
           }
           else
           {
               this.panelMenu.Width = panelMenu.Width - 15;
           }
       }

       private void timer2_Tick(object sender, EventArgs e)
       {
           if (panelMenu.Width >= 180)
           {
               timer2.Enabled = false;
               label1.Visible = true;
               Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\menu.png");
               button1.Image = imagen;
               //this.btnProcesos.Location = new Point(0, 173);
               //this.btnAyuda.Location = new Point(0, 218);
               //this.btnCambiar.Location = new Point(0, 263);
               //this.btnProvedor.Location = new Point(0, 308);
               //this.btnReporte.Location = new Point(0, 353);
               //this.btnRegistros.Location = new Point(0, 398);
               
               btnProcesos.Focus();
               
               
           }
           else
           {
               this.panelMenu.Width = panelMenu.Width + 15;
           }
       }

       private void abrirLogo()
       {
           abrirFromEnPanel(new frmLogo());
           this.btnRegistros.BackColor = Color.Transparent;
           this.btnReporte.BackColor = Color.Transparent;
           this.btnCambiar.BackColor = Color.Transparent;
           this.btnProvedor.BackColor = Color.Transparent;
       }
       private void mostrarLogoAlCerrar(object sender, FormClosedEventArgs e)
       {
           abrirLogo();
       }
      
       private void pasa_encima(object obj, EventArgs evt)
       {
           Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\cerrar2.png");
           btnCerrar.Image = imagen;
       }

       private void quitar_encima(object obj, EventArgs evt)
       {
           Bitmap imagen = new Bitmap(Application.StartupPath + @"\imagen\cerrar3.png");
           btnCerrar.Image = imagen;
       }

       private void btnCerrar_Click(object sender, EventArgs e)
       {
           cambioDeEstado = 2; Dispose();
       }

       private void btnMinimizar_Click(object sender, EventArgs e)
       {
           this.WindowState = FormWindowState.Minimized;
       }
       int Lx, Ly;
       private void btnMaximizar_Click(object sender, EventArgs e)
       {
           Lx = this.Location.X;
           Ly = this.Location.Y;
           this.Location = Screen.PrimaryScreen.WorkingArea.Location;
           this.Size = Screen.PrimaryScreen.WorkingArea.Size;
           
           btnMaximizar.Visible = false;
           btnRestaurar.Visible = true;
       }

       private void btnRestaurar_Click(object sender, EventArgs e)
       {
           this.Size = new Size(1032, 544);
           this.Location = new Point(Lx, Ly);
           btnMaximizar.Visible = true;
           btnRestaurar.Visible = false;
       }

       
       private void TsmiManual_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("¿Esta Seguro abrir el Manual de Usuario del Programa?",
                   "MANUAL DE USUARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
               System.Diagnostics.Process.Start("C:\\Users\\server\\Desktop\\ProyectosDSI\\Sistemas_de_Control_de_Ventas_y_Stock\\CapaPresentacion\\bin\\Debug\\imagen\\Manual.pdf");

           }

           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
       }

       private void TsmiVideo_Click(object sender, EventArgs e)
       {
           frmVideo fm = new frmVideo();
           fm.ShowDialog();
           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
         
       }

       private void TsmiInformacion_Click(object sender, EventArgs e)
       {
           frmInformacion fm = new frmInformacion();
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);
           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
           fm.Size = new Size(253, 412);

           fm.labelWeb.Location = new Point(6, 346);
           fm.labelReservado.Location = new Point(30, 380);
       }

       private void TsmiCambiar_Click(object sender, EventArgs e)
       {
           Empleado oDEmpleado = new Empleado();
           frmCambiarContraseña fc = new frmCambiarContraseña(oDEmpleado);
           ((PictureBox)fc.Controls["pictureBoxFoto"]).Image = this.pictureBoxFotos.Image;
           ((Label)fc.Controls["labelNombre"]).Text = this.label4.Text;
           fc.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fc);

           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
       }

       private void TsmiEmpleado_Click(object sender, EventArgs e)
       {
           frmMantenimientoDeEmpleado fm = new frmMantenimientoDeEmpleado();
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);
           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
       }

       private void btnProcesos_1_Click(object sender, EventArgs e)
       {
           btnAyuda.BackColor = Color.Transparent;
           btnProcesos.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.White;
           
           frmProcedimientosIniciales_1 fm = new frmProcedimientosIniciales_1();
           fm.labelDni.Text = this.labelOcultar.Text;
           abrirFromEnPanel(fm);
       }

       private void TsmiCategorias_Click(object sender, EventArgs e)
       {
           frmMantenimientoDeCategoria fm = new frmMantenimientoDeCategoria();
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);
           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
       }

       private void TsmiProductos_Click(object sender, EventArgs e)
       {
           //frmMantenimientoDeProducto fm =  frmMantenimientoDeProducto.GetInstancia();
           frmMantenimientoDeProducto fm = new frmMantenimientoDeProducto();
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);
           //fm.ShowDialog();
           fm.textBoxIdProducto.Text = "";
           fm.textBoxIdCategoria.Text = "";
           fm.textBoxNombre.Text = "";
           fm.textBoxMarca.Text = "";
           fm.textBoxPCompra.Text = "";
           fm.textBoxPVenta.Text = "";
           fm.textBoxStock.Text = "";
           fm.textBoxNombreCate.Text = "";
           fm.pictureBoxImagen.Image = fm.pictureBoxImagen.BackgroundImage;
           fm.comboBoxPresentacion.Text = "Seleccione una opcion";

           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
       }

       private void TsmiPresentacion_Click(object sender, EventArgs e)
       {
           frmMantenimientoDePresentacion fm = new frmMantenimientoDePresentacion();
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);
           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
       }

       private void TsmiIngresos_Click(object sender, EventArgs e)
       {
           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;

           frmMantenimientoDeIngresos fm = new frmMantenimientoDeIngresos();
           fm.labelNombre.Text = this.labelOcultar.Text;
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);
       }

       private void TsmiProveedor_Click(object sender, EventArgs e)
       {
           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
           frmMantenimientoDeProveedor fm = new frmMantenimientoDeProveedor();
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);
       }

       private void TsmiRealizarVentas_Click(object sender, EventArgs e)
       {
           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
           frmMantenimientoDeComprobantes fm = new frmMantenimientoDeComprobantes();
           fm.labelNombre.Text = this.labelOcultar.Text;
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);
             
       }

       private void TsmiClientes_Click(object sender, EventArgs e)
       {
           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
           frmMantenimientoDeCliente fm = new frmMantenimientoDeCliente();
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);
       }

       private void TsmiVentas_Click(object sender, EventArgs e)
       {

           frmConsultasDeVentasPorFechas fm = new frmConsultasDeVentasPorFechas();
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);

           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
       }

       private void TsmiCompra_Click(object sender, EventArgs e)
       {
           frmConsultasDeComprasPorFechas fm = new frmConsultasDeComprasPorFechas();
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);
           
           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
       }

       private void TsmiStock_Click(object sender, EventArgs e)
       {
           frmConsultasStockProductos fm = new frmConsultasStockProductos();
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);
           
           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
       }

       private void horarioToolStripMenuItem_Click(object sender, EventArgs e)
       {
           frmMantenimientoDeHorario fm = new frmMantenimientoDeHorario();
           fm.FormClosed += new FormClosedEventHandler(mostrarLogoAlCerrar);
           abrirFromEnPanel(fm);
           
           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
       }

       private void TsmiBack_Click(object sender, EventArgs e)
       {



           btnProcesos.BackColor = Color.Transparent;
           btnAyuda.BackColor = Color.Transparent;
           btnCambiar.BackColor = Color.Transparent;
           btnReporte.BackColor = Color.Transparent;
           btnRegistros.BackColor = Color.Transparent;
           btnProvedor.BackColor = Color.Transparent;
           btnProcesos_1.BackColor = Color.Transparent;
       }

      
        
    }
}
