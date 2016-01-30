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
            int CategoriaId = 0;
            int.TryParse(CategoriaIDTextBox.Text, out CategoriaId);
            categoria.CategoriaID = CategoriaId;
            categoria.Descripcion = DescripcionTextBox.Text;
        }
       

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            
                if (CategoriaIDTextBox.Text == "")
                {
                    CategoriaErrorProvider.SetError(CategoriaIDTextBox, "Error debe presisar el Id.");
                    CategoriaIDTextBox.Focus();
                }
                else
                {
                    CategoriaErrorProvider.Clear();
                }

                if (CategoriaIDTextBox.TextLength > 0)
                {
                    DescripcionTextBox.Text = categoria.Descripcion;
                     CategoriaIDTextBox.Focus();
            }
                else
                {
                    
                    MessageBox.Show("Id no encontrado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     Limpiar(); 
            }
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

            try
            {

                if (CategoriaIDTextBox.Text == "")
                {
                    if (DescripcionTextBox.Text != "")
                    {
                        LlenarDatos(categoria);
                        if (categoria.Insertar())
                        {
                            MessageBox.Show("Categoria guardada...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Introdusca la descripción!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                
            }
            catch (Exception exc)
            {

                throw exc;
            }
           

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarDatos(categoria);
                System.Windows.Forms.DialogResult resut;
                //Dialogo para confirmar que se desea Eliminar...
                resut = MessageBox.Show("¿Esta seguro que desea eliminar esta Categoria?", "Meensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resut == System.Windows.Forms.DialogResult.Yes)
                {
                    if (categoria.Buscar(int.Parse(CategoriaIDTextBox.Text)))
                    {
                
                        if (categoria.Eliminar())
                        {

                            MessageBox.Show("Categoria Eliminada Correctamente...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                            
                        }
                        else
                        {
                            MessageBox.Show("Error en Eliminar Categoria!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Limpiar();
                        }

                    }


                    else
                    {
                        MessageBox.Show("Id no existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Limpiar();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error en Eliminar Categoria!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CategoriasForm_Load(object sender, EventArgs e)
        {

        }
    }

}
