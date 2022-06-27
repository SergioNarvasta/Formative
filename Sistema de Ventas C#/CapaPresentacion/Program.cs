using CapaPresentacion.Consultas;
using CapaPresentacion.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMantenimientoDeEmpleado ());
            Application.Run(frmMantenimientoDeProducto.GetInstancia());


            frmLogin.estado = 0;

            while (frmLogin.estado == 0)
            {
                new frmLogin().ShowDialog();
                if (frmLogin.estado == 1)
                {
                    frmLogin.estado = frmSistemaDeMenu.cambioDeEstado;
                }

            }

        }
    }
}
