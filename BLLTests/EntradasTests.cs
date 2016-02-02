using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Tests
{
    [TestClass()]
    public class EntradasTests
    {
        [TestMethod()]
        public void EntradasTest()
        {
            Entradas entrada = new Entradas();
            entrada.Nombres = "natanael";
            entrada.Apellidos = "rodriguez";
            entrada.Direccion = "San Francisco";
            entrada.Telefono = "889-456-4563";
            entrada.Movil = "809-345-3454";
            //entrada.Monto = 15000.75f;
            entrada.Fecha = "12/12/2015";
            Assert.IsTrue(entrada.Insertar());
        }

        [TestMethod()]
        public void EntradasTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EditarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Assert.Fail();
        }
    }
}