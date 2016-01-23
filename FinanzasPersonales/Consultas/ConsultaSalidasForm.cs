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
    public partial class ConsultaSalidasForm : Form
    {
        Salidas salida = new Salidas();

        public ConsultaSalidasForm()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            string filtro = "1=1";

            if (ConsultaSalidastextBox.Text.Length > 0)
            {
                filtro = ConsultaSalidascomboBox.Text + " like '%" + ConsultaSalidascomboBox.Text + "%'";
            }

            SalidasdataGridView.DataSource = salida.Listado("SalidaId, CuentaId, Fecha, Monto, Observacion", filtro, "");
            
        }
    }
}
