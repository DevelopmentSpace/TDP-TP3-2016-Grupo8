using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public class EncriptadorCesar : Encriptador
    {

        private static char[] cAlfabeto ="abcdefghijklmnñopqrstuvwxyz".ToCharArray();
        int cN = cAlfabeto.Length;

        private int iDesplazamiento;

        /// <summary>
        /// Constructor del encriptador cesar.
        /// </summary>
        /// <param name="pDesplazamiento">Desplazamiento de las letras</param>
        public EncriptadorCesar(int pDesplazamiento):base("César")
        {
            this.iDesplazamiento = pDesplazamiento;
        }

        /// <summary>
        /// Encripta una cadena utilizando el encriptador cesar.
        /// </summary>
        /// <param name="pCadena">Cadena</param>
        /// <returns>Cadena encriptada</returns>
        public override string Encriptar(string pCadena)
        {
            string encriptada="";

            foreach(char l in pCadena)
            {
                if (Char.IsLetter(l))
                {
                    if (Char.IsUpper(l))
                        encriptada += Char.ToUpper(EncriptarLetra(Char.ToLower(l)));
                    else
                        encriptada += EncriptarLetra(l);
                }
                else
                    encriptada += l;
            }

            return encriptada;
        }


        /// <summary>
        /// Desencripta una cadena utilizando el encriptador cesar.
        /// </summary>
        /// <param name="pCadena">Cadena</param>
        /// <returns>Cadena Desencriptada</returns>
        public override string Desencriptar(string pCadena)
        {
            string encriptada = "";

            foreach (char l in pCadena)
            {
                if (Char.IsLetter(l))
                {
                    if (Char.IsUpper(l))
                        encriptada += Char.ToUpper(DesencriptarLetra(Char.ToLower(l)));
                    else
                        encriptada += DesencriptarLetra(l);
                }
                else
                    encriptada += l;
            }

            return encriptada;
        }

        private char EncriptarLetra(char pLetra)
        {
            int i = Array.IndexOf(cAlfabeto, pLetra);
            return cAlfabeto[(i + iDesplazamiento) % cN];
        }

        private char DesencriptarLetra(char pLetra)
        {
            int i = Array.IndexOf(cAlfabeto, pLetra);
            int iN = (i - iDesplazamiento) % cN;
            if (iN < 0)
                iN += cN;
            return cAlfabeto[iN];
        }


    }
}
