using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    sealed class EncriptadorNulo : Encriptador
    {
        public EncriptadorNulo():base("Null")
        {
        }

        /// <summary>
        /// Encripta una cadena con el algoritmo nulo
        /// </summary>
        /// <param name="pCadena">Cadena </param>
        /// <returns>Misma cadena que se ingreso</returns>
        public override string Encriptar(string pCadena)
        {
            return pCadena;
        }

        /// <summary>
        /// Desencripta una cadena con el algoritmo nulo
        /// </summary>
        /// <param name="pCadena">Cadena</param>
        /// <returns>Misma cadena que se ingreso</returns>
        public override string Desencriptar(string pCadena)
        {
            return pCadena;
        }

    }
}
