using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Presupuestos : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();
        public int PresupuestoId { get; set; }
        public string Descripcion { get; set; }
        public List<PresupuestosDetalle> PresDetalle { get; set; }

        public Presupuestos()
        {
            PresDetalle = new List<PresupuestosDetalle>();
        }
        
        public void AgregarPresupuesto(int id, int presupuestoId, int categoriaId, float monto)
        {
            PresDetalle.Add(new PresupuestosDetalle(id, presupuestoId, categoriaId, monto));
        }

        public Presupuestos(int presupuestoId,string descripcion)
        {
            this.PresupuestoId = presupuestoId;
            this.Descripcion = descripcion;
        }

        public override bool Insertar()
        {
            int retorno = 0;
            object identity;
            try
            {
                //obtengo el identity insertado en la tabla personas
                identity = conexion.ObtenerValor(String.Format("insert into Presupuestos (Descripcion) values('{0}') select @@Identity", this.Descripcion));

                //intento convertirlo a entero
                int.TryParse(identity.ToString(), out retorno);

                this.PresupuestoId = retorno;
                if (retorno > 0)
                {
                    foreach (PresupuestosDetalle presupuesto in this.PresDetalle)
                    {
                        conexion.Ejecutar(String.Format("insert into PresupuestosDetalle (PresupuestoId,CategoriaId,Monto) values ({0},{1},{2})", PresupuestoId, presupuesto.CategoriaId, presupuesto.Monto));
                    }
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
                retorno = conexion.Ejecutar(string.Format("update Presupuestos set Descripcion= '{0}' where PresupuestoId= {1}", this.Descripcion, this.PresupuestoId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("delete From PresupuestosDetalle where PresupuestoId= {0} ", this.PresupuestoId));
                    foreach (PresupuestosDetalle presupuesto in this.PresDetalle)
                    {
                        conexion.Ejecutar(string.Format("insert into PresupuestosDetalle (PresupuestoId,CategoriaId,Monto) values ({0},{1},{2})", PresupuestoId, presupuesto.CategoriaId, presupuesto.Monto));
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
                conexion.Ejecutar(String.Format("delete from Presupuestos where PresupuestoId= {0} ", this.PresupuestoId));
                if (retorno)
                {
                    conexion.Ejecutar(String.Format("delete from PresupuestosDetalle where PresupuestoId= {0} ", this.PresupuestoId.ToString()));
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
                dt = conexion.ObtenerDatos(string.Format("select * from Presupuestos where PresupuestoId= " + IdBuscado));
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

        public DataTable PresupuestosListado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;

            return conexion.ObtenerDatos("select " + Campos + "from PresupuestosDetalle where " + Condicion + Orden);
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;

            return conexion.ObtenerDatos("select " + Campos + " from Presupuestos where " + Condicion + Orden);
        }
    }
}
