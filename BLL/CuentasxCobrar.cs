using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
   public class CuentasxCobrar : ClaseMaestra

    {
        ConexionDb conexion = new ConexionDb();
        public int CxcId { get; set; }
        public string Fecha  { get; set; }
        public int CuentaId { get; set; }
        public string Concepto { get; set; }
        public float Monto { get; set; }
        public float Balance { get; set; }

        public CuentasxCobrar(int cxcId, string fecha, int cuentaId, string concepto, float monto, float balance)
        {
            this.CxcId = cxcId;
            this.Fecha = fecha;
            this.CuentaId = cuentaId;
            this.Concepto = concepto;
            this.Monto = monto;
            this.Balance = balance;
        }

        public CuentasxCobrar()
        {
            this.CxcId = 0;
            this.Fecha = "";
            this.CuentaId = 0;
            this.Concepto = "";
            this.Monto = 0;
            this.Balance = 0;
        }
        public override bool Insertar()
        {
            bool retorna = false;
            try
            {
                conexion.Ejecutar(string.Format("Insert Into CuentasxCobrar (Fecha, CuentaId, concepto, Monto, Balance) values('{0}',{1},'{2}',{3},{4})", this.Fecha,this.CuentaId, this.Concepto, this.Monto, this.Balance));
                retorna = true;
            }
            catch (Exception ex)
            {
    
                throw ex;
            }
            return retorna;
        }
        public override bool Buscar(int IdBuscado)
        {
            DataTable datatable = new DataTable();
            try
            {
                datatable = conexion.ObtenerDatos(string.Format("select * from CuentasxCobrar where CxcId=" + IdBuscado));
                if (datatable.Rows.Count > 0)
                {
                    this.Fecha = datatable.Rows[0]["Fecha"].ToString();
                    this.CuentaId = (int)datatable.Rows[0]["CuentaId"];
                    this.Concepto = datatable.Rows[0]["concepto"].ToString();
                    this.Monto = (float)Convert.ToDecimal(datatable.Rows[0]["Monto"]);
                    this.Balance = (float)Convert.ToDecimal(datatable.Rows[0]["Balance"]);
                }

            }
            catch (Exception exc)
            {

                throw exc;
            }
            return datatable.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorna = false;
            try
            {
               conexion.Ejecutar(string.Format("update CuentasxCobrar set Fecha= '{0}',CuentaId = {1},concepto = '{2}',Monto = {3},Balance = {4} where CxcId= {5} ", this.Fecha,this.CuentaId,this.Concepto,this.Monto,this.Balance,this.CxcId));
                retorna = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorna;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            { 
                conexion.Ejecutar(String.Format("delete from CuentasxCobrar where CxcId = {0}", this.CxcId));
                retorno = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos + " From CuentasxCobrar Where " + Condicion + Orden);
        }
    }
}
