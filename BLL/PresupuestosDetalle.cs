using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class PresupuestosDetalle
    {
        public int Id { get; set; }
        public int PresupuestoId { get; set; }
        public int CategoriaId { get; set; }
        public float Monto { get; set; }
        ConexionDb conexion = new ConexionDb();

        public PresupuestosDetalle(int id, int presupuestoId, int categoriaId, float monto)
        {
            this.Id = id;
            this.PresupuestoId = presupuestoId;
            this.CategoriaId = categoriaId;
            this.Monto = monto;
        }

        public PresupuestosDetalle()
        {
        }

    }
}
