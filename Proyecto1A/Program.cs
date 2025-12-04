using Proyecto1A.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1A
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmProductos());
            //Application.Run(new FrmMenuPrincipal());
            // Application.Run(new FrmClientes2());
            //Application.Run(new FrmCategoria());
            //Application.Run(new FrmRegistrarVenta());
            Application.Run(new FrmLogin());
        }
    }
}
