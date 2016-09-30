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

        public EvaluadorMonto(double pMontoMinimo)
        {
            this.iMontoMaximo = pMontoMinimo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return  (pSolicitud.Monto) <= (this.iMontoMaximo);
        }
    }
}
