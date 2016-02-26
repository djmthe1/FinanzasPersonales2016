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

        //public List<PersonasTelefonos> Detalle { get; set; }

        public Presupuestosj() {
            this.PresupuestoId = 0;
            this.Descripcion = "";
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
                foreach (PersonasTelefonos numero in this.Telefonos)
                {
                    conexion.Ejecutar(string.Format("Insert into PresupuestoDetalle(PresupuestoId,CategoriaId,Monto) Values ({0},{1},'{2}')", retorno, int.Parse(numero.TipoTelefono.ToString()), numero.Telefono));
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
            throw new NotImplementedException();
        }
    }
}
