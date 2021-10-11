using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPuntoDeVenta.Vista;
using SistemaPuntoDeVenta.Repositorio;
using SistemaPuntoDeVenta.Reporte;
//esto es una prueba 
namespace SistemaPuntoDeVenta
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuVista());
        }
    }
}
