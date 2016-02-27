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

namespace FinanzasPersonales.Registros
{
    public partial class Presupuestos : Form
    {
        public Presupuestos()
        {
            InitializeComponent();
        }

        BLL.Presupuestos pre = new BLL.Presupuestos();

        private void Presupuestos_Load(object sender, EventArgs e)
        {

        }

        private void ObtenerValores()
        {
            int presupuestoId = 0;
            int.TryParse(idTextBox.Text, out presupuestoId);
            pre.PresupuestoId = presupuestoId;
            pre.Descripcion = descripcionTextBox.Text;
            float monto = 0;
            float.TryParse(presupuestoDTextBox.Text, out monto);
           // pre.Monto = monto;
        }

        private void DevolverValores()
        {
            idTextBox.Text = pre.PresupuestoId.ToString();
            descripcionTextBox.Text = pre.Descripcion.ToString();
           // categoriaComboBox.Text = pre.(ToString();
           // presupuestoDTextBox.Text = pre.Monto.ToString();
        }

        private void Limpiar()
        {
            idTextBox.Clear();
            descripcionTextBox.Clear();
            categoriaComboBox.SelectedIndex = -1;
            presupuestoDTextBox.Clear();
        }

        private void buscarIdButton_Click(object sender, EventArgs e)
        {

        }

        private void agregarButton_Click(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
