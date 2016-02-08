using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;
namespace BLL
{
    public class Cuentas : ClaseMaestra
    {
        public int CuentaId { set; get; }
        public string Descripcion { set; get; }
        public float Balance { set; get; }
        public ConexionDb conexion = new ConexionDb();

        public Cuentas()
        {
        }

        public Cuentas(int cuentaId, string descripcion, float balance)
        {
            this.CuentaId = cuentaId;
            this.Descripcion = descripcion;
            this.Balance = balance;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Insert Into Cuentas (Descripcion, Balance) Values('{0}',{1})", this.Descripcion, this.Balance));
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
                conexion.Ejecutar(String.Format("Update Cuentas set Descripcion='{0}', Balance={1} where CuentaId={2}", this.Descripcion, this.Balance, this.CuentaId));
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
                conexion.Ejecutar(String.Format("Delete From Cuentas where CuentaId={0}", this.CuentaId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Cuentas Where CuentaId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.CuentaId = (int)dt.Rows[0]["CuentaId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                this.Balance = (float)Convert.ToDecimal(dt.Rows[0]["Balance"]);
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " orden by  " + Orden;
            return conexion.ObtenerDatos(string.Format("select " + Campos + " from Cuentas where " + Condicion + Orden));

        }
    }
}
