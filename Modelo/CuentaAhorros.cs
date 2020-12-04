using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_SimuladorBancario.Modelo
{
    /// <summary>
    /// Entidad que representa una cuenta de ahorros del modelo.
    /// </summary>
    public class CuentaAhorros
    {
        #region Atributos
        /// <summary>
        /// Saldo de la cuenta de ahorros.
        /// </summary>
        private decimal saldo;
        /// <summary>
        /// Interés mensual de la cuenta de ahorros.
        /// </summary>
        private decimal interesMensual;
        #endregion

        #region Propiedades
        /// <summary>
        /// Accede el interés mensual de la cuenta de ahorros.
        /// </summary>
        public decimal InteresMensual 
        { 
            get
            {
                return 0.006M;
            }
        }
        /// <summary>
        /// Accede y modifica el saldo de la cuenta de ahorros.
        /// </summary>
        public decimal Saldo 
        { 
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa una instancia de `CuentaAhorros` con valores por defecto.
        /// </summary>
        public CuentaAhorros()
        {
            saldo = 0.0M;
            interesMensual = InteresMensual;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Consigna un valor en la cuenta.
        /// </summary>
        /// <param name="valor">Cantidad de dinero a consignar en la cuenta.</param>
        public void ConsigarValor(decimal valor)
        {
            saldo += valor;
        }
        /// <summary>
        /// Retira un valor de la cuenta de ahorros.
        /// </summary>
        /// <param name="valor">Cantidad de dinero a retirar.</param>
        public void RetirarValor(decimal valor)
        {
            saldo -= valor;
        }
        /// <summary>
        /// Actualiza el saldo cuando se transita al siguiente mes.
        /// </summary>
        public void ActualizarSaldoTransicionMes()
        {
            saldo += saldo * interesMensual;
        }
        #endregion
    }
}
