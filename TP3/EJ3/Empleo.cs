using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Empleo
    {

        double iSueldo;
        DateTime iFechaIngreso;

        /// <summary>
        /// Constructor de la clase empleo.
        /// </summary>
        /// <param name="pSueldo">Un sueldo en numero real.</param>
        /// <param name="pFechaIngreso">Una fecha de ingreso en DateTime</param>
        public Empleo(double pSueldo, DateTime pFechaIngreso)
        {
            this.iSueldo = pSueldo;
            this.iFechaIngreso = pFechaIngreso;
        }

        /// <summary>
        /// Obtiene el sueldo del empleo.
        /// </summary>
        public double Sueldo
        {
            get { return this.iSueldo; }
        }

        /// <summary>
        /// Obtiene la fecha de ingreso al empleo.
        /// </summary>
        public DateTime FechaIngreso
        {
            get { return this.iFechaIngreso; }

        }

    }
}
