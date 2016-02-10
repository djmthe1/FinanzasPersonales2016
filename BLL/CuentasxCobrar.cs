using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    class CuentasxCobrar : ClaseMaestra

    {
        ConexionDb conexion = new ConexionDb();
        public int CxcId { get; set; }
        public string Fecha  { get; set; }
        public int CuentaId { get; set; }
        public string Copcepto { get; set; }
        public float Monto { get; set; }
        public float Balance { get; set; }
        public CuentasxCobrar()
        {
            this.CxcId = 0;
            this.Fecha = "";
            this.CuentaId = 0;
            this.Copcepto = "";
            this.Monto = 0;
            this.Balance = 0;
        }
        public override bool Insertar()
        {
            bool retorna = false;
            try
            {
                retorna = conexion.Ejecutar(string.Format("insert into CuentasxCobrar(Fecha,CuentaId,Concepto,Monto,Balance) values('{0}','{1}','{2}','{3}','{4}')", this.Fecha,this.CuentaId, this.Copcepto, this.Monto, this.Balance));
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
                datatable = conexion.ObtenerDatos(string.Format("select * from CuantasxCobrar where CxcId=" + IdBuscado));
                if (datatable.Rows.Count > 0)
                {
                    this.Fecha = datatable.Rows[0]["Fecha"].ToString();
                    this.CuentaId = (int)datatable.Rows[0]["CuentaId"];
                    this.Copcepto = datatable.Rows[0]["Concepto"].ToString();
                    this.Monto = (float)datatable.Rows[0]["Monto"];
                    this.Balance = (float)datatable.Rows[0]["Balance"];
                   
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
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
