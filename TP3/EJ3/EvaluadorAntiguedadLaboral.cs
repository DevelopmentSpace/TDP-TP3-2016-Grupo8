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

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return Date.DiferenciaEnMeses(DateTime.Today , pSolicitud.Cliente.Empleo.FechaIngreso) >= (this.iAntiguedadMinima);
        }
    }
}
