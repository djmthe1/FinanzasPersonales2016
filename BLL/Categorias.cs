using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Categorias : ClaseMaestra

    {
        ConexionDb conexion = new ConexionDb();

        public int CategoriaID { get; set; }
        public string Descripcion { get; set; }

        public Categorias()
        {
            this.CategoriaID = 0;
            this.Descripcion = "";
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("Insert Into Categorias(Descripcion) values('{0}')",this.Descripcion));
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
            return retorno;

        }

        public override bool Editar()
        {
            try
            {
                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format(" Update Categorias set Descripcion = '{0}' where CategoriasId = {1} ",
                this.Descripcion));
                return retorno;
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public override bool Eliminar()
        {
            try
            {
                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format(" Delete from Categorias where CategoriasId = {0}  "));
                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos +
                " From Cuentas Where " + Condicion + "" + ordenFinal);
        }
    }
}
