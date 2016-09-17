using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class EvaluadorEdad
    {

        int iEdadMinima, iEdadMaxima;

        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMinima = pEdadMinima;
            this.iEdadMaxima = pEdadMaxima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            //int edad = (DateTime.Now - pSolicitud.Cliente.FechaNacimiento);
            //return ()
        }

    }
}
