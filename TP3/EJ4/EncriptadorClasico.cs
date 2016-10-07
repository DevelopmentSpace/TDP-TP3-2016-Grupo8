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
            return (Array.IndexOf(cAlfabeto, pLetra) * 3 + 10).ToString();
        }

        private string DesencriptarLetra(string pNumero)
        {
            int num;
            int.TryParse(pNumero, out num);

            return (cAlfabeto[(num-10)/3]).ToString();
        }

        private string EncriptarNumero(char pNumero)
        {
            int num;
            int.TryParse(pNumero.ToString(), out num);

            return (cAlfabeto[num*2]).ToString();
        }

        private string DesencriptarNumero(char pLetra)
        {
            return (Array.IndexOf(cAlfabeto, pLetra) / 2).ToString();
        }

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

