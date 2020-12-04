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

namespace N1_SimuladorBancario.GUI
{
    /// <summary>
    /// Control con los datos del propietario de la cuenta bancaria.
    /// </summary>
    public partial class ControlDatosCliente : UserControl
    {
        #region Atributos
        /// <summary>
        /// Referencia al formulario principal de la aplicación.
        /// </summary>
        Principal principal;
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una instancia de `ControlDatosCliente`.
        /// </summary>
        /// <param name="ventanaPrincipal">Referebcua al formulario principal.</param>
        public ControlDatosCliente(Principal ventanaPrincipal)
        {
            InitializeComponent();
            principal = ventanaPrincipal;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Actualiza el nombre del propietario de la cuenta bancaria.
        /// </summary>
        /// <param name="nuevoNombre">Nombre del propietario de la cuenta bancaria.</param>
        public void ActualizarNombre(string nuevoNombre)
        {
            txtNombre.Text = nuevoNombre;
        }
        /// <summary>
        /// Actualiza el número de la cédula del propietario de la cuenta bancaria.
        /// </summary>
        /// <param name="nuevaCedula"></param>
        public void ActualizarCedula(string nuevaCedula)
        {
            txtCedula.Text = nuevaCedula;
        }
        /// <summary>
        /// Actualiza el número de mes de la simulación.
        /// </summary>
        /// <param name="mes">Número del mes.</param>
        public void ActualizarMes(int mes)
        {
            txtMesActual.Text = mes.ToString();
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Avanza en una unidad (mes) la simulación.
        /// </summary>
        /// <param name="sender">Actividador del evento.</param>
        /// <param name="e">Datos del evento.</param>
        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            principal.AvanzarMesSimulacion();

            principal.ActualizarCliente();
        }
        #endregion
    }
}
