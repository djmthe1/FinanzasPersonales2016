using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Presupuestosj : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();
        public int PresupuestoId { get; set; }
        public string Descripcion { get; set; }

        List<PresupuestoDetalles> Presupuesto { get; set; }

        public Presupuestosj() {
            this.PresupuestoId = 0;
            this.Descripcion = "";
            Presupuesto = new List<PresupuestoDetalles>();
        }
        public void AgregarPresupuesto( float Monto)
        {
            Presupuesto.Add(new PresupuestoDetalles( Monto));
        }
        public override bool Insertar()
        {
            int retorno = 0;
            object identity;
            try
            {
                //obtengo el identity insertado en la tabla personas
                identity = conexion.ObtenerValor(string.Format("Insert Into Presupuesto(Descripcion) values('{0}') select @@Identity", this.Descripcion));

                //intento convertirlo a entero
                int.TryParse(identity.ToString(), out retorno);

                this.PresupuestoId = retorno;
                foreach (PresupuestoDetalles monto in this.Presupuesto)
                {
                    conexion.Ejecutar(string.Format("Insert into PresupuestoDetalle(PresupuestoId,CategoriaId,Monto) Values ({0},{1},'{2}')", retorno, monto.CategoriaId, monto.Monto));
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno > 0;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("update Presupuesto set Descripcion= '{0}' where PresupuestoId={1}", this.Descripcion, this.PresupuestoId));

                if (retorno)
                {
                    conexion.Ejecutar(string.Format("delete from PresupuestoDetalle where PresupuestoId= {0}", this.PresupuestoId));
                    foreach (PresupuestoDetalles monto in Presupuesto)
                    {
                        conexion.Ejecutar(string.Format("insert int PresupuestoDetalle(PresupuestoId,CategoriaId,Monto) values({0},{1},{2})", PresupuestoId, monto.CategoriaId,monto.Monto));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("delete from Presupuesto where PresupuestoId= {0}", this.PresupuestoId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("delete from PresupuestoDetalle where PresupuestoId= {0}", this.PresupuestoId.ToString()));
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * from Personas where PresupuestoId=" + IdBuscado));
                if (dt.Rows.Count > 0)
                {
                    this.PresupuestoId = (int)dt.Rows[0]["PresupuestoId"];
                    this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt.Rows.Count > 0;
        }
        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
            {
                ordenFinal = "orden by" + Orden;

            }

            return conexion.ObtenerDatos(string.Format("select " + Campos + " Presupuesto where " + Condicion+ordenFinal));
        }
        public DataTable ListadoPresupuesto(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos + " From PresupuestoDetalle Where " + Condicion + ordenFinal);
        }
    }
}
