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

namespace FinanzasPersonales
{
    public partial class CategoriasForm : Form
    {
        Categorias categoria = new Categorias();
        public CategoriasForm()
        {
            InitializeComponent();
        }
        public void LlenarDatos(Categorias categoria)
        {
            categoria.Descripcion = DescripcionTextBox.Text;
        }
       

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (CategoriaIDTextBox.Text.Trim() == "")
            {
                CategoriaErrorProvider.SetError(CategoriaIDTextBox, "Error debe presisar el Id.");
                CategoriaIDTextBox.Focus();
            }
            else
            {
                CategoriaErrorProvider.Clear();
            }

        }

        private void CategoriaIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoriaIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void DescripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void Limpiar()
        {
            CategoriaIDTextBox.Clear();
            DescripcionTextBox.Clear();
        }
        

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            
            LlenarDatos(categoria);
            if (categoria.Insertar())
            {
                MessageBox.Show("Categoria guardada...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarDatos(categoria);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}
