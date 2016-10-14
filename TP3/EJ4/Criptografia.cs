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


        /// <summary>
        /// Constructor de la clase criptografia. Asigna una instancia de la fabrica de encriptadores.
        /// </summary>
        public Criptografia()
        {
            iFabEnc = FabricaEncriptadores.Instancia;
        }

        /// <summary>
        /// Encripta una cadena con el encriptador que se seleccione.
        /// </summary>
        /// <param name="pCadena">Cadena</param>
        /// <param name="pNombreEncriptador">Nombre del encriptador</param>
        /// <returns></returns>
        public string Encriptar(string pCadena, string pNombreEncriptador)
        {
            return iFabEnc.GetEncriptador(pNombreEncriptador).Encriptar(pCadena);
        }

        /// <summary>
        /// Desencripta una cadena con el encriptador que se seleccione.
        /// </summary>
        /// <param name="pCadena">Cadena</param>
        /// <param name="pNombreEncriptador">Nombre del encriptador</param>
        /// <returns></returns>
        public string Desencriptar(string pCadena, string pNombreEncriptador)
        {
            return iFabEnc.GetEncriptador(pNombreEncriptador).Desencriptar(pCadena);
        }

    }
}
