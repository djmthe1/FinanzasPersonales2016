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
        public void EntradasTests1()
        {
            Assert.Fail();
        }
        
        [TestMethod()]
        public void InsertarTest()
        {
            Entradas entrada = new Entradas();
            entrada.CuentaId = 0;
            entrada.CategoriaId = 0;
            entrada.Monto = 123090f;
            entrada.Descripcion = "Hola";
            entrada.Fecha = "10/02/2013";
            bool bolo = entrada.Insertar();
            Assert.IsTrue(bolo);
        }

        [TestMethod()]
        public void EditarTest()
        {
            Entradas entrada = new Entradas();
            entrada.EntradaId = 2;
            entrada.CuentaId = 1;
            entrada.CategoriaId = 1;
            entrada.Descripcion = "como estas"; 
            entrada.Monto = 142790;
            entrada.Fecha = "10/02/2013";
            bool edit = entrada.Insertar();
            Assert.IsTrue(edit);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Entradas entrada = new Entradas();
            entrada.EntradaId = 1;
            bool prueba = entrada.Eliminar();
            Assert.IsTrue(prueba);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Entradas entrada = new Entradas();
            
            Assert.IsTrue(entrada.Buscar(3));
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Entradas entrada = new Entradas();

            Assert.IsTrue(entrada.Listado(" * ", " 1=1 ", "").Rows.Count > 0);
        }
    }
}
