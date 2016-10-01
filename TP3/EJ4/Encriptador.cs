using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public abstract class Encriptador : IEncriptador
    {
        string iNombre;

        public Encriptador(string pNombre)
        {
            this.iNombre = pNombre;
        }


        public String Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public abstract string Encriptar(string pCadena);
        public abstract string Desencriptar(string pCadena);

    }
}
