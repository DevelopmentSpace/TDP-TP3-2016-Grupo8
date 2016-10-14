using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class EvaluadorCantidadCuotas :IEvaluador
    {
        int iCantidadMaximaCuotas;

        /// <summary>
        /// Constructor del evaluador de la maxima cantidad de cuotas.
        /// </summary>
        /// <param name="pCantidadMaxima">Maxima cantidad de cuotas en meses.</param>
        public EvaluadorCantidadCuotas(int pCantidadMaxima)
        {
            this.iCantidadMaximaCuotas = pCantidadMaxima;
        }

        /// <summary>
        /// Verifica que la cantidad de cuotas sea menor que la maxima cantidad de cuotas.
        /// </summary>
        /// <param name="pSolicitud">Solicitud de prestamo</param>
        /// <returns>true si es valida la solicitud para este evaluador. false si no lo es.</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return (pSolicitud.CantidadCuotas) <= (this.iCantidadMaximaCuotas);
        }
    }
}
