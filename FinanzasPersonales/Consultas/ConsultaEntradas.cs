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
    public partial class ConsultaEntradas : Form
    {
        public ConsultaEntradas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Entradas entrada = new Entradas();
            string condicion;

            if (CamposcomboBox.SelectedIndex == 0)
            {
                if (FiltrotextBox.Text.Trim().Length == 0)
                {
                    condicion = "1=1 ";
                }
                else
                {
                    int id;
                    int.TryParse(FiltrotextBox.Text, out id);
                    condicion = "EntradaId = " + id.ToString();
                }
                ConsultadataGridView.DataSource = entrada.Listado("EntradaId,CuentaId,CategoriaId,Descripcion,Monto,Fecha", condicion, "");
            }
            if (CamposcomboBox.SelectedIndex == 1)
            {
                if (FiltrotextBox.Text.Trim().Length == 1)
                {
                    condicion = "2=2";
                }
                else
                {
                    int id;
                    int.TryParse(FiltrotextBox.Text, out id);
                    condicion = "CuentaId = " + id.ToString();
                }
                ConsultadataGridView.DataSource = entrada.Listado("EntradaId,CuentaId,CategoriaId,Descripcion,Monto,Fecha", condicion, "");
            }
            if (CamposcomboBox.SelectedIndex == 2)
            {
                if (FiltrotextBox.Text.Trim().Length == 2)
                {
                    condicion = "3=3 ";
                }
                else
                {
                    int id;
                    int.TryParse(FiltrotextBox.Text, out id);
                    condicion = "CategoriaId = " + id.ToString();
                }
                ConsultadataGridView.DataSource = entrada.Listado("EntradaId,CuentaId,CategoriaId,Descripcion,Monto,Fecha", condicion, "");
            }
            
            ConteotextBox.Text = ConsultadataGridView.RowCount.ToString();
        }

        private void ConsultaEntradas_Load(object sender, EventArgs e)
        {

        }
    }
}
