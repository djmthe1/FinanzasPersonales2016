using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public class Entradas : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();

        public int EntradaId { set; get; }
        public int CuentaId { set; get; }
        public int CategoriaId { set; get; }
        public string Descripcion { set; get; }
        public float Monto { set; get; }
        public string Fecha { set; get; }

        public Entradas()
        {
            this.EntradaId = 0;
            this.CuentaId = 0;
            this.CategoriaId = 0;
            this.Monto = 0;
            this.Descripcion = "";
            this.Fecha = "";
        }

        public Entradas(int entradaId, int cuentaId, int categoriaId, float monto, string descripcion, string fecha)
        {
            this.EntradaId = entradaId;
            this.CuentaId = cuentaId;
            this.CategoriaId = categoriaId;
            this.Monto = monto;
            this.Descripcion = descripcion;
            this.Fecha = fecha;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert Into Entradas (CuentaId,CategoriaId,Monto,Descripcion,Fecha) values ({0},{1},{2},'{3}','{4}' ) ",
                    this.CuentaId, this.CategoriaId, this.Monto, this.Descripcion, this.Fecha));
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Editar()
        {
            try
            {
                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format("Update Entradas set CuentaId = {0}, CategoriaId = {1},Monto= {2},Descripcion= '{3}',Fecha = {4} where EntradaId = {5} ", this.CuentaId, this.CategoriaId, this.Descripcion, this.Monto, this.Fecha, this.EntradaId));
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Eliminar()
        {
            try
            {
                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format("Delete from Entradas where EntradaId = {0} ", this.EntradaId));
                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable data = new DataTable();
            data = conexion.ObtenerDatos(String.Format("select * from Entradas where EntradaId = {0} ", IdBuscado));
            if (data.Rows.Count > 0)
            {
                this.CuentaId = (int)data.Rows[0]["CuentaId"];
                this.CategoriaId = (int)data.Rows[0]["CategoriaId"];
                this.Monto = (float)Convert.ToDecimal(data.Rows[0]["Monto"]);
                this.Descripcion = data.Rows[0]["Descripcion"].ToString();
                this.Fecha = data.Rows[0]["Fecha"].ToString();
            }
            return data.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " orden by  " + Orden;
            return conexion.ObtenerDatos(string.Format("select " + Campos + " from Entradas where " + Condicion + Orden));

        }
    }
}
