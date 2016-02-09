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
            Categorias categoria = new Categorias();
            categoria.CategoriaId = 1;
            categoria.Descripcion = "LAS PRUEBAS";

            bool paso = categoria.Editar();

            Assert.IsTrue(paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Categorias categorias = new Categorias();
            categorias.Descripcion = "LA PRUEBA";
            categorias.CategoriaId = 1;
            bool prueba = categorias.Eliminar();
            Assert.IsTrue(prueba);
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