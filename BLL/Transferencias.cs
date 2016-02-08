using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Transferencias : ClaseMaestra
    {

        public int TransferenciaId { set; get; }
        public string Fecha { set; get; }
        public int OrigenId { set; get; }
        public int DestinoId { set; get; }
        public float Monto { set; get; }
        public string Observacion { set; get; }
        public int UsuarioId { set; get; }
        public ConexionDb conexion = new ConexionDb();

        public Transferencias(int transferenciaId, string fecha, int OrigenId, int DestinoId, float monto, string observacion, int usuarioId)
        {
            this.TransferenciaId = transferenciaId;
            this.Fecha = fecha;
            this.OrigenId = OrigenId;
            this.DestinoId = DestinoId;
            this.Monto = monto;
            this.Observacion = observacion;
            this.UsuarioId = usuarioId;
        }

        public Transferencias()
        {
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Insert Into Transferencias (Fecha, CuentaDeOrigenId, CuentaDeDestinoId, Monto, Observacion, UsuarioId) Values ('{0}',{1},{2},{3},'{4}',{5})", this.Fecha, this.OrigenId, this.DestinoId, this.Monto, this.Observacion, this.UsuarioId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;

        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Update Transferencias set Fecha='{0}', CuentaDeOrigenId={1}, CuentaDeDestinoId={2}, Monto={3}, Observacion='{4}', UsuarioId={5} where TransferenciaId={6}", this.Fecha, this.OrigenId, this.DestinoId, this.Monto, this.Observacion, this.UsuarioId, this.TransferenciaId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Delete From Transferencias where TransferenciaId={0}", this.TransferenciaId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Transferencias Where TransferenciaId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.TransferenciaId = (int)dt.Rows[0]["TransferenciaId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.OrigenId = (int)dt.Rows[0]["CuentaDeOrigenId"];
                this.DestinoId = (int)dt.Rows[0]["CuentaDeDestinoId"];
                this.Monto = (float)Convert.ToDecimal(dt.Rows[0]["Monto"]);
                this.Observacion = dt.Rows[0]["Observacion"].ToString();
                this.UsuarioId = (int)dt.Rows[0]["UsuarioId"];
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Transferencias where " + Condicion + ordenar));
        }
    }
}
