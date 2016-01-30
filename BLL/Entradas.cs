using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Entradas : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();

        public int EntradaId { set; get; }
        public string Nombres { set; get; }
        public string Apellidos { set; get; }
        public string Direccion { set; get; }
        public string Telefono { set; get; }
        public string Movil { set; get; }
        public float Monto { set; get; }
        public string Fecha { set; get; }

        public Entradas()
        {
            EntradaId = 0;
            Nombres = "";
            Apellidos = "";
            Direccion = "";
            Telefono = "";
            Movil = "";
            Monto = 0;
            Fecha = "";
        }
         
        public Entradas(int entradaId, string nombres, string apellidos, string direccion, string telefono, string movil, float monto, string fecha)
        {
            EntradaId = entradaId;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefono = telefono;
            Movil = movil;
            Monto = monto;
            Fecha = fecha;
        }


        public override bool Insertar()
        {
            try
            {
                bool retorno = false;
                retorno = conexion.Ejecutar(String.Format("Insert Into Entradas(Nombres,Apellidos,Direccion,Telefono,Movil,Monto,Fecha) values('{0}','{1}','{2}','{3}','{4}',{5},'{6}') ", this.Nombres, this.Apellidos, this.Direccion, this.Telefono, this.Movil, this.Monto, this.Fecha));
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
                retorno = conexion.Ejecutar(String.Format("Update Entradas set Nombres = '{0}',Apellidos = '{1}', Direccion = '{2}',Telefono = '{3}',Movil = '{4}',Monto = {5},Fecha = '{6}' where EntradaId = {7} ", this.Nombres, this.Apellidos, this.Direccion, this.Telefono, this.Movil, this.Monto, this.Fecha, this.EntradaId));
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
            data = conexion.ObtenerDatos(String.Format("select Nombres,Apellidos,Direccion,Telefono,Movil,Monto,Fecha from Entradas where EntradaId = {0} ", IdBuscado));
            if (data.Rows.Count > 0)
            {
                this.Nombres = data.Rows[0]["Nombres"].ToString();
                this.Apellidos = data.Rows[0]["Apellidos"].ToString();
                this.Direccion = data.Rows[0]["Direccion"].ToString();
                this.Telefono = data.Rows[0]["Telefono"].ToString();
                this.Movil = data.Rows[0]["Movil"].ToString();
                this.Monto = (float)Convert.ToDecimal(data.Rows[0]["Monto"]);

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
