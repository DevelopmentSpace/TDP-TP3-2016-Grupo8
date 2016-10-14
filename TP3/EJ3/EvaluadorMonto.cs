using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class EvaluadorMonto : IEvaluador
    {
        double iMontoMaximo;

        /// <summary>
        /// Constructor del evaluador de monto. 
        /// </summary>
        /// <param name="pMontoMinimo">Monto minimo</param>
        public EvaluadorMonto(double pMontoMinimo)
        {
            this.iMontoMaximo = pMontoMinimo;
        }

        /// <summary>
        /// Valida que el monto sea menor que el monto maximo.
        /// </summary>
        /// <param name="pSolicitud">Solicitud de prestamo</param>
        /// <returns>true si cumple la condicion, false si no la cumple</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return  (pSolicitud.Monto) <= (this.iMontoMaximo);
        }
    }
}
