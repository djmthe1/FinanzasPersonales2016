using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;

namespace BLLTests1
{
    [TestClass]
    public class PersonasTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            Personas  persona = new Personas();

            persona.Nombre = "Jose";

            persona.AgregarTelefono(TiposTelefonos.Celular,"809-588-6582");
            persona.AgregarTelefono(TiposTelefonos.Trabajo, "809-588-1414");

            bool paso = persona.Insertar();

            Assert.IsTrue(paso);
        }
    }
}
