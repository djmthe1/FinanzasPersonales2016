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
    public partial class ConsultaCuentasxCobrar : Form
    {
        public ConsultaCuentasxCobrar()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            CuentasxCobrar CuentasxC = new CuentasxCobrar();
            string filtro = "1=1";
            if (FiltroCxCTextBox.Text.Length>0 )
            {
                filtro = FiltroCxCTextBox.Text + "like '%" + FiltroCxCTextBox.Text + "%'";
            }
            ConsultaCuentasxCobrarDataGridView.DataSource = CuentasxC.Listado("CxcId,Fecha,CuentaId,Concepto,Monto,Balance", filtro, "");
            ConteoTextBox.Text = ConsultaCuentasxCobrarDataGridView.RowCount.ToString();
        }
    }
}
