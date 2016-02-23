using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public enum TiposTelefonos
    {
        Celular,
        Casa,
        Trabajo
    }

    public class PersonasTelefonos
    {
        ConexionDb Conexion = new ConexionDb();
        public int ID { get; set; }
        public int PersonaId { get; set; }
        public TiposTelefonos TipoTelefono { get; set; }
        public string Telefono { get; set; }

        public PersonasTelefonos()
        {
            this.ID = 0;
            this.PersonaId = 0;
            this.TipoTelefono = TiposTelefonos.Casa;
            this.Telefono = "";
         }
        public PersonasTelefonos(TiposTelefonos tipo, string telefono)
        {
            this.ID = 0;
            this.PersonaId = 0;
            this.TipoTelefono = tipo;
            this.Telefono = telefono;
        }
    }
}
