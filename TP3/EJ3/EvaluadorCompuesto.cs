using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class EvaluadorCompuesto : IEvaluador
    {

        List<IEvaluador> iEvaluadores;

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            foreach (IEvaluador evaluador in this.iEvaluadores)
            {
                if (!evaluador.EsValida(pSolicitud))
                    return false;
            }

            return true;
        }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            this.iEvaluadores.Add(pEvaluador);
        }



        

    }
}
