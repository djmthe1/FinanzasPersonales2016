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
    public partial class PresupuestosForm : Form
    {
        public PresupuestosForm()
        {
            InitializeComponent();
        }
        Presupuestos presupuesto = new Presupuestos();

        private void TryParse()
        {
            int id;
            int.TryParse(IdtextBox.Text, out id);
            presupuesto.Buscar(id);
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text.Trim() == "")
            {
                IderrorProvider.SetError(IdtextBox, "Debe especificar el ID ");
                IdtextBox.Focus();
            }
            else
            {
                IderrorProvider.Clear();
            }
            if (IdtextBox.TextLength > 0)
            {
                TryParse();
                DescripciontextBox.Text = presupuesto.Descripcion;
            }
        }

        private void Limpiar()
        {
            PresupuestosdataGridView.Rows.Clear();
            IderrorProvider.Clear();
            CategoriasIdcomboBox.SelectedIndex = 0;
            IdtextBox.Clear();
            DescripciontextBox.Clear();
            MontotextBox.Clear();
            DescripciontextBox.Focus();

        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void CategoriasIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            Categorias categoria = new Categorias();
            data = categoria.Listado("CategoriaId,Descripcion", "0=0", "ORDER BY CategoriaId");
            CategoriasIdcomboBox.DataSource = data;
            CategoriasIdcomboBox.ValueMember = "CategoriaId";
            CategoriasIdcomboBox.DisplayMember = "Descripcion";
        }

        private void AgregarPresupuestobutton_Click(object sender, EventArgs e)
        {
            PresupuestosdataGridView.Rows.Add(CategoriasIdcomboBox.SelectedValue, MontotextBox.Text);

            MontotextBox.Clear();
            MontotextBox.Focus();
        }

        private void LlenarDatos(Presupuestos presupuesto)
        {
            presupuesto.Descripcion = DescripciontextBox.Text; ;

            foreach (DataGridViewRow row in PresupuestosdataGridView.Rows)
            {
                //presupuesto.AgregarPresupuesto((PresupuestosDetalle)row.Cells["CategoriaId"].Value, row.Cells["Monto"].ToString());
            }
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LlenarDatos(presupuesto);
            presupuesto.Insertar();
        }

        
    }
}
