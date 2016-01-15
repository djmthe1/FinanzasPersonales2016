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
        public string Sexo { set; get; }
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
            Sexo = "";
            Direccion = "";
            Telefono = "";
            Movil = "";
            Monto = 0;
            Fecha = "";
        }

        public Entradas(int entradaId, string nombres, string apellidos, string sexo, string direccion, string telefono, string movil, float monto, string fecha)
        {
            EntradaId = entradaId;
            Nombres = nombres;
            Apellidos = apellidos;
            Sexo = sexo;
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
                retorno = conexion.Ejecutar(String.Format(" Insert Into Entradas(Nombres,Apellidos,Sexo,Direccion,Telefono,Movil,Monto,Fecha) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7}) ",
                this.Nombres,this.Apellidos,this.Sexo,this.Direccion,this.Telefono,this.Movil,this.Monto,this.Fecha));
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
                retorno = conexion.Ejecutar(String.Format(" Update Entradas set Nombres = '{0}',Apellidos = '{1}',Sexo = '{2}, Direccion = '{3}',Telefono = '{4}',Movil = '{5}',Monto = '{6}',Fecha = '{7}' where EntradaId = {8} ",
                this.Nombres, this.Apellidos, this.Sexo, this.Direccion, this.Telefono, this.Movil, this.Monto, this.Fecha,this.EntradaId));
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
                retorno = conexion.Ejecutar(String.Format(" Delete from Entradas where EntradaId = {0}  "));
                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            try
            {
                DataTable data = new DataTable();
                data = conexion.ObtenerDatos(String.Format("select Nombres,Apellidos,Sexo,Direccion,Telefono,Movil,Monto,Fecha from Entaradas whele EntradaId = {0} ", IdBuscado));
                this.Nombres = data.Rows[0]["Nombres"].ToString();
                this.Apellidos = data.Rows[0][Apellidos].ToString();
                this.Sexo = data.Rows[0]["Sexo"].ToString();
                this.Direccion = data.Rows[0]["Direccion"].ToString();
                this.Telefono = data.Rows[0]["Telefono"].ToString();
                this.Movil = data.Rows[0]["Movil"].ToString();
                this.Monto = (float)data.Rows[0]["Monto"];
                this.Fecha = data.Rows[0]["Fecha"].ToString();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            
            return conexion.ObtenerDatos(string.Format("select " + Campos + " from Entadas where " + Condicion + Orden));

        }
    }
}
