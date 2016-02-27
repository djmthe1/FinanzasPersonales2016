using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class PresupuestosDetalle
    {
        ConexionDb conexion = new ConexionDb();
        public int Id { get; set; }
        public int PresupuestoId { get; set; }
        public int CategoriaId { get; set; }
        public float Monto { get; set; }

        public PresupuestosDetalle()
        {
            this.Id = 0;
            this.PresupuestoId = 0;
            this.CategoriaId = 0;
            this.Monto = 0;
        }

        public PresupuestosDetalle(int id, int presupuestoId, int categoriasId,float monto)
        {
            this.Id = id;
            this.PresupuestoId = presupuestoId;
            this.CategoriaId = categoriasId;
            this.Monto = monto;
        }
    }
}
