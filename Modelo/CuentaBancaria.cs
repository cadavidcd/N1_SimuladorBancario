using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N1_SimuladorBancario.Utilidades;

namespace N1_SimuladorBancario.Modelo
{
    /// <summary>
    /// Entidad que simula una cuenta bancaria.
    /// </summary>
    public class CuentaBancaria
    {
        #region Atributos
        /// <summary>
        /// Cédula del propietario de la cuenta.
        /// </summary>
        private string cedula;
        /// <summary>
        /// Nombre del propietario de la cuenta.
        /// </summary>
        private string nombre;
        /// <summary>
        /// Mes actual de la simulación.
        /// </summary>
        private Mes mesActual;
        /// <summary>
        /// Cuenta corrienta de esta cuenta bancaria.
        /// </summary>
        private CuentaCorriente corriente;
        /// <summary>
        /// Cuenta de ahorros de esta cuenta de bancaria.
        /// </summary>
        private CuentaAhorros ahorros;
        /// <summary>
        /// CDT de esta cuenta bancaria.
        /// </summary>
        private CDT inversion;
        #endregion

        #region Propiedades
        /// <summary>
        /// Accede y modifica el nombre del propietario de esta cuenta bancaria.
        /// </summary>
        public string Nombre 
        { 
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        /// <summary>
        /// Accede y modifica la cédula del propietario de esta cuenta bancaria.
        /// </summary>
        public string Cedula 
        { 
            get
            {
                return cedula;
            }
            set
            {
                cedula = value;
            }
        }
        /// <summary>
        /// Accede y modifica el mes actual de la simulación.
        /// </summary>
        public Mes MesActual
        {
            get
            {
                return mesActual;
            }
            set
            {
                mesActual = value;
            }
        }
        /// <summary>
        /// Accede y modifica la cuenta de ahorros de esta cuenta bancaria.
        /// </summary>
        public CuentaAhorros Ahorros 
        {
            get
            {
                return ahorros;
            }
            set
            {
                ahorros = value;
            }
        }
        /// <summary>
        /// Accede y modifica la cuenta corriente de esta cuenta bancaria.
        /// </summary>
        public CuentaCorriente Corriente 
        {
            get
            {
                return corriente;
            }
            set
            {
                corriente = value;
            }
        }
        /// <summary>
        /// Accede y modifica el CDT de esta cuenta bancaria.
        /// </summary>
        public CDT Inversion
        {
            get
            {
                return inversion;
            }
            set
            {
                inversion = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa una instancia de `CuentaBancaria` con la cédula y el nombre del propietario de la cuenta.
        /// </summary>
        /// <param name="cedula">Número de cédula del propietario de la cuenta.</param>
        /// <param name="nombre">Nombre completo del propietario de la cuenta.</param>
        public CuentaBancaria(string cedula, string nombre)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            mesActual = new Mes(0);
            corriente = new CuentaCorriente();
            ahorros = new CuentaAhorros();
            inversion = new CDT();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Inicia la inversión en un CDT.
        /// </summary>
        /// <param name="monto">Monto de la inversión en el CDT.</param>
        /// <param name="interesMensual">Interés sobre la inversión del CDT.</param>
        public void InvertirCDT(decimal monto, decimal interesMensual)
        {
            inversion.Invertir(monto, interesMensual, mesActual.NumeroMes);
        }
        /// <summary>
        /// Consigna una cantidad de dinero en la cuenta corriente.
        /// </summary>
        /// <param name="valor"></param>
        public void ConsignarCuentaCorriente(decimal valor)
        {
            corriente.ConsignarValor(valor);
        }
        /// <summary>
        /// Consigna una cantidad de dinero en la cuenta de ahorros.
        /// </summary>
        /// <param name="valor"></param>
        public void ConsignarCuentaAhorro(decimal valor)
        {
            ahorros.ConsigarValor(valor);
        }
        /// <summary>
        /// Cierra el CDT.
        /// </summary>
        public void CerrarCDT()
        {
            corriente.ConsignarValor(inversion.Cerrar(mesActual));
        }
        /// <summary>
        /// Retira una cantidad de dinero de la cuenta corriente.
        /// </summary>
        /// <param name="valor">Cantidad de dinero a retirar.</param>
        public void RetirarCuentaCorriente(decimal valor)
        {
            corriente.RetirarValor(valor);
        }
        /// <summary>
        /// Retira una cantidad de dinero de la cuenta de ahorros.
        /// </summary>
        /// <param name="valor"></param>
        public void RetirarCuentaAhorro(decimal valor)
        {
            ahorros.RetirarValor(valor);
        }
        /// <summary>
        /// Calcula el saldo total sobre las tres cuentas.
        /// </summary>
        /// <returns>Cantidad de dinero en la cuenta bancaria.</returns>
        public decimal CalcularSaldoTotal()
        {
            return corriente.Saldo + ahorros.Saldo + inversion.ValorPresente(mesActual);
        }
        /// <summary>
        /// Avanza en un mes la simulación de las tres cuentas.
        /// </summary>
        public void AvanzarMesSimulacion()
        {
            mesActual.AvanzarMes();

            ahorros.ActualizarSaldoTransicionMes();
        }
        #endregion

        #region Método de extensión
        /// <summary>
        /// Punto de extensión (1).
        /// </summary>
        /// <returns>Valor de respuesta del método de extensión.</returns>
        public string PuntoExtension1()
        {
            return "Respuesta 1";
        }
        /// <summary>
        /// Punto de extensión (2).
        /// </summary>
        /// <returns>Valor de respuesta del método de extensión.</returns>
        public string PuntoExtension2()
        {
            return "Respuesta 2";
        }
        #endregion
    }
}
