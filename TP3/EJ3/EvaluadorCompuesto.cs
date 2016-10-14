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

        /// <summary>
        /// Comprueba todos los evaluadores en el diccionario son validos. 
        /// </summary>
        /// <param name="pSolicitud">Solicitud</param>
        /// <returns>True si la solicitud es valida. False si la solicitud no es valida</returns>
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

        /// <summary>
        /// Agrega un evaluador en el diccionario de evaluadores.
        /// </summary>
        /// <param name="pEvaluador">Evaluador</param>
        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            this.iEvaluadores.Add(pEvaluador);
        }



        

    }
}
