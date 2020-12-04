using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N1_SimuladorBancario.GUI;
using N1_SimuladorBancario.Modelo;

namespace N1_SimuladorBancario
{
    /// <summary>
    /// Representa el formulario principal de la aplicación.
    /// </summary>
    public partial class Principal : Form
    {
        #region Controles
        /// <summary>
        /// Control con los datos del cliente.
        /// </summary>
        ControlDatosCliente ctlDatosCliente;
        /// <summary>
        /// Control con las operaciones posibles de las cuentas.
        /// </summary>
        ControlOpciones ctlOpciones;
        /// <summary>
        /// Control que contiene los controles para la visualización de los saldos de la cuenta.
        /// </summary>
        ControlSaldos ctlSaldos;
        /// <summary>
        /// Cuenta bancaria.
        /// </summary>
        private CuentaBancaria cuentaBancaria;
        #endregion

        #region Constructores
        /// <summary>
        /// Crea instancia de `Principal` con una cuenta bancaria.
        /// </summary>
        /// <param name="cuentaBancaria">Cuenta bancaria a manipular.</param>
        public Principal(CuentaBancaria cuentaBancaria)
        {
            InitializeComponent();
            CargarControlesPersonalizados();
            this.cuentaBancaria = cuentaBancaria;
            ActualizarCliente();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Carga los controles de la interfaz.
        /// </summary>
        private void CargarControlesPersonalizados()
        {
            ctlDatosCliente = new ControlDatosCliente(this);

            ctlSaldos = new ControlSaldos();
            ctlSaldos.Location = new Point(0, 93);

            ctlOpciones = new ControlOpciones(this);
            ctlOpciones.Location = new Point(0, 240);

            this.Icon = Properties.Resources.Banco;

            this.Controls.Add(ctlDatosCliente);
            this.Controls.Add(ctlSaldos);
            this.Controls.Add(ctlOpciones);
        }
        /// <summary>
        /// Actualiza los datos del cliente cuando ocurren cambios.
        /// </summary>
        public void ActualizarCliente()
        {
            ctlDatosCliente.ActualizarNombre(cuentaBancaria.Nombre);
            ctlDatosCliente.ActualizarCedula(cuentaBancaria.Cedula);
            ctlDatosCliente.ActualizarMes(cuentaBancaria.MesActual.NumeroMes);

            ctlSaldos.ActualizarSaldoActual(cuentaBancaria.CalcularSaldoTotal());
            ctlSaldos.ActualizarSaldoCorriente(cuentaBancaria.Corriente.Saldo);
            ctlSaldos.ActualizarSaldoAhorros(cuentaBancaria.Ahorros.Saldo);
            ctlSaldos.ActualizarSaldoCDT(cuentaBancaria.Inversion.ValorPresente(cuentaBancaria.MesActual));
        }
        /// <summary>
        /// Abre un nuevo CDT.
        /// </summary>
        /// <param name="valor">Cantidad de dinero a invertir.</param>
        /// <param name="interes">Interés sobre la inversión.</param>
        public void InvertirCDT(decimal valor, decimal interes)
        {
            if (valor != 0)
            {
                cuentaBancaria.InvertirCDT(valor, interes / 100);
            }
        }
        /// <summary>
        /// Cierra el CDT.
        /// </summary>
        public void CerrarCDT()
        {
            cuentaBancaria.CerrarCDT();
        }
        /// <summary>
        /// Retira una cantidad de dinero de la cuenta de ahorros.
        /// </summary>
        /// <param name="valor">Cantidad de dinero a retirar.</param>
        public void RetirarAhorros(decimal valor)
        {
            cuentaBancaria.RetirarCuentaAhorro(valor);
        }
        /// <summary>
        /// Consigna una cantidad de dinero sobre la cuenta de ahorros.
        /// </summary>
        /// <param name="valor">Cantidad de dinero a consignar.</param>
        public void ConsignarAhorros(decimal valor)
        {
            cuentaBancaria.ConsignarCuentaAhorro(valor);
        }
        /// <summary>
        /// Retira una cantidad de dinero de la cuenta corriente.
        /// </summary>
        /// <param name="valor"></param>
        public void RetirarCorriente(decimal valor)
        {
            cuentaBancaria.RetirarCuentaCorriente(valor);
        }
        /// <summary>
        /// Consigna una cantidad de dinero de la cuenta corriente.
        /// </summary>
        /// <param name="valor"></param>
        public void ConsignarCorriente(decimal valor)
        {
            cuentaBancaria.ConsignarCuentaCorriente(valor);
        }
        /// <summary>
        /// Avanza en un mes la simulación.
        /// </summary>
        public void AvanzarMesSimulacion()
        {
            cuentaBancaria.AvanzarMesSimulacion();
        }
        #endregion

        #region Métodos de extensión
        /// <summary>
        /// Punto de extensión (1).
        /// </summary>
        public void Extension1()
        {
            MessageBox.Show(this, cuentaBancaria.PuntoExtension1(), "Punto de Extensión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Punto de extensión (2).
        /// </summary>
        public void Extension2()
        {
            MessageBox.Show(this, cuentaBancaria.PuntoExtension2(), "Punto de Extensión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
