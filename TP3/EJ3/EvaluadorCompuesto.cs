using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class EvaluadorCompuesto : IEvaluador
    {

        private List<IEvaluador> iEvaluadores = new List<IEvaluador> {};

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            IEnumerator<IEvaluador> enumerador = this.iEvaluadores.GetEnumerator();
            bool esValida = true;
            while (esValida && enumerador.MoveNext())
            {
                esValida = enumerador.Current.EsValida(pSolicitud);
            }
            return esValida;

        }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            this.iEvaluadores.Add(pEvaluador);
        }



        

    }
}
