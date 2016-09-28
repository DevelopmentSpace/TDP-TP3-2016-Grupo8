using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class AdmClientes
    {
        List<Cliente> iClientes;

        public AdmClientes()
        {
            iClientes = new List<Cliente>();
        }

        public void AgregarCliente(string pNombre, string pApellido,DateTime pFechaNacimiento,double sueldo,DateTime pFechaIngreso )
        {
            Empleo empleo = new Empleo(sueldo, pFechaIngreso);
            Cliente cliente = new Cliente(pNombre, pApellido, pFechaNacimiento, empleo);
            iClientes.Add(cliente);
        }

        public void CambiarTipoCliente(Cliente pCliente, TipoCliente pTipoCliente)
        {
            pCliente.TipoCliente = pTipoCliente;
        }

        public Cliente BuscarCliente(string pNombre,string pApellido)
        {
            foreach (Cliente cliente in iClientes)
            {
                if (cliente.Nombre == pNombre && cliente.Apellido == pApellido)
                {
                    return cliente;
                }
            }
            throw new Exception("No existe cliente");
        }


    }
}
