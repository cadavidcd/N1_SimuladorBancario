
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using N1_SimuladorBancario.Modelo;

namespace N1_SimuladorBancario
{
    /// <summary>
    /// Clase estática para la inicialización de la aplicación.
    /// </summary>
    static class Programa
    {
        /// <summary>
        /// Punto de entrada a la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CuentaBancaria cuentaBancaria = new CuentaBancaria("00043616", "Carlos Echeverri");

            Application.Run(new Principal(cuentaBancaria));
        }
    }
}
