using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ4;

namespace EJ4_Prueba
{
    [TestClass]
    public class EncriptadorCesar
    {
        [TestMethod]

        public void pruebaCesarEnc()
        {
            int despl = 2;
            string str = "Zig Zag!#%=/()";
            string strEnc = "Bki Bci!#%=/()";

            EJ4.EncriptadorCesar enc = new EJ4.EncriptadorCesar(despl);

            Assert.AreEqual(enc.Encriptar(str), strEnc);
        }

        [TestMethod]
        public void pruebaCesarDesenc()
        {
            int despl = 2;
            string strEnc = "Zig Zag!#%=/()";
            string str = "Xge Xye!#%=/()";

            EJ4.EncriptadorCesar enc = new EJ4.EncriptadorCesar(despl);

            Assert.AreEqual(enc.Desencriptar(strEnc), str);
        }

        [TestMethod]
        public void pruebaCesarEncYDes()
        {
            EJ4.EncriptadorCesar enc = new EJ4.EncriptadorCesar(10);

            string str = "(¡Una frase cualquiera para encriptar!)";

            Assert.AreEqual(enc.Desencriptar(enc.Encriptar(str)),str);

        }

    }
}
