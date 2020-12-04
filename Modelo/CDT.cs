using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N1_SimuladorBancario.Utilidades;

namespace N1_SimuladorBancario.Modelo
{
    /// <summary>
    /// Entidad que representa el funcionamiento de un CDT.
    /// </summary>
    public class CDT
    {
        #region Atributos
        /// <summary>
        /// Valor de la inversión.
        /// </summary>
        private decimal valorInvertido;
        /// <summary>
        /// Interés mensual sobre la inversión.
        /// </summary>
        private decimal interesMensual;
        /// <summary>
        /// Representa el mes de apertura.
        /// </summary>
        private Mes mesApertura;
        #endregion

        #region Propiedades
        /// <summary>
        /// Accede y modifica el valor invertido en el CDT.
        /// </summary>
        public decimal ValorInvertido 
        { 
            get
            {
                return valorInvertido;
            }
        }
        /// <summary>
        /// Accede al interés sobre la inversión.
        /// </summary>
        public decimal InteresMensual 
        { 
            get
            {
                return interesMensual;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Crea una instancia de `CDT` con valores por defecto.
        /// </summary>
        public CDT()
        {
            valorInvertido = 0.0M;
            interesMensual = 0.0M;
            mesApertura = new Mes(0);
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Inicia una inversión.
        /// </summary>
        /// <param name="valor">Cantidad de dinero a invertir.</param>
        /// <param name="interes">Interés sobre la inversión.</param>
        /// <param name="numeroMes">Número del mes de la inversión.</param>
        public void Invertir(decimal valor, decimal interes, int numeroMes)
        {
            valorInvertido = valor;
            interesMensual = interes;
            mesApertura = new Mes(numeroMes);
        }
        /// <summary>
        /// Calcula el valor presente de la inversión.
        /// </summary>
        /// <param name="mesActual">Número del més sobre el que se calculara el saldo.</param>
        /// <returns>Saldo del CDT hasta la fecha.</returns>
        public decimal ValorPresente(Mes mesActual)
        {
            int mesesTranscurridos = mesActual.DiferenciaMeses(mesApertura);
            return valorInvertido + (mesesTranscurridos * interesMensual * valorInvertido);
        }
        /// <summary>
        /// Cierra el CDT.
        /// </summary>
        /// <param name="mesActual">Mes en el que se cierrar el CDT.</param>
        /// <returns>Valor del cierre del CDT.</returns>
        public decimal Cerrar(Mes mesActual)
        {
            decimal valorCierre = ValorPresente(mesActual);
            valorInvertido = 0.0M;
            interesMensual = 0.0M;
            mesApertura.NumeroMes = 0;
            return valorCierre;
        }
        #endregion
    }
}
