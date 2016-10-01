using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class EncriptadorCesar : Encriptador
    {

        private static char[] cAlfabeto ="abcdefghijklmnñopqrstuvwxyz".ToCharArray();
        int cN = cAlfabeto.Length;

        private int iDesplazamiento;

        public EncriptadorCesar(int pDesplazamiento):base("Cesar")
        {
            this.iDesplazamiento = pDesplazamiento;
        }

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
            return cAlfabeto[(i - iDesplazamiento) % cN];
        }


    }
}
