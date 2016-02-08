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
    }
}
