using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMenuPrincipal : Form
    {
        public static int cambioDeEsatado = 0;
        public frmMenuPrincipal(Empleado oDEmpleado)
        {
            InitializeComponent();
            NTipoDeUsuario oTipo = new NTipoDeUsuario();
            int busqueda = oDEmpleado.getTipoDeUsuario();
            tipoDeUsuario oTipoDeUsuario = oTipo.consultarRegistro(busqueda);
            label1.Text = oDEmpleado.getApellidoPaterno() + " " + oDEmpleado.getApellidoMaterno() + " " + oDEmpleado.getNombre() + 
                "\nusted tiene la cuenta de : " 
                + "\n" + oTipoDeUsuario.getNombreDeTipoDeUsuario();
            MemoryStream ms = new MemoryStream(oDEmpleado.getFoto());
            circularPictureBox1.Image = Image.FromStream(ms);
            
        }

      
    }
}
