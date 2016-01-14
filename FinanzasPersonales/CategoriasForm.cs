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
        public CategoriasForm()
        {
            InitializeComponent();
        }
        public void LlenarDatos(Categorias categoria)
        {
            categoria.Descripcion = DescripcionTextBox.Text;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Categorias categoria = new Categorias();
            LlenarDatos(categoria);
            if (categoria.Insertar())
            {
                MessageBox.Show("Categoria guardada...","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
        }
    }
}
