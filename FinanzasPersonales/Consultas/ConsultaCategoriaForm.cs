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
    public partial class ConsultaCategoriaForm : Form
    {
        public ConsultaCategoriaForm()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Categorias categoria = new Categorias();
            string filtro = "1=1";

            if (FiltroCategoriaTextBox.Text.Length > 0)//Verifico si hay algo en filtro de Busqueda el TextBox
            {
                filtro = FiltrocomboBox.Text + " like '%" + FiltroCategoriaTextBox.Text + "%'";
            }

            ConsultaCategoriaDataGridView.DataSource = categoria.Listado("CategoriaId,Descripcion", filtro, "");

            ConteoTextBox.Text = ConsultaCategoriaDataGridView.RowCount.ToString();
        }
    }
}
