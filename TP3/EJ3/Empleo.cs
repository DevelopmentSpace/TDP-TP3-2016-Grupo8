using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class Empleo
    {

        double iSueldo;
        DateTime iFechaIngreso;

        public Empleo(double pSueldo, DateTime pFechaIngreso)
        {
            this.iSueldo = pSueldo;
            this.iFechaIngreso = pFechaIngreso;
        }

        public double Sueldo
        {
            get { return this.iSueldo; }
        }

        public DateTime FechaIngreso
        {
            get { return this.iFechaIngreso; }
        }

    }
}
