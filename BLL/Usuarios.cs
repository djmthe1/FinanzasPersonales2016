using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;


namespace BLL
{
    public class Usuarios:ClaseMaestra
    {
        ConexionDb Conexion = new ConexionDb();
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Contrasenia1 { get; set; }
        public bool Activo { get; set; }
       
        public Usuarios()
        {
            this.UsuarioId = 0;
            this.Nombres = "";
            this.Apellidos = "";
            this.NombreUsuario = "";
            this.Contrasenia = "";
            this.Contrasenia1 = "";
            this.Activo = false;
        } 
        
        public Usuarios(int usuarioid, string nombres, string apellidos, string nombreusuario, string contrasenia, string contrasenia1, int activo)
        {
            this.UsuarioId = usuarioid;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.NombreUsuario = nombreusuario;
            this.Contrasenia = contrasenia;
            this.Contrasenia1 = contrasenia1;
            this.Activo = false;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                Conexion.Ejecutar(String.Format("Insert Usuarios (Nombres, Apellidos, NombreUsuarios, Contrasenia, Contrasenia1, Activo) Values ('{0}',{1}','{2}','{3}','{4}','{5}')", this.UsuarioId, this.Nombres, this.Apellidos, this.NombreUsuario, this.Contrasenia, this.Contrasenia1, this.Activo));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                Conexion.Ejecutar(String.Format("Update Usuarios set Nombres='{0}', Apellidos='{1}', NombreUsuario='{2}', Contrasenia='{3}', Contrasenia1='{4}', Activo{5}, where UsuarioId={6}", this.Nombres, this.Apellidos, this.NombreUsuario, this.Contrasenia, this.Contrasenia1, this.Activo, this.UsuarioId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                Conexion.Ejecutar(String.Format("Delete From Usuarios where UsuarioId={0}", this.UsuarioId));
            }
            catch(Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = Conexion.ObtenerDatos("Select * from Usuarios Where UsuarioId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.UsuarioId = (int)dt.Rows[0]["UsuarioId"];
                
                this.Nombres = dt.Rows[0]["Nombres"].ToString();
                this.Apellidos = dt.Rows[0]["Apellidos"].ToString();
                this.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                this.Contrasenia = dt.Rows[0]["Contrasenia"].ToString();
                this.Contrasenia1 = dt.Rows[0]["Contrasenia1"].ToString();
                this.Activo = (bool)dt.Rows[0]["Activo"];
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
