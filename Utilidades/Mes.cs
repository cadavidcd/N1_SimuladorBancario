using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_SimuladorBancario.Utilidades
{
    /// <summary>
    /// Representa un mes en la secuencia de la simulación.
    /// </summary>
    public class Mes
    {
        #region Atributos
        /// <summary>
        /// Representa el número de mes actual en la transición del tiempo.
        /// </summary>
        private int numeroMes;
        #endregion
        
        #region Propiedades
        /// <summary>
        /// Representa el número de mes actual en la transición del tiempo.
        /// </summary>
        public int NumeroMes 
        { 
            get
            {
                return numeroMes;
            }
            set
            {
                numeroMes = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Inicia una instancia de `Mes` con un valor.
        /// </summary>
        /// <param name="mes">Número del mes con el que se crea la instancia de mes.</param>
        public Mes(int mes)
        {
            numeroMes = mes;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Calcula la diferencia de dos meses.
        /// </summary>
        /// <param name="mes">Mes con el que se debe establecer la diferencia de número de meses.</param>
        /// <returns></returns>
        public int DiferenciaMeses(Mes mes)
        {
            return numeroMes - mes.NumeroMes;
        }

        /// <summary>
        /// Avanza en una unidad el número de mes.
        /// </summary>
        public void AvanzarMes()
        {
            ++numeroMes;
        }
        #endregion
    }
}
