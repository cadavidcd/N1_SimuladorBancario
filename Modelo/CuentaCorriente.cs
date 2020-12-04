using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_SimuladorBancario.Modelo
{
    /// <summary>
    /// Entidad que modela el funcionamiento de una cuenta corriente.
    /// </summary>
    public class CuentaCorriente
    {
        #region Atributos
        /// <summary>
        /// Saldo de la cuenta corriente.
        /// </summary>
        private decimal saldo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Representa el saldo de la cuenta corriente.
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
        /// Inicializa una instancia de `CuentaCorriente` con saldo en cero.
        /// </summary>
        public CuentaCorriente()
        {
            saldo = 0.0M;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Consigna un valor en la cuenta corriente.
        /// </summary>
        /// <param name="valor">Valor a consignar en la cuenta.</param>
        public void ConsignarValor(decimal valor)
        {
            saldo += valor;
        }

        /// <summary>
        /// Retira un valor de la cuenta corriente.
        /// </summary>
        /// <param name="valor">Valor a retirar de la cuenta.</param>
        public void RetirarValor(decimal valor)
        {
            saldo -= valor;
        }
        #endregion
    }
}
