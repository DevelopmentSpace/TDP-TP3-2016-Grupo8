using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    interface IEvaluador
    {
        /// <summary>
        /// Valida una solicitud de prestamo
        /// </summary>
        /// <param name="pSolicitud">Solicitud de prestamo</param>
        /// <returns>True si es validada. False si no es validada.</returns>
        bool EsValida(SolicitudPrestamo pSolicitud);
    }
}
