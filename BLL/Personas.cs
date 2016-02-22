using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    class Personas : ClaseMaestra
    {
        public int PersonaId { get; set; }
        public string Nombre{ get; set; }
        //List<PersonaTelefonos> Telefonos = new List<PersonaTelofon
        ConexionDb conexion = new ConexionDb(); 
        public Personas()
        {
            this.PersonaId = 0;
            this.Nombre = "";
        }
        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("Insert Into Personas(Nombre) values('{0}')", this.Nombre));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("Update Personas set Nombre= '{0}' where PersonaId=",this.Nombre, this.PersonaId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;

        }
        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }
        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
