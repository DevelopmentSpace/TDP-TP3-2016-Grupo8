using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class GestorPrestamos
    {

        Dictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente = new Dictionary<TipoCliente, IEvaluador> { };

        /// <summary>
        /// Constructor del gestor de prestamos 
        /// </summary>
        public GestorPrestamos()
        {
            //Agregamos evaluadores para cada cliente
            iEvaluadoresPorCliente[TipoCliente.NoCliente] = EvaluadorNoCliente();
            iEvaluadoresPorCliente[TipoCliente.Cliente] = EvaluadorCliente();
            iEvaluadoresPorCliente[TipoCliente.ClienteGold] = EvaluadorClienteGold();
            iEvaluadoresPorCliente[TipoCliente.ClientePlatinum] = EvaluadorClientePlatinum();

        }

        /// <summary>
        /// Crea los evaluadores de un no cliente.
        /// </summary>
        /// <returns>Evaluadores de no cliente</returns>
        private IEvaluador EvaluadorNoCliente()
        {
            EvaluadorCompuesto eval = new EvaluadorCompuesto();

            eval.AgregarEvaluador(EvaluadorGeneral());
            eval.AgregarEvaluador(new EvaluadorMonto(20000));
            eval.AgregarEvaluador(new EvaluadorCantidadCuotas(12));

            return eval;
        }

        /// <summary>
        /// Crea los evaluadores de un cliente.
        /// </summary>
        /// <returns>Evaluadores de cliente</returns>
        private IEvaluador EvaluadorCliente()
        {
            EvaluadorCompuesto eval = new EvaluadorCompuesto();

            eval.AgregarEvaluador(EvaluadorGeneral());
            eval.AgregarEvaluador(new EvaluadorMonto(100000));
            eval.AgregarEvaluador(new EvaluadorCantidadCuotas(32));

            return eval;
        }

        /// <summary>
        /// Crea los evaluadores de un cliente gold.
        /// </summary>
        /// <returns>Evaluadores de cliente gold</returns>
        private IEvaluador EvaluadorClienteGold()
        {
            EvaluadorCompuesto eval = new EvaluadorCompuesto();

            eval.AgregarEvaluador(EvaluadorGeneral());
            eval.AgregarEvaluador(new EvaluadorMonto(150000));
            eval.AgregarEvaluador(new EvaluadorCantidadCuotas(60));

            return eval;
        }

        /// <summary>
        /// Crea los evaluadores de un cliente platinum.
        /// </summary>
        /// <returns>Evaluadores de cliente platinum</returns>
        private IEvaluador EvaluadorClientePlatinum()
        {
            EvaluadorCompuesto eval = new EvaluadorCompuesto();

            eval.AgregarEvaluador(EvaluadorGeneral());
            eval.AgregarEvaluador(new EvaluadorMonto(200000));
            eval.AgregarEvaluador(new EvaluadorCantidadCuotas(60));

            return eval;
        }


        /// <summary>
        /// Crea los evaladurores para todos.
        /// </summary>
        /// <returns>Evaluadores generales</returns>
        private IEvaluador EvaluadorGeneral()
        {
            EvaluadorCompuesto eval = new EvaluadorCompuesto();

            eval.AgregarEvaluador(new EvaluadorEdad(18, 75));
            eval.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));
            eval.AgregarEvaluador(new EvaluadorSueldo(5000));

            return eval;
        }

        /// <summary>
        /// Comprueba todos los evaluadores de el tipo de cliente sean validos.
        /// </summary>
        /// <param name="pSolicitud">Solicitud de prestamo</param>
        /// <returns>True si son todos validos. False si al menos uno no es verdadero.</returns>
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            bool esValida = false;

            if (this.iEvaluadoresPorCliente.ContainsKey(pSolicitud.Cliente.TipoCliente))
            {
                esValida = iEvaluadoresPorCliente[pSolicitud.Cliente.TipoCliente].EsValida(pSolicitud);
            }

            return esValida;
        }
    }
}
