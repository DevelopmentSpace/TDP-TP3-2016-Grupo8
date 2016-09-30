using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class EncriptadorCesar : Encriptador
    {

        private static char[] letras ="abcdefghijklmnñopqrstuvwxyz".ToCharArray();
        int n = letras.Length;

        private int iDesplazamiento;

        public EncriptadorCesar(int pDesplazamiento):base("Cesar")
        {
            this.iDesplazamiento = pDesplazamiento;
        }

        public override string Encriptar(string pCadena)
        {
            foreach(char l in pCadena)
            {

            }
        }

        public override string Desencriptar(string pCadena)
        {
            throw new NotImplementedException();
        }

    }
}
