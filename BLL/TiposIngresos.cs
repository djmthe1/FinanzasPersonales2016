using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class TiposIngresos : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();

        public int TipoIngresoId { get; set; }
        public string Descripcion { get; set; }
        public bool EsActivo { get; set; }
        public int UsuarioId { get; set; }

        public TiposIngresos()
        {

        }

        public TiposIngresos(int tipoIngresoId,string descripcion,bool esActivo,int usuarioId)
        {
            this.TipoIngresoId = tipoIngresoId;
            this.Descripcion = descripcion;
            this.EsActivo = esActivo;
            this.UsuarioId = usuarioId;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
               retorno = conexion.Ejecutar(String.Format("insert into TiposIngresos (Descripcion,EsActivo,UsuarioId) values('{0}','{1}',{2}) ", this.Descripcion,this.EsActivo,this.UsuarioId));
               return retorno;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("update TiposIngresos set Descripcion = '{0}',EsActivo = '{1}',UsuarioId = {2} where TipoIngresoId = {3} ", this.Descripcion, this.EsActivo, this.UsuarioId, this.TipoIngresoId));
                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("delete from TiposIngresos where TipoIngresoId = {0} ", this.TipoIngresoId));
                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable data = new DataTable();
            data = conexion.ObtenerDatos(String.Format("select * from TiposIngresos where TipoIngresoId = {0} ", IdBuscado));
            if (data.Rows.Count > 0)
            {
                this.Descripcion= data.Rows[0]["Descripcion"].ToString();
                this.EsActivo = (bool)data.Rows[0]["EsActivo"];
                this.UsuarioId = (int)data.Rows[0]["UsuarioId"];
            }
            return data.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " orden by  " + Orden;
            return conexion.ObtenerDatos(String.Format("select " + Campos + "from TiposIngresos where " + Condicion + Orden));
        }
    }
}
