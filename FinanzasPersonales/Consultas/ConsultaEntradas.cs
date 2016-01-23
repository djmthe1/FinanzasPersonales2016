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

                ConsultadataGridView.DataSource = entrada.Listado("EntradaId,Nombres,Apellidos,Direccion,Telefono,Movil,Monto,Fecha", condicion, "");
            }
            if (CamposcomboBox.SelectedIndex == 1)
            {
                if (FiltrotextBox.Text.Trim().Length == 1)
                {
                    condicion = "2=2";
                }
                else
                {
                    condicion = string.Format("Nombres ='{0}' ", FiltrotextBox.Text);
                }
                ConsultadataGridView.DataSource = entrada.Listado("EntradaId,Nombres,Apellidos,Direccion,Telefono,Movil,Monto,Fecha", condicion, "");
            }
            if (CamposcomboBox.SelectedIndex == 2)
            {
                if (FiltrotextBox.Text.Trim().Length == 2)
                {
                    condicion = "3=3 ";
                }
                else
                {
                    condicion = string.Format("Apellidos ='{0}' ", FiltrotextBox.Text);
                }
                ConsultadataGridView.DataSource = entrada.Listado("EntradaId,Nombres,Apellidos,Direccion,Telefono,Movil,Monto,Fecha", condicion, "");
            }
            if (CamposcomboBox.SelectedIndex == 3)
            {
                if (FiltrotextBox.Text.Trim().Length == 3)
                {
                    condicion = "4=4";
                }
                else
                {
                    condicion = string.Format("Direccion ='{0}' ", FiltrotextBox.Text);
                }
                ConsultadataGridView.DataSource = entrada.Listado("EntradaId,Nombres,Apellidos,Direccion,Telefono,Movil,Monto,Fecha", condicion, "");
            }
            ConteotextBox.Text = ConsultadataGridView.RowCount.ToString();
        }

    }
}
