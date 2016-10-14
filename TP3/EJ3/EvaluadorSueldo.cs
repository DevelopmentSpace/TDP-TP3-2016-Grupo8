using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class EvaluadorSueldo : IEvaluador
    {
        double iSueldoMinimo;

        /// <summary>
        /// Constructor del evaluador del sueldo.
        /// </summary>
        /// <param name="pSueldoMinimo">Sueldo minimo</param>
        public EvaluadorSueldo(double pSueldoMinimo)
        {
            this.iSueldoMinimo = pSueldoMinimo;
        }

        /// <summary>
        /// Verifica que el sueldo minimo sea menor que el sueldo del cliente.
        /// </summary>
        /// <param name="pSolicitud">Solicitud de prestamo</param>
        /// <returns>true si el sueldo cumple con la condicion. false si no lo es.</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return (this.iSueldoMinimo <= pSolicitud.Cliente.Empleo.Sueldo);
        }
    }
}
