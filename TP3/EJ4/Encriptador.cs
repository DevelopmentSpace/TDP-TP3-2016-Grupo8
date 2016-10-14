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

        /// <summary>
        /// Constructor del encriptador.
        /// </summary>
        /// <param name="pNombre">Nombre del encriptador</param>
        public Encriptador(string pNombre)
        {
            this.iNombre = pNombre;
        }

        /// <summary>
        /// Edita o devuelve el nombre de un encriptador
        /// </summary>
        public String Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        /// <summary>
        /// Metodo abstracto de la clase encriptador para encriptar cadenas.
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Cadena encriptada</returns>
        public abstract string Encriptar(string pCadena);

        /// <summary>
        /// Metodo abstracto de la clase encriptador para desencriptar cadenas.
        /// </summary>
        /// <param name="pCadena">Cadena a descencriptar</param>
        /// <returns>Cadena desencriptada</returns>
        public abstract string Desencriptar(string pCadena);

    }
}
