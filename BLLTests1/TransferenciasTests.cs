using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Tests
{
    [TestClass()]
    public class TransferenciasTests
    {
        [TestMethod()]
        public void TransferenciasTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TransferenciasTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Transferencias transferencias = new Transferencias();

            transferencias.Fecha = "12/12/1015";
            transferencias.OrigenId = 1;
            transferencias.DestinoId = 1;
            transferencias.Monto = 1500;
            transferencias.Observacion = "Nada";
            transferencias.UsuarioId = 1;
            bool inserto = transferencias.Insertar();
            Assert.IsTrue(inserto);
        }

        [TestMethod()]
        public void EditarTest()
        {
            Transferencias transferencias = new Transferencias();

            transferencias.TransferenciaId = 1;
            transferencias.Fecha = "12/12/1015";
            transferencias.OrigenId = 1;
            transferencias.DestinoId = 1;
            transferencias.Monto = 1500;
            transferencias.Observacion = "Nada";
            transferencias.UsuarioId = 1;
            bool edito = transferencias.Editar();
            Assert.IsTrue(edito);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Transferencias transferencias = new Transferencias();

            transferencias.TransferenciaId = 1;
            bool elimino = transferencias.Eliminar();
            Assert.IsTrue(elimino);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Transferencias transferencias = new Transferencias();

            Assert.IsTrue(transferencias.Buscar(2));
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Transferencias transferencias = new Transferencias();
            
            Assert.IsTrue(transferencias.Listado(" * ", " 1=1 ", "").Rows.Count > 0);
        }
    }
}