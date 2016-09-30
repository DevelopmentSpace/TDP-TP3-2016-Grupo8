using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Cliente
    {

        String iNombre, iApellido;
        DateTime iFechaNacimiento;
        TipoCliente iTipoCliente;
        Empleo iEmpleo;



        public Cliente(String pNombre, String pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iEmpleo = pEmpleo;

            this.iTipoCliente = TipoCliente.NoCliente;
        }

        public String Nombre
        {
            get { return this.iNombre; }
        }

        public String Apellido
        {
            get { return this.iApellido; }
        }

        public DateTime FechaNacimiento
        {
            get { return this.iFechaNacimiento; }
        }

        public Empleo Empleo
        {
            get { return this.iEmpleo; }
        }

        public TipoCliente TipoCliente
        {
            get { return this.iTipoCliente; }
            set { this.iTipoCliente = value; }
        }

    }
}
