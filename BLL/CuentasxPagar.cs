using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CuentasxPagar : ClaseMaestra
    {

        public int CxpId { get; set; }
        public string Fecha { get; set; }
        public string Concepto { get; set; }
        public float Monto { get; set; }
        public float Balance { get; set; }
        public ConexionDb conexion = new ConexionDb();

        public CuentasxPagar(int cxpId, string fecha, string concepto, float monto, float balance)
        {
            this.CxpId = cxpId;
            this.Fecha = fecha;
            this.Concepto = concepto;
            this.Monto = monto;
            this.Balance = balance;
        }

        public CuentasxPagar()
        {
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Insert Into CuentasxPagar (Fecha, Concepto, Monto, Balance) Values ('{0}','{1}',{2},{3})", this.Fecha, this.Concepto, this.Monto, this.Balance));
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
                conexion.Ejecutar(String.Format("Update CuentasxPagar set Fecha='{0}', Concepto='{1}', Monto={2}, Balance={3} where CxpId={4}", this.Fecha, this.Concepto, this.Monto, this.Balance, this.CxpId));
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
                conexion.Ejecutar(String.Format("Delete From CuentasxPagar where CxpId={0}", this.CxpId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from CuentasxPagar Where CxpId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.CxpId = (int)dt.Rows[0]["CxpId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.Concepto = dt.Rows[0]["Concepto"].ToString();
                this.Monto = (float)Convert.ToDecimal(dt.Rows[0]["Monto"]);
                this.Balance = (float)Convert.ToDecimal(dt.Rows[0]["Balance"]);
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from CuentasxPagar where " + Condicion + ordenar));
        }
    }
}
