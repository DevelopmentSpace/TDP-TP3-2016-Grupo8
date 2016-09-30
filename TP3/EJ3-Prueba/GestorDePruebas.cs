using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ3;

namespace EJ3_Prueba
{
    [TestClass]
    public class GestorDePruebas
    {
        [TestMethod]
        public void PruebaNoCliente1()
        {
            //Definir valores

            TipoCliente tipoCliente = TipoCliente.NoCliente;
            DateTime fechaNacimiento = new DateTime(1992, 06, 12);

            int antiguedad = 6;
            DateTime fechaIngreso = DateTime.Today.AddMonths(-antiguedad);
            float sueldo = 6000;

            float monto = 10000;
            int cantCuotas = 6;

            bool resultadoEsperado = true;

            //Instanciar
            Cliente cliente = new Cliente("Manuel", "Chichi", fechaNacimiento, new Empleo(sueldo, fechaIngreso));
            cliente.TipoCliente = tipoCliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, monto, cantCuotas);

            //Prueba

            Assert.AreEqual(resultadoEsperado, new GestorPrestamos().EsValida(solicitud));

        }

        [TestMethod]
        public void PruebaNoCliente2()
        {
            //Definir valores

            TipoCliente tipoCliente = TipoCliente.NoCliente;
            DateTime fechaNacimiento = new DateTime(1992, 06, 12);

            int antiguedad = 5;
            DateTime fechaIngreso = DateTime.Today.AddMonths(-antiguedad);
            float sueldo = 6000;

            float monto = 30000;
            int cantCuotas = 6;

            bool resultadoEsperado = false;

            //Instanciar
            Cliente cliente = new Cliente("Manuel", "Chichi", fechaNacimiento, new Empleo(sueldo, fechaIngreso));
            cliente.TipoCliente = tipoCliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, monto, cantCuotas);

            //Prueba

            Assert.AreEqual(resultadoEsperado, new GestorPrestamos().EsValida(solicitud));

        }

        [TestMethod]
        public void PruebaEdadMinima1()
        {
            //Definir valores

            TipoCliente tipoCliente = TipoCliente.NoCliente;

            int anos = 10;
            DateTime fechaNacimiento = DateTime.Today.AddYears(-anos);

            int antiguedad = 10;
            DateTime fechaIngreso = DateTime.Today.AddMonths(-antiguedad);
            float sueldo = 6000;

            float monto = 4000;
            int cantCuotas = 6;

            bool resultadoEsperado = false;

            //Instanciar
            Cliente cliente = new Cliente("Manuel", "Chichi", fechaNacimiento, new Empleo(sueldo, fechaIngreso));
            cliente.TipoCliente = tipoCliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, monto, cantCuotas);

            //Prueba

            Assert.AreEqual(resultadoEsperado, new GestorPrestamos().EsValida(solicitud));

        }

        [TestMethod]
        public void PruebaEdadMinima2()
        {
            //Definir valores

            TipoCliente tipoCliente = TipoCliente.NoCliente;

            int anos = 18;
            DateTime fechaNacimiento = DateTime.Today.AddYears(-anos);

            int antiguedad = 10;
            DateTime fechaIngreso = DateTime.Today.AddMonths(-antiguedad);
            float sueldo = 6000;

            float monto = 4000;
            int cantCuotas = 6;

            bool resultadoEsperado = true;

            //Instanciar
            Cliente cliente = new Cliente("Manuel", "Chichi", fechaNacimiento, new Empleo(sueldo, fechaIngreso));
            cliente.TipoCliente = tipoCliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, monto, cantCuotas);

            //Prueba

            Assert.AreEqual(resultadoEsperado, new GestorPrestamos().EsValida(solicitud));

        }

        [TestMethod]
        public void PruebaEdadMaxima1()
        {
            //Definir valores

            TipoCliente tipoCliente = TipoCliente.NoCliente;

            int anos = 75;
            DateTime fechaNacimiento = DateTime.Today.AddYears(-anos);

            int antiguedad = 10;
            DateTime fechaIngreso = DateTime.Today.AddMonths(-antiguedad);
            float sueldo = 6000;

            float monto = 4000;
            int cantCuotas = 6;

            bool resultadoEsperado = true;

            //Instanciar
            Cliente cliente = new Cliente("Manuel", "Chichi", fechaNacimiento, new Empleo(sueldo, fechaIngreso));
            cliente.TipoCliente = tipoCliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, monto, cantCuotas);

            //Prueba

            Assert.AreEqual(resultadoEsperado, new GestorPrestamos().EsValida(solicitud));

        }

        [TestMethod]
        public void PruebaEdadMaxima2()
        {
            //Definir valores

            TipoCliente tipoCliente = TipoCliente.NoCliente;

            int anos = 76;
            DateTime fechaNacimiento = DateTime.Today.AddYears(-anos);

            int antiguedad = 10;
            DateTime fechaIngreso = DateTime.Today.AddMonths(-antiguedad);
            float sueldo = 6000;

            float monto = 4000;
            int cantCuotas = 6;

            bool resultadoEsperado = false;

            //Instanciar
            Cliente cliente = new Cliente("Manuel", "Chichi", fechaNacimiento, new Empleo(sueldo, fechaIngreso));
            cliente.TipoCliente = tipoCliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, monto, cantCuotas);

            //Prueba

            Assert.AreEqual(resultadoEsperado, new GestorPrestamos().EsValida(solicitud));

        }

        [TestMethod]
        public void PruebaCliente1()
        {
            //Definir valores

            TipoCliente tipoCliente = TipoCliente.Cliente;

            int anos = 20;
            DateTime fechaNacimiento = DateTime.Today.AddYears(-anos);

            int antiguedad = 20;
            DateTime fechaIngreso = DateTime.Today.AddMonths(-antiguedad);
            float sueldo = 6000;

            float monto = 100000;
            int cantCuotas = 32;

            bool resultadoEsperado = true;

            //Instanciar
            Cliente cliente = new Cliente("Manuel", "Chichi", fechaNacimiento, new Empleo(sueldo, fechaIngreso));
            cliente.TipoCliente = tipoCliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, monto, cantCuotas);

            //Prueba

            Assert.AreEqual(resultadoEsperado, new GestorPrestamos().EsValida(solicitud));

        }

        [TestMethod]
        public void PruebaCliente2()
        {
            //Definir valores

            TipoCliente tipoCliente = TipoCliente.Cliente;

            int anos = 20;
            DateTime fechaNacimiento = DateTime.Today.AddYears(-anos);

            int antiguedad = 20;
            DateTime fechaIngreso = DateTime.Today.AddMonths(-antiguedad);
            float sueldo = 6000;

            float monto = 100500;
            int cantCuotas = 34;

            bool resultadoEsperado = false;

            //Instanciar
            Cliente cliente = new Cliente("Manuel", "Chichi", fechaNacimiento, new Empleo(sueldo, fechaIngreso));
            cliente.TipoCliente = tipoCliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, monto, cantCuotas);

            //Prueba

            Assert.AreEqual(resultadoEsperado, new GestorPrestamos().EsValida(solicitud));

        }

        [TestMethod]
        public void PruebaClienteGold1()
        {
            //Definir valores

            TipoCliente tipoCliente = TipoCliente.ClienteGold;

            int anos = 20;
            DateTime fechaNacimiento = DateTime.Today.AddYears(-anos);

            int antiguedad = 20;
            DateTime fechaIngreso = DateTime.Today.AddMonths(-antiguedad);
            float sueldo = 6000;

            float monto = 150000;
            int cantCuotas = 60;

            bool resultadoEsperado = true;

            //Instanciar
            Cliente cliente = new Cliente("Manuel", "Chichi", fechaNacimiento, new Empleo(sueldo, fechaIngreso));
            cliente.TipoCliente = tipoCliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, monto, cantCuotas);

            //Prueba

            Assert.AreEqual(resultadoEsperado, new GestorPrestamos().EsValida(solicitud));

        }

        [TestMethod]
        public void PruebaClienteGold2()
        {
            //Definir valores

            TipoCliente tipoCliente = TipoCliente.ClienteGold;

            int anos = 20;
            DateTime fechaNacimiento = DateTime.Today.AddYears(-anos);

            int antiguedad = 20;
            DateTime fechaIngreso = DateTime.Today.AddMonths(-antiguedad);
            float sueldo = 6000;

            float monto = 150001;
            int cantCuotas = 98;

            bool resultadoEsperado = false;

            //Instanciar
            Cliente cliente = new Cliente("Manuel", "Chichi", fechaNacimiento, new Empleo(sueldo, fechaIngreso));
            cliente.TipoCliente = tipoCliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, monto, cantCuotas);

            //Prueba

            Assert.AreEqual(resultadoEsperado, new GestorPrestamos().EsValida(solicitud));

        }

        [TestMethod]
        public void PruebaClientePlatinum1()
        {
            //Definir valores

            TipoCliente tipoCliente = TipoCliente.ClientePlatinum;

            int anos = 20;
            DateTime fechaNacimiento = DateTime.Today.AddYears(-anos);

            int antiguedad = 20;
            DateTime fechaIngreso = DateTime.Today.AddMonths(-antiguedad);
            float sueldo = 6000;

            float monto = 200000;
            int cantCuotas = 60;

            bool resultadoEsperado = true;

            //Instanciar
            Cliente cliente = new Cliente("Manuel", "Chichi", fechaNacimiento, new Empleo(sueldo, fechaIngreso));
            cliente.TipoCliente = tipoCliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, monto, cantCuotas);

            //Prueba

            Assert.AreEqual(resultadoEsperado, new GestorPrestamos().EsValida(solicitud));

        }

        [TestMethod]
        public void PruebaClientePlatinum2()
        {
            //Definir valores

            TipoCliente tipoCliente = TipoCliente.ClientePlatinum;

            int anos = 20;
            DateTime fechaNacimiento = DateTime.Today.AddYears(-anos);

            int antiguedad = 20;
            DateTime fechaIngreso = DateTime.Today.AddMonths(-antiguedad);
            float sueldo = 6000;

            float monto = 200070;
            int cantCuotas = 61;

            bool resultadoEsperado = false;

            //Instanciar
            Cliente cliente = new Cliente("Manuel", "Chichi", fechaNacimiento, new Empleo(sueldo, fechaIngreso));
            cliente.TipoCliente = tipoCliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, monto, cantCuotas);

            //Prueba

            Assert.AreEqual(resultadoEsperado, new GestorPrestamos().EsValida(solicitud));

        }
    }
}
