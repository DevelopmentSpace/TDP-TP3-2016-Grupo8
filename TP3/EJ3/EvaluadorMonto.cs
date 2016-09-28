using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class EvaluadorMonto : IEvaluador
    {
        double iMontoMinimo;

        public EvaluadorMonto(double pMontoMinimo)
        {
            this.iMontoMinimo = pMontoMinimo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return  (pSolicitud.Monto) >= (this.iMontoMinimo);
        }
    }
}
