using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace BLL
{
    class PresupuestoDetalles
    {
        [Browsable(false)]
        public int PresupustoDetalleId { get; set; }
        [Browsable(false)]
        public int PresupuestoId { get; set; }
        public float Monto { get; set; }
        public Categorias CategoriaId { get; set; }

        public PresupuestoDetalles()
        {
            this.PresupuestoId = 0;
            this.PresupuestoId = 0;
            this.Monto = 0;
            this.CategoriaId = new Categorias();
        }
        public PresupuestoDetalles( float Monto)
        {
            this.Monto = Monto;
        }
    }
}
