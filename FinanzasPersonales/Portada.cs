using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinanzasPersonales
{
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void buttonTransferencias_Click(object sender, EventArgs e)
        {
            Registros.TransferenciasForm transferencias = new Registros.TransferenciasForm();
            transferencias.Show();
        }

        private void Salidasbutton_Click(object sender, EventArgs e)
        {
            Registros.SalidasForm Salidas = new Registros.SalidasForm();
            Salidas.Show();
        }
    }
}
