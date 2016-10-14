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


        /// <summary>
        /// Constructor de la clase cliente
        /// </summary>
        /// <param name="pNombre">Una cadena de caracteres que sera el nombre</param>
        /// <param name="pApellido">Una cadena de caracteres que sera el apellido</param>
        /// <param name="pFechaNacimiento">Una fecha de nacimiento de tipo DateTime</param>
        /// <param name="pEmpleo">Un empleo de tipo Empleo</param>
        public Cliente(String pNombre, String pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iEmpleo = pEmpleo;

            this.iTipoCliente = TipoCliente.NoCliente;
        }

        /// <summary>
        /// Obtiene el nombre del cliente.
        /// </summary>
        public String Nombre
        {
            get { return this.iNombre; }
        }

        /// <summary>
        /// Obtiene el apellido del cliente.
        /// </summary>
        public String Apellido
        {
            get { return this.iApellido; }
        }

        /// <summary>
        /// Obtiene la fecha de nacimiento del cliente, en DateTime.
        /// </summary>
        public DateTime FechaNacimiento
        {
            get { return this.iFechaNacimiento; }
        }
        
        /// <summary>
        /// Obtiene el empleo de un cliente, en tipo Empleo.
        /// </summary>
        public Empleo Empleo
        {
            get { return this.iEmpleo; }
        }

        /// <summary>
        /// Obtiene o modifica el tipo de un cliente.
        /// </summary>
        public TipoCliente TipoCliente
        {
            get { return this.iTipoCliente; }
            set { this.iTipoCliente = value; }
        }

    }
}
