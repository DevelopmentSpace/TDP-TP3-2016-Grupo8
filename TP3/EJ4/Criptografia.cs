using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class Criptografia
    {

        FabricaEncriptadores iFabEnc;

        public Criptografia()
        {
            iFabEnc = FabricaEncriptadores.Instancia;
        }

        public string Encriptar(string pCadena, string pNombreEncriptador)
        {
            return iFabEnc.GetEncriptador(pNombreEncriptador).Encriptar(pCadena);
        }

        public string Desencriptar(string pCadena, string pNombreEncriptador)
        {
            return iFabEnc.GetEncriptador(pNombreEncriptador).Desencriptar(pCadena);
        }

    }
}
