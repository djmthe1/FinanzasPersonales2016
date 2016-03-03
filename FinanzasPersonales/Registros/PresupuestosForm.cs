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
        Presupuestos presupuesto = new Presupuestos();

        public PresupuestosForm()
        {
            InitializeComponent();
        }

        private void PresupuestosForm_Load(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            Categorias categoria = new Categorias();
            data = categoria.Listado("CategoriaId,Descripcion", "0=0", "ORDER BY CategoriaId");
            CategoriaIdcomboBox.DataSource = data;
            CategoriaIdcomboBox.ValueMember = "CategoriaId";
            CategoriaIdcomboBox.DisplayMember = "Descripcion";
        }

        private void TryParse()
        {
            int id;
            int.TryParse(Numerictexbox.Text, out id);
            presupuesto.Buscar(id);
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (Numerictexbox.Text.Trim() == "")
            {
                IderrorProvider.SetError(Numerictexbox, "Debe especificar el ID ");
                Numerictexbox.Focus();
            }
            else
            {
                IderrorProvider.Clear();
            }
            if (Numerictexbox.TextLength > 0)
            {
                TryParse();
                DescripciontextBox.Text = presupuesto.Descripcion;
            }
        }

        private void Limpiar()
        {
            PresupuestosdataGridView.Rows.Clear();
            IderrorProvider.Clear();
            CategoriaIdcomboBox.SelectedIndex = 0;
            Numerictexbox.Clear();
            DescripciontextBox.Clear();
            MontomaskedTextBox.Clear();
            DescripciontextBox.Focus();

        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void AgregarPresupuestobutton_Click(object sender, EventArgs e)
        {
            PresupuestosdataGridView.Rows.Add(CategoriaIdcomboBox.SelectedValue, MontomaskedTextBox.Text);

            MontomaskedTextBox.Clear();
            MontomaskedTextBox.Focus();
        }

        private void LlenarDatos(Presupuestos presupuesto)
        {
            //presupuesto.Descripcion = DescripciontextBox.Text; ;
            //int
            //foreach (DataGridViewRow row in PresupuestosdataGridView.Rows)
            //{
            //    presupuesto.AgregarPresupuesto(,(int)row.Cells["PresupuestoId"].Value, row.Cells["CategoriaId"].ToString() ,row.Cells["Monto"].ToString());
            //}
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            LlenarDatos(presupuesto);
            presupuesto.Insertar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Numerictexbox.Text.Trim() == "")
            {
                IderrorProvider.SetError(Numerictexbox, "Debe especificar el ID ");
                Numerictexbox.Focus();
            }
            else
            {
                IderrorProvider.Clear();
                if (Numerictexbox.Text.Length > 0)
                {
                    presupuesto.PresupuestoId = int.Parse(Numerictexbox.Text);

                    if (presupuesto.Eliminar())
                    {
                        MessageBox.Show("El Presupuesto se elimino Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("El Presupuesto no ha sido eliminada Correctamente");
                    }
                }
            }
        }

        private void Descripcion(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
