using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class EvaluadorAntiguedadLaboral : IEvaluador
    {
        //Expresada en meses
        int iAntiguedadMinima;


        /// <summary>
        /// Constructor del evaluador de antiguedad laboral.
        /// </summary>
        /// <param name="pAntiguedadMinima">Antiguedad minima en el trabajo en meses.</param>
        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }

        /// <summary>
        /// Verifica que la solicitud que se le pasa es valida.
        /// </summary>
        /// <param name="pSolicitud">Una solicitud de prestamo</param>
        /// <returns>true si es valida la solicitud para este evaluador. false si no lo es. </returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return Date.DiferenciaEnMeses(DateTime.Today , pSolicitud.Cliente.Empleo.FechaIngreso) >= (this.iAntiguedadMinima);
        }
    }
}
