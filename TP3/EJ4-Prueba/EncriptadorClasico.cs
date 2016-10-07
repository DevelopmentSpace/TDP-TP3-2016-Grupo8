using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ4;

namespace EJ4_Prueba
{
    [TestClass]
    public class EncriptadorClasico
    {
        [TestMethod]
        public void pruebaClasicoEncr ()
        {
            string str = "Hola soy ricardo y naci el 28 de octubre de 2002!";
            string strEnc = "31554310 675585 64341610641955 85 49101634 2243 ep 1922 55167073136422 1922 eaae!";

            EJ4.EncriptadorClasico enc = new EJ4.EncriptadorClasico();

            Assert.AreEqual(enc.Encriptar(str), strEnc);
        }

        [TestMethod]
        public void pruebaClasicoDes()
        {
            string str = "Zig Zag!#%=/()";
            string strEnc = "883428 881028!#%=/()";

            EJ4.EncriptadorClasico enc = new EJ4.EncriptadorClasico();

            Assert.AreEqual(enc.Encriptar(str), strEnc);
        }

        [TestMethod]
        public void pruebaClasicoDesencr()
        {
            string str = "hola soy ricardo y naci el 28 de octubre de 2002!";
            string strEnc = "31554310 675585 64341610641955 85 49101634 2243 ep 1922 55167073136422 1922 eaae!";

            EJ4.EncriptadorClasico enc = new EJ4.EncriptadorClasico();

            Assert.AreEqual(enc.Desencriptar(strEnc), str);
        }

        public void pruebaClasicoEncDesencr()
        {
            string str = "hola soy ricardo y naci el 28 de octubre de 2002!";

            EJ4.EncriptadorClasico enc = new EJ4.EncriptadorClasico();

            Assert.AreEqual(enc.Desencriptar(enc.Encriptar(str)), str);
        }

    }
}
