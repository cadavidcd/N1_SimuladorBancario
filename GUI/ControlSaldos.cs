using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N1_SimuladorBancario.GUI
{
    /// <summary>
    /// Representa el control para la visualización de los saldos de las cuentas.
    /// </summary>
    public partial class ControlSaldos : UserControl
    {
        #region Constructores
        /// <summary>
        /// Crea una instancia de `ControlSaldos`.
        /// </summary>
        public ControlSaldos()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Actualiza el saldo actual y muestra nuevos valores en los controles correspondientes.
        /// </summary>
        /// <param name="nuevoSaldo">Nuevo saldo de la cuenta bancaria.</param>
        public void ActualizarSaldoActual(decimal nuevoSaldo)
        {
            txtSaldoTotal.Text = String.Format("{0:C}", nuevoSaldo);
        }
        /// <summary>
        /// Actualiza el saldo actual de la cuenta de ahorros 
        /// y muestra nuevos valores en los controles correspondientes.
        /// </summary>
        /// <param name="nuevoSaldo"></param>
        public void ActualizarSaldoAhorros(decimal nuevoSaldo)
        {
            txtSaldoAhorros.Text = String.Format("{0:C}", nuevoSaldo);
        }
        /// <summary>
        /// Actualiza el saldo actual de la cuenta corriente 
        /// y muestra nuevos valores en los controles correspondientes.
        /// </summary>
        /// <param name="nuevoSaldo"></param>
        public void ActualizarSaldoCorriente(decimal nuevoSaldo)
        {
            txtSaldoCorriente.Text = String.Format("{0:C}", nuevoSaldo);
        }
        /// <summary>
        /// Actualiza el saldo actual del CDT y muestra nuevos 
        /// valores en los controles correspondientes.
        /// </summary>
        /// <param name="nuevoSaldo"></param>
        public void ActualizarSaldoCDT(decimal nuevoSaldo)
        {
            txtSaldoCdt.Text = String.Format("{0:C}", nuevoSaldo);
        }
        #endregion
    }
}
