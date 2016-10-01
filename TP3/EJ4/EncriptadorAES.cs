using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EJ4
{
    class EncriptadorAES : Encriptador
    {
        public EncriptadorAES():base("AES")
        {
        }

        public override string Encriptar(string pCadena)
        {
            return CifradorString.Encrypt(pCadena, "HomoSapiens"); 
        }

        public override string Desencriptar(string pCadena)
        {
            return CifradorString.Decrypt(pCadena, "HomoSapiens");
        }

    }
}
