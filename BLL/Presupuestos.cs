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
        public int PresupuestoId { get; set; }
        public string Descripcion { get; set; }
        public List<PresupuestosDetalle> PresupuestosD { get; set; }
        ConexionDb conexion = new ConexionDb();

        public Presupuestos(int presupuestoId, string descripcion)
        {
            this.PresupuestoId = presupuestoId;
            this.Descripcion = descripcion;
        }

        public Presupuestos()
        {
            PresupuestosD = new List<PresupuestosDetalle>();
        }

        public void AgregarPresupuesto(float monto)
        {
            PresupuestosD.Add(new PresupuestosDetalle(monto));
        }
        
        public override bool Insertar()
        {
            int retorno = 0;
            object identity;
            try
            {
                //obtengo el identity insertado en la tabla personas
                identity = conexion.ObtenerValor(string.Format("Insert Into Presupuestos (Descripcion) Values('{0}') Select @@Identity", this.Descripcion));

                //intento convertirlo a entero
                int.TryParse(identity.ToString(), out retorno);

                this.PresupuestoId = retorno;
                if (retorno > 0)
                {
                    foreach (PresupuestosDetalle presupuesto in this.PresupuestosD)
                    {
                        conexion.Ejecutar(string.Format("Insert Into PresupuestosDetalle (PresupuestoId,CategoriaId,Monto) Values ({0},{1},{2})", PresupuestoId, presupuesto.CategoriaId, presupuesto.Monto));
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
                retorno = conexion.Ejecutar(string.Format("Update Presupuestos Set Descripcion= '{0}' Where PresupuestoId= {1}", this.Descripcion, this.PresupuestoId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("Delete From PresupuestosDetalle Where PresupuestoId= {0}", this.PresupuestoId));
                    foreach (PresupuestosDetalle presupuesto in this.PresupuestosD)
                    {
                        conexion.Ejecutar(string.Format("Insert Into PresupuestosDetalle (PresupuestoId,CategoriaId,Monto) Values ({0},{1},{2})", PresupuestoId, presupuesto.CategoriaId, presupuesto.Monto));
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
                retorno = conexion.Ejecutar(string.Format("Delete From Presupuestos where PresupuestoId={0}", this.PresupuestoId));

                if (retorno)
                    conexion.Ejecutar(string.Format("Delete From PresupuestosDetalle Where PresupuestoId={0}", this.PresupuestoId));
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
            DataTable dtDetalle = new DataTable();
            try
            {
                dt = conexion.ObtenerDatos(string.Format("Select * From Presupuestos Where PresupuestoId=" + IdBuscado));
                if (dt.Rows.Count > 0)
                {
                    this.PresupuestoId = (int)dt.Rows[0]["PresupuestoId"];
                    this.Descripcion = dt.Rows[0]["Descripcion"].ToString();

                    
                    /*foreach (DataRow row in dtDetalle.Rows)
                    {
                        
                    }*/
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt.Rows.Count > 0;
        }

        public DataTable ListadoPresupuestos(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos + " From PresupuestosDetalle Where " + Condicion + Orden);
        }
        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos + " From Presupuestos Where " + Condicion + Orden);
        }
    }
}
