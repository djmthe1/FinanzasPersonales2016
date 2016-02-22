using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class PersonasTelefonos
    {
        ConexionDb Conexion = new ConexionDb();
        public int ID { get; set; }
        public int PersonaId { get; set; }
        public int TipoId { get; set; }
        public string Telefono { get; set; }

        public PersonasTelefonos()
        {
            this.ID = 0;
            this.PersonaId = 0;
            this.TipoId = 0;
            this.Telefono = "";
         }
    }
}
