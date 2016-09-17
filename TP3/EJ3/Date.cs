using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class Date
    {
        /// <summary>
        /// Calcula la diferencia en meses entre dos fechas
        /// </summary>
        /// <param name="pFecha1">Fecha 1</param>
        /// <param name="pFecha2">Fecha 2</param>
        /// <returns>Numero corespondiente a meses de diferencia</returns>
        public static int DiferenciaEnMeses(DateTime pFecha1, DateTime pFecha2)
        {
            return Math.Abs((pFecha1.Month - pFecha2.Month) + 12 * (pFecha1.Year - pFecha2.Year));
        }

        /// <summary>
        /// Calcula la edad actual en base a fecha de nacimiento
        /// </summary>
        /// <param name="pFechaNacimiento">Fecha de nacimiento</param>
        /// <returns>Numero correspondiente a edad actual</returns>
        public static int EdadActual(DateTime pFechaNacimiento)
        {
            return DateTime.Today.AddTicks(-pFechaNacimiento.Ticks).Year - 1;
        }
    }
}
