using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ4;

namespace EJ4_Prueba
{
    [TestClass]
    public class EncriptadorAES
    {
        [TestMethod]
        public void PruebaAESEncYDes()
        {

            string cadena = "Hola, mi nombre es Ricardo";

            string cadenaCifrada = new EJ4.EncriptadorAES().Encriptar(cadena);

            string cadenaDescifrada = new EJ4.EncriptadorAES().Desencriptar(cadenaCifrada);


            Assert.AreEqual(cadena, cadenaDescifrada);


        }

        [TestMethod]
        public void PruebaAESEnc()
        {

            string cadena = "Hola, mi nombre es Ricardo";

            string cadenaCifrada = new EJ4.EncriptadorAES().Encriptar(cadena);

            string cadenaEsperada = "fR1ksuaKSXbCkBHjC+16M0xaIHR1piYqT06MlkGaLOp7bfmi9Y7fz4huiP8LA8C2sIpNpLr+MXBMYGTYDO54jg==";

            Assert.AreEqual(cadenaCifrada, cadenaEsperada);


        }

        [TestMethod]
        public void PruebaAESDes()
        {

            string cadena = "fR1ksuaKSXbCkBHjC+16M0xaIHR1piYqT06MlkGaLOp7bfmi9Y7fz4huiP8LA8C2sIpNpLr+MXBMYGTYDO54jg==";

            string cadenaDescifrada = new EJ4.EncriptadorAES().Desencriptar(cadena);

            string cadenaEsperada = "Hola, mi nombre es Ricardo";

            Assert.AreEqual(cadenaDescifrada, cadenaEsperada);


        }
    }
}
