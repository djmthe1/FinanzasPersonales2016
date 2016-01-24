using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace FinanzasPersonales.Consultas
{
    public partial class ConsultaTransferencias : Form
    {
        public ConsultaTransferencias()
        {
            InitializeComponent();
        }

        private void textBoxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Transferencias transferencias = new Transferencias();

            string filtro = "1=1";

            if (textBoxFiltro.Text.Length > 0)
            {
                filtro = comboBoxCampos.Text + " like '%" + textBoxFiltro.Text + "%'";
            }

            dataGridViewConsulta.DataSource = transferencias.Listado("TransferenciaId, Fecha, CuentaDeOrigenId, CuentaDeDestinoId, Monto, Observacion, UsuarioId", filtro, "");

            textBoxConteo.Text = dataGridViewConsulta.RowCount.ToString();
        }

        private void ConsultaTransferencias_Load(object sender, EventArgs e)
        {

        }
    }
}
