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
            ConexionDb conexion = new ConexionDb();
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
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos +
                " From Cuentas Where " + Condicion + "" + ordenFinal);
        }
    }
}
