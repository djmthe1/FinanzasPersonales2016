using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using FinanzasPersonales.Consultas;

namespace FinanzasPersonales
{
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void Salidasbutton_Click(object sender, EventArgs e)
        {
            Registros.SalidasForm Salidas = new Registros.SalidasForm();
            Salidas.Show();
        }
 
        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCuentas consultaCuentas = new ConsultaCuentas();
            consultaCuentas.MdiParent = this;
            consultaCuentas.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCategoriaForm cCategoria = new ConsultaCategoriaForm();
            cCategoria.MdiParent = this;
            cCategoria.Show();
        }

        private void transferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaTransferencias CTransferencias = new ConsultaTransferencias();
            CTransferencias.Show();
        }

        private void transferenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registros.TransferenciasForm transferencias = new Registros.TransferenciasForm();
            transferencias.Show();
        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaSalidasForm salida = new ConsultaSalidasForm();
            salida.Show();
        }

        private void salidasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registros.SalidasForm Salidas = new Registros.SalidasForm();
            Salidas.Show();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEntradas entradas = new ConsultaEntradas();
            entradas.Show();
        }

        private void entradasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registros.EntradasForm entrada = new Registros.EntradasForm();
            entrada.Show();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoriasForm categoria = new CategoriasForm();
            categoria.Show();
        }

        private void toolStripButtonTransferencias_Click(object sender, EventArgs e)
        {
            Registros.TransferenciasForm transferencias = new Registros.TransferenciasForm();
            transferencias.Show();
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.CuentasxPagarForm cuentasxPagar = new Registros.CuentasxPagarForm();
            cuentasxPagar.Show();
        }

        private void cuentasPorPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaCuentasxPagar CcuentasxPagar = new ConsultaCuentasxPagar();
            CcuentasxPagar.Show();
        }

        private void cuentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registros.CuentasForm cuentasF = new Registros.CuentasForm();
            cuentasF.Show();
        }

        private void toolStripCategorias_Click(object sender, EventArgs e)
        {
            CategoriasForm categorias = new CategoriasForm();
            categorias.Show();
        }
       private void PresupuestotoolStripButton_Click(object sender, EventArgs e)
        {
            Registros.PresupuestosForm presupuesto = new Registros.PresupuestosForm();
            presupuesto.Show();
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.CuantasxCobrarForm CxCobrar = new Registros.CuantasxCobrarForm();
            CxCobrar.Show();

        }

        private void cuentasPorCobrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaCuentasxCobrar ConsultaCxCobrar = new Consultas.ConsultaCuentasxCobrar();
            ConsultaCxCobrar.Show();

        }

        private void miembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaMiembros ConsultaM = new Consultas.ConsultaMiembros();
            ConsultaM.Show();
        }

        private void miembrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registros.MiembrosForm RegistroM = new Registros.MiembrosForm();
            RegistroM.Show();

        }

        private void tiposDeIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.TiposIngresosForm tipoingreso = new Registros.TiposIngresosForm();
            tipoingreso.Show();
        }

        private void tiposDeIngresosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaTiposIngresos consultatipoingreso = new ConsultaTiposIngresos();
            consultatipoingreso.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Registros.MiembrosForm Miem = new Registros.MiembrosForm();
            Miem.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Registros.SalidasForm Salid = new Registros.SalidasForm();
            Salid.Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rPersonas rPersona = new Registros.rPersonas();
            rPersona.Show();
        }
       
        private void presupuestoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Registros.PresupuestosForm presupuesto = new Registros.PresupuestosForm();
            presupuesto.Show();
        }

        private void PresupuestotoolStripButton_Click_1(object sender, EventArgs e)
        {
            Registros.PresupuestosForm presupuesto = new Registros.PresupuestosForm();
            presupuesto.Show();
        }
    }
}
