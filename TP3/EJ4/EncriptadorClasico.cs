using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public class EncriptadorClasico : Encriptador
    {

        private static char[] cAlfabeto = "abcdefghijklmnñopqrstuvwxyz".ToCharArray();
        int cN = cAlfabeto.Length;

        public EncriptadorClasico() : base("Clasico")
        {
        }


        /// <summary>
        /// Encripta una cadena con el algoritmo clasico
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Cadena encriptada</returns>
        public override string Encriptar(string pCadena)
        {
            string encriptada = "";
            foreach (char caracter in pCadena)
            {
                if (Char.IsLetter(caracter))
                    encriptada += EncriptarLetra(Char.ToLower(caracter));
                else if (Char.IsDigit(caracter))
                    encriptada += EncriptarNumero(caracter);
                else
                    encriptada += caracter;

            };
            return encriptada;
        }



        private string EncriptarLetra(char pLetra)
        {
            ///Consiste en reemplazar una letra con un numero de dos cifras.
            return (Array.IndexOf(cAlfabeto, pLetra) * 3 + 10).ToString();
        }

        private string DesencriptarLetra(string pNumero)
        {
            //Consiste en reemplazar un numero de dos cifras por una letra
            int num;
            int.TryParse(pNumero, out num);

            return (cAlfabeto[(num-10)/3]).ToString();
        }

        private string EncriptarNumero(char pNumero)
        {
            //Consiste en reemplazar un numero por una letra del alfabeto
            int num;
            int.TryParse(pNumero.ToString(), out num);

            return (cAlfabeto[num*2]).ToString();
        }

        private string DesencriptarNumero(char pLetra)
        {
            // Consiste en reemplazar una letra por un numero.
            return (Array.IndexOf(cAlfabeto, pLetra) / 2).ToString();
        }

        /// <summary>
        /// Desencripta una cadena con el algoritmo clasico
        /// </summary>
        /// <param name="pCadena">Cadena a desencriptar</param>
        /// <returns>Cadena desencriptada</returns>
        public override string Desencriptar(string pCadena)
        {
            string desencriptada = "";
            bool segundoNumero = false;
            char primerNumero = '0';

            foreach (char caracter in pCadena)
            {
                if (Char.IsLetter(caracter))
                    desencriptada += DesencriptarNumero(caracter);
                else if (Char.IsDigit(caracter))
                    //Hay que comprobar que sea el segundo numero antes de hacer la desencriptacion
                    if(segundoNumero)
                    {
                        desencriptada += DesencriptarLetra(primerNumero.ToString() + caracter);
                        segundoNumero = false;
                    }
                        
                    else
                    {
                        segundoNumero = true;
                        primerNumero = caracter;
                    }
                else
                    desencriptada += caracter;

            };
            return desencriptada;
        }

    }
}

