using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Tests
{
    [TestClass()]
    public class CategoriasTests
    {
        [TestMethod()]
        public void CategoriasTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CategoriasTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Categorias categoria = new Categorias() ;

            categoria.Descripcion = "LA PRUEBA";

           bool paso = categoria.Insertar();

            Assert.IsTrue(paso);
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