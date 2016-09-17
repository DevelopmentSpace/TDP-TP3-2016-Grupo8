using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class EvaluadorAntiguedadLaboral : IEvaluador
    {

        int iAntiguedadMinima;

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return (DateTime.Now - pSolicitud.Cliente.Empleo.FechaIngreso).Days >= (this.iAntiguedadMinima*365);//REVISAR 
        }
    }
}
