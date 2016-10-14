using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class SolicitudPrestamo
    {

        double iMonto;
        int iCantidadCuotas;

        Cliente iCliente;

        /// <summary>
        /// Constructor de la solicitud de prestamo
        /// </summary>
        /// <param name="pCliente">Cliente</param>
        /// <param name="pMonto">Monto</param>
        /// <param name="pCantidadCuotas">Cantidad de cuotas en meses</param>
        public SolicitudPrestamo(Cliente pCliente, double pMonto, int pCantidadCuotas)
        {
            this.iCliente = pCliente;
            this.iMonto = pMonto;
            this.iCantidadCuotas = pCantidadCuotas;
        }

        /// <summary>
        /// Devuelve el monto de una solicitud de prestamos
        /// </summary>
        public double Monto
        {
            get { return this.iMonto; }
        }

        /// <summary>
        /// Devuelve la cantidad de cuotas de una solicitud de prestamo.
        /// </summary>
        public int CantidadCuotas
        {
            get { return this.iCantidadCuotas; }
        }

        /// <summary>
        /// Devuelve el cliente de una solicitud de prestamo.
        /// </summary>
        public Cliente Cliente
        {
            get { return this.iCliente; }
        }
    }
}
