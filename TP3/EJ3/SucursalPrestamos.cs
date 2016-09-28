using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class SucursalPrestamos
    {
        GestorPrestamos iGestorPrestamos = new GestorPrestamos();
        AdmClientes iAdmClientes = new AdmClientes();

        public SucursalPrestamos(AdmClientes pAdmClientes)
        {
            iAdmClientes = pAdmClientes;
        }

        public bool SolicitarPrestamo(string pNombre, string pApellido,double pMonto,int pCantidadCuotas)
        {
            Cliente cliente;

            try
            {
               cliente = iAdmClientes.BuscarCliente(pNombre, pApellido);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                throw;
            }

            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, pMonto, pCantidadCuotas);
            if (iGestorPrestamos.EsValida(solicitud))
                return true;
            return false;
            
            
        }
    }
}
