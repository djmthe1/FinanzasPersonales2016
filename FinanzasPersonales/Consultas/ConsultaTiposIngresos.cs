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
    public partial class ConsultaTiposIngresos : Form
    {
        public ConsultaTiposIngresos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            TiposIngresos tipoingreso = new TiposIngresos();
            string filtro = "1=1";

            if (FiltrotextBox.Text.Length > 0)
            {
                filtro = CamposcomboBox.Text + " like '%" + FiltrotextBox.Text + "%'";
            }

            ConsultadataGridView.DataSource = tipoingreso.Listado("TipoIngresoId, Descripcion, EsActivo, UsuarioId", filtro, "");

            ConteotextBox.Text = ConsultadataGridView.RowCount.ToString();
        }

        private void ConsultaTiposIngresos_Load(object sender, EventArgs e)
        {

        }
    }

}

