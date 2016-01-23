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
    }
}
