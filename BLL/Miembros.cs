using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Miembros : ClaseMaestra
    {
        ConexionDb Conexion = new ConexionDb();
        public int MiembroId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Parentesco { get; set; }

        public Miembros()
        {
            this.MiembroId = 0;
            this.Nombres = "";
            this.Apellidos = "";
            this.Parentesco = "";
        }

        public Miembros(int miembroid, string nombres, string apellidos, string parentesco)
        {
            this.MiembroId = miembroid;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Parentesco = parentesco;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                Conexion.Ejecutar(String.Format("Insert Into Miembros (Nombres, Apellidos, Parentesco) Values ('{0}', '{1}', '{2}')", this.Nombres, this.Apellidos, this.Parentesco));
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
                Conexion.Ejecutar(String.Format("Update Miembros set Nombres='{0}', Apellidos='{1}', Parentesco='{2}' where MiembroId={3}", this.Nombres, this.Apellidos, this.Parentesco, this.MiembroId));
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
                Conexion.Ejecutar(String.Format("Delete From Miembros where MiembroId={0}", this.MiembroId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = Conexion.ObtenerDatos("Select * from Miembros Where MiembroId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.MiembroId = (int)dt.Rows[0]["MiembroId"];
                this.Nombres = dt.Rows[0]["Nombres"].ToString();
                this.Apellidos = dt.Rows[0]["Apellidos"].ToString();
                this.Parentesco = dt.Rows[0]["Parentesco"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;

            return Conexion.ObtenerDatos("Select " + Campos + " From Miembros Where " + Condicion + Orden);
        }
    }
}
