﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class GestorPrestamos
    {

        Dictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente;

        public GestorPrestamos()
        {
            //Agregamos evaluadores para cada cliente
            iEvaluadoresPorCliente[TipoCliente.NoCliente] = EvaluadorNoCliente();
            iEvaluadoresPorCliente[TipoCliente.Cliente] = EvaluadorCliente();
            iEvaluadoresPorCliente[TipoCliente.ClienteGold] = EvaluadorClienteGold();
            iEvaluadoresPorCliente[TipoCliente.ClientePlatinum] = EvaluadorClientePlatinum();

        }

        public IEvaluador EvaluadorNoCliente()
        {
            EvaluadorCompuesto eval = new EvaluadorCompuesto();

            eval.AgregarEvaluador(EvaluadorGeneral());
            eval.AgregarEvaluador(new EvaluadorMonto(20000));
            eval.AgregarEvaluador(new EvaluadorCantidadCuotas(12));

            return eval;
        }

        public IEvaluador EvaluadorCliente()
        {
            EvaluadorCompuesto eval = new EvaluadorCompuesto();

            eval.AgregarEvaluador(EvaluadorGeneral());
            eval.AgregarEvaluador(new EvaluadorMonto(100000));
            eval.AgregarEvaluador(new EvaluadorCantidadCuotas(32));

            return eval;
        }

        public IEvaluador EvaluadorClienteGold()
        {
            EvaluadorCompuesto eval = new EvaluadorCompuesto();

            eval.AgregarEvaluador(EvaluadorGeneral());
            eval.AgregarEvaluador(new EvaluadorMonto(150000));
            eval.AgregarEvaluador(new EvaluadorCantidadCuotas(60));

            return eval;
        }

        public IEvaluador EvaluadorClientePlatinum()
        {
            EvaluadorCompuesto eval = new EvaluadorCompuesto();

            eval.AgregarEvaluador(EvaluadorGeneral());
            eval.AgregarEvaluador(new EvaluadorMonto(200000));
            eval.AgregarEvaluador(new EvaluadorCantidadCuotas(60));

            return eval;
        }



        public IEvaluador EvaluadorGeneral()
        {
            EvaluadorCompuesto eval = new EvaluadorCompuesto();

            eval.AgregarEvaluador(new EvaluadorEdad(18, 75));
            eval.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));
            eval.AgregarEvaluador(new EvaluadorSueldo(5000));

            return eval;
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return iEvaluadoresPorCliente[pSolicitud.Cliente.TipoCliente].EsValida(pSolicitud);
        }
    }
}
