using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class EvaluadorEdad : IEvaluador
    {

        int iEdadMinima, iEdadMaxima;

        /// <summary>
        /// Constructor del evaluador de edad con una edad minima y una edad maxima.
        /// </summary>
        /// <param name="pEdadMinima">Edad minima</param>
        /// <param name="pEdadMaxima">Edad maxima</param>
        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMinima = pEdadMinima;
            this.iEdadMaxima = pEdadMaxima;
        }

        /// <summary>
        /// Verifica que la edad de la solicitud este entre los valores del evaluador.
        /// </summary>
        /// <param name="pSolicitud">Solicitud de prestamo</param>
        /// <returns>true si la edad cumple con la condicion. false si la edad no cumple la condicion</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            int edad = Date.EdadActual(pSolicitud.Cliente.FechaNacimiento);
            return (edad >= this.iEdadMinima) && (edad <= this.iEdadMaxima);
        }

    }
}
