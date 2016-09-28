using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class GestorPrestamos
    {

        Dictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente;

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return iEvaluadoresPorCliente[pSolicitud.Cliente.TipoCliente].EsValida(pSolicitud);
        }
    }
}
