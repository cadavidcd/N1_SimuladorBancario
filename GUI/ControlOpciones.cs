using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N1_SimuladorBancario;
using N1_SimuladorBancario.Utilidades;

namespace N1_SimuladorBancario.GUI
{
    /// <summary>
    /// Controles para abrir un CDT, consigar y retirar de las cuentas de ahorro y corriente.
    /// </summary>
    public partial class ControlOpciones : UserControl
    {
        #region Atributos
        /// <summary>
        /// Referencia al formulario principal de la aplicación.
        /// </summary>
        private Principal principal;
        #endregion
        public ControlOpciones(Principal ventanaPrincipal)
        {
            InitializeComponent();
            principal = ventanaPrincipal;
        }

        #region Eventos
        /// <summary>
        /// Abre un nuevo CDT.
        /// </summary>
        /// <param name="sender">Actividador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnCDTAbrir_Click(object sender, EventArgs e)
        {
            string valor = string.Empty;
            Ayudante.InputBox("Abrir Inversión CDT", "Introduzca el valor de la inversión", ref valor);

            string porcentaje = string.Empty;
            Ayudante.InputBox("Abrir Inversión CDT", "Introduzca el porcentaje de la inversión", ref porcentaje);

            decimal valorDecimal;
            decimal porcentajeDecimal;

            if (Decimal.TryParse(valor, out valorDecimal) && Decimal.TryParse(porcentaje, out porcentajeDecimal) &&
                valorDecimal > 0 && porcentajeDecimal > 0)
            {
                principal.InvertirCDT(valorDecimal, porcentajeDecimal);
                principal.ActualizarCliente();
            }
            else
            {
                MessageBox.Show(this, "Los valores introducidos no son válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Cierra el CDT.
        /// </summary>
        /// <param name="sender">Actividador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnCDTCerrar_Click(object sender, EventArgs e)
        {
            principal.CerrarCDT();
            principal.ActualizarCliente();
        }
        /// <summary>
        /// Consigna una cantidad de dinero en la cuenta de corriente.
        /// </summary>
        /// <param name="sender">Actividador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnCorrienteConsignar_Click(object sender, EventArgs e)
        {
            string valor = string.Empty;
            Ayudante.InputBox("Consignación Cuenta Corriente", "Introduzca el valor de la consigación", ref valor);

            decimal valorDecimal;

            if(Decimal.TryParse(valor, out valorDecimal))
            {
                principal.ConsignarCorriente(valorDecimal);
                principal.ActualizarCliente();
            }
            else
            {
                MessageBox.Show(this, "El valor introducido no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Retira una cantidad de dinero de la cuenta corriente.
        /// </summary>
        /// <param name="sender">Actividador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnCorrienteRetirar_Click(object sender, EventArgs e)
        {
            string valor = string.Empty;
            Ayudante.InputBox("Retiro Cuenta Corriente", "Introduzca el valor del retiro", ref valor);

            decimal valorDecimal;

            if (Decimal.TryParse(valor, out valorDecimal))
            {
                principal.RetirarCorriente(valorDecimal);
                principal.ActualizarCliente();
            }
            else
            {
                MessageBox.Show(this, "El valor introducido no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Consigna una cantidad de dinero en la cuenta de ahorros.
        /// </summary>
        /// <param name="sender">Actividador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnAhorrosConsignar_Click(object sender, EventArgs e)
        {
            string valor = string.Empty;
            Ayudante.InputBox("Consignación Cuenta Ahorros", "Introduzca el valor de la consigación", ref valor);

            decimal valorDecimal;

            if (Decimal.TryParse(valor, out valorDecimal))
            {
                principal.ConsignarAhorros(valorDecimal);
                principal.ActualizarCliente();
            }
            else
            {
                MessageBox.Show(this, "El valor introducido no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Retira una cantidad de dinero de la cuenta de ahorros.
        /// </summary>
        /// <param name="sender">Actividador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnAhorrosRetirar_Click(object sender, EventArgs e)
        {
            string valor = string.Empty;
            Ayudante.InputBox("Retiro Cuenta Ahorros", "Introduzca el valor del retiro", ref valor);

            decimal valorDecimal;

            if (Decimal.TryParse(valor, out valorDecimal))
            {
                principal.RetirarAhorros(valorDecimal);
                principal.ActualizarCliente();
            }
            else
            {
                MessageBox.Show(this, "El valor introducido no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Activa el punto de extensión (1).
        /// </summary>
        /// <param name="sender">Actividador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            principal.Extension1();
        }
        /// <summary>
        /// Activa el punto de extensión (2).
        /// </summary>
        /// <param name="sender">Actividador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            principal.Extension2();
        }
        #endregion
    }
}
