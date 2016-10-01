using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ4;

namespace EJ4_Prueba
{
    [TestClass]
    public class Encriptador
    {
        [TestMethod]
        public void PruebaAES1()
        {

            string cadena = "Hola, mi nombre es Ricardo";
            string cadenaCifradaEsperada = "JdyvCxIrOgnFf27HA5qiQAgrbeXEz89eDVOjLxNHKPoYkUlpi0H09Xq25cflo3ms07Ta+Ub4u1++cFdx9HfB8Q";

            string cadenaCifrada = new EncriptadorAES().Encriptar(cadena);

            string cadenaDescifrada = new EncriptadorAES().Desencriptar(cadenaCifrada);


            Assert.AreEqual(cadena, cadenaDescifrada);
            //Assert.AreEqual(cadenaCifrada, cadenaCifradaEsperada);


        }
    }
}
