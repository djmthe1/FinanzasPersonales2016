using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Salidas : ClaseMaestra
    {
        ConexionDb Conexion = new ConexionDb();
        public int SalidaId { get; set; }
        public int CuentaId { get; set; }
        public string Fecha { get; set; }
        public double Monto { get; set; }
        public string Observacion { get; set; }

        public Salidas()
        {
            this.SalidaId = 0;
            this.CuentaId = 0;
            this.Fecha = "";
            this.Monto = 0;
            this.Observacion = "";

        }

        public Salidas(int salidaid, int cuentaid, string fecha, double monto, string observacion)
        {
            this.SalidaId = salidaid;
            this.CuentaId = cuentaid;
            this.Fecha = fecha;
            this.Monto = monto;
            this.Observacion = observacion;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                Conexion.Ejecutar(String.Format("Insert Into Salidas (CuentaId, Fecha, Monto, Observacion) Values ({0},'{1}',{2},'{3}')", this.CuentaId, this.Fecha, this.Monto, this.Observacion));
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
                Conexion.Ejecutar(String.Format("Update Salidas set CuentaId= {0}, Fecha='{1}', Monto= {2}, Observacion= {3} where SalidaId={4}", this.CuentaId, this.Fecha, this.Monto, this.Observacion, this.SalidaId));
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
                Conexion.Ejecutar(String.Format("Delete From Salidas where SalidaId={0}", this.SalidaId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = Conexion.ObtenerDatos("Select * from Salidas Where SalidaId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.SalidaId = (int)dt.Rows[0]["SalidaId"];
                this.CuentaId = (int)dt.Rows[0]["CuentaId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.Monto = (double)dt.Rows[0]["Monto"];
                this.Observacion = dt.Rows[0]["Observacion"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;

            return Conexion.ObtenerDatos("Select " + Campos + " From Salidas Where " + Condicion + Orden);
        }
    }
}
