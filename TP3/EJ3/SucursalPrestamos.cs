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

        Dictionary <int, Cliente> Clientes = new Dictionary<int, Cliente> {};

        /// <summary>
        /// Constructor de la sucursal de prestamos. Crea clientes ya definidos con sus respectivos tipos para hacer pruebas.
        /// </summary>
        public SucursalPrestamos()
        {
            //Cada uno de los clientes agregados para hacer las respectivas pruebas.
            Clientes.Add(1, new Cliente("Manuel", "Chichi", new DateTime(1996,06,20), new Empleo(7500, new DateTime(2015, 02, 17))));
            Clientes.Add(2, new Cliente("Agustin", "Caire", new DateTime(1996, 06,6), new Empleo(15500, new DateTime(2014, 03, 17))));
            Clientes.Add(3, new Cliente("Juan Pablo", "Venditti", new DateTime(1996, 05, 28), new Empleo(4500, new DateTime(2016, 06, 10))));
            Clientes.Add(4, new Cliente("Lautaro", "Balsanyaque", new DateTime(1930, 05, 22), new Empleo(8500, new DateTime(1996, 06, 21))));
            Clientes.Add(5, new Cliente("Lautaro", "Zapata", new DateTime(2006, 01, 20), new Empleo(10000, new DateTime(2009, 06, 21))));
            Clientes.Add(6, new Cliente("Marcos", "Massana", new DateTime(1990, 12, 20), new Empleo(500, new DateTime(1996, 06, 21))));
            Clientes.Add(7, new Cliente("Eric", "Ticak", new DateTime(1995, 02, 27), new Empleo(11000, new DateTime(2016, 07, 21))));

            Clientes[1].TipoCliente = TipoCliente.Cliente;
            Clientes[2].TipoCliente = TipoCliente.ClienteGold;
            Clientes[3].TipoCliente = TipoCliente.Cliente;
            Clientes[5].TipoCliente = TipoCliente.ClientePlatinum;
            Clientes[6].TipoCliente = TipoCliente.ClienteGold;
        }

        /// <summary>
        /// Crea una solicitud de prestamo.
        /// </summary>
        /// <param name="id">Id del cliente</param>
        /// <param name="pMonto">Monto del prestamo</param>
        /// <param name="pCantidadCuotas">Cantidad de cuotas en meses</param>
        /// <returns></returns>
        public bool SolicitarPrestamo(int id,double pMonto,int pCantidadCuotas)
        {
            SolicitudPrestamo solicitud = new SolicitudPrestamo(Clientes[id], pMonto, pCantidadCuotas);

            return iGestorPrestamos.EsValida(solicitud);            
        }

        /// <summary>
        /// Obtiene una lista de clientes que posee todos sus datos.
        /// </summary>
        /// <returns>Devuelve una lista con los datos de clientes en un diccionario.</returns>
        public List<Dictionary<string,string>> ObtenerClientes()
        {
            int i = 1;
            List<Dictionary<string, string>> l = new List<Dictionary<string, string>>();

            foreach (var cliente in Clientes)
            {
                
                Dictionary<string, string> d = new Dictionary<string, string>();
                d.Add("id", i.ToString());
                d.Add("nombre",cliente.Value.Nombre);
                d.Add("apellido", cliente.Value.Apellido);

                i++;

                l.Add(d);

            }
            return l;


        }
    }
}
