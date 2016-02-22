using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class TiposTelefonos : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();

        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        public TiposTelefonos()
        {

        }

        public TiposTelefonos(int tipoId, string descripcion)
        {
            this.TipoId = tipoId;
            this.Descripcion = descripcion;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("insert into TiposTelefonos(Descripcion) values('{0}') ",this.Descripcion));
                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("update TiposTelefonos set Descripcion='{0}',TipoId={1} ", this.Descripcion,this.TipoId));
                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("delete from TiposTelefonos where TipoId={0} ", this.TipoId));
                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " orden by  " + Orden;
            return conexion.ObtenerDatos(String.Format("select " + Campos + "from TiposTelefonos where " + Condicion + Orden));
        }
    }
}
