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
    public partial class ConsultaMiembros : Form
    {
        public ConsultaMiembros()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Miembros Consulta = new Miembros();
            string filtro = "1=1";

            if (BuscartextBox.Text.Length > 0)
            {
                filtro = BuscarcomboBox.Text + " like '%" + BuscarcomboBox.Text + "%'";
            }

            MiembrosdataGridView.DataSource = Consulta.Listado("MiembroId, Nombres, Apellidos, Parentesco", filtro, "");
        }
    }
}
