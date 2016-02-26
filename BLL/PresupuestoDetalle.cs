using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace BLL
{
    class PresupuestoDetalle
    {
        [Browsable(false)]
        public int PresupustoDetalleId { get; set; }
        [Browsable(false)]
        public int PresupuestoId { get; set; }
        public float Monto { get; set; }
        public Categorias CategoriaId { get; set; }

        public PresupuestoDetalle()
        {
            this.PresupuestoId = 0;
            this.PresupuestoId = 0;
            this.Monto = 0;
            this.CategoriaId.CategoriaId = 0;
        }
        public PresupuestoDetalle( float Monto, int CategoriaId)
        {
            this.Monto = Monto;
            this.CategoriaId.CategoriaId = CategoriaId;
        }
    }
}
