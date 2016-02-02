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
    public partial class ConsultaUsuarios : Form
    {
        private Usuarios usuario = new Usuarios();
        public ConsultaUsuarios()
        {
            InitializeComponent();
            UsuariosdataGridView.DataSource = usuario.Listado("*", "1=1", " asc ");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            string filtroWhere = "";

            if (BuscarcomboBox.SelectedIndex == 0)
            {
                filtroWhere = "UsuarioId=" + BuscartextBox.Text;
            }
            if (BuscarcomboBox.SelectedIndex == 1)
            {
                filtroWhere = "NombreUsuario like '%" + BuscartextBox.Text + "%'";
            }
            UsuariosdataGridView.DataSource = usuario.Listado("*", filtroWhere, " asc ");
        }

    }
}
