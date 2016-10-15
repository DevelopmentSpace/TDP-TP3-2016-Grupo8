using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EJ4
{
   public class EncriptadorAES : Encriptador
    {
        public EncriptadorAES():base("AES")
        {
        }

        /// <summary>
        /// Encripta una cadena con el algoritmo AES
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Cadena encriptada</returns>
        public override string Encriptar(string pCadena)
        {
            return EncriptarTexto(pCadena); 
        }

        /// <summary>
        /// Descencripta una cadaena con el algoritmo AES
        /// </summary>
        /// <param name="pCadena">Cadena a descencriptar</param>
        /// <returns>Cadena descencriptada.</returns>
        public override string Desencriptar(string pCadena)
        {
            return DesencriptarTexto(pCadena);
        }

        private static string EncriptarTexto(string clearText)
        {
            //Se crea una clave de encriptacion y se obtienen los bytes de la misma.
            string EncryptionKey = "abc123";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);

            //Usando la clase AES, se crea un ecriptador.
            using (Aes encryptor = Aes.Create())
            {
                //Utilizando la clave de encriptacion crea un conjunto de bytes aleatorios.
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                //Le asigna al encriptador los valores aleatorios (en formato byte) a la Key y al IV.
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);

                //Se crea un flujo de memoria.
                using (MemoryStream ms = new MemoryStream())
                {
                    //Se crea un flujo de memoria encriptado, utilizando el flujo de memoria y el encriptador. A este ultimo se lo asigna a modo escribir.
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        //Escribe en el flujo encriptado, los bytes de la palabra sin encriptar.
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    //Obtiene el texto encriptado en bytes y lo transforma a un string.
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        private static string DesencriptarTexto(string cipherText)
        {
            //Se crea una clave de encriptacion.
            string EncryptionKey = "abc123";

            //Del texto encriptado se reemplazan los espacios por simbolos + y se obtienen los bytes de la clave encriptada.
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            //Usando la clase AES, se crea un ecriptador.
            using (Aes encryptor = Aes.Create())
            {
                //Utilizando la clave de encriptacion crea un conjunto de bytes aleatorios.
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });

                //Le asigna al encriptador los valores aleatorios (en formato byte) a la Key y al IV.
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);

                //Se crea un flujo de memoria.
                using (MemoryStream ms = new MemoryStream())
                {
                    //Se crea un flujo de memoria encriptado, utilizando el flujo de memoria y el encriptador. A este ultimo se lo asigna a modo escribir.
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        //Escribe en el flujo encriptado, los bytes de la palabra encriptados.
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    //Obtiene el texto desenciptado en una matriz y lo transforma a un string.
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}
