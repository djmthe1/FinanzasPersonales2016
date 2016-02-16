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
            categoria.CategoriaId = CategoriaId;
            categoria.Descripcion = DescripcionTextBox.Text;
        }
        public void Validar(TextBox tb)
        {
            if (tb.Text == "")
            {
                CategoriaErrorProvider.SetError(tb, "El Campo esta vacio!!");
                tb.Focus();
            }
            else
            {
                CategoriaErrorProvider.Clear();
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            try
            {
                
                
                Validar(CategoriaIDTextBox);
                if (!CategoriaIDTextBox.Text.Equals("") && categoria.Buscar(int.Parse(CategoriaIDTextBox.Text)))
                {
                    DescripcionTextBox.Text = categoria.Descripcion;

                    CategoriaIDTextBox.Focus();
                    EliminarButton.Enabled = true;
                    GuardarButton.Enabled = true;
                }
                else
                {

                    MessageBox.Show("Id no encontrado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EliminarButton.Enabled = false;
                    Limpiar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 96 && e.KeyChar <= 122 || (e.KeyChar == 32)|| (e.KeyChar>=160 && e.KeyChar <=165)))
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
            GuardarButton.Enabled = true;
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

           try
            {
                Validar(CategoriaIDTextBox);
                Validar(DescripcionTextBox);

                if ((CategoriaIDTextBox.Text == "") && (DescripcionTextBox.Text != ""))
                {

                    if (categoria.BuscarDescripcion(DescripcionTextBox.Text))
                    {
                        MessageBox.Show("Esta Categoria ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Limpiar();
                        DescripcionTextBox.Focus();
                        
                    }
                    else
                    {
                        LlenarDatos(categoria);
                        CategoriaErrorProvider.Clear();
                        if (categoria.Insertar())
                        {
                            MessageBox.Show("Categoria guardada...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {


                    if (CategoriaIDTextBox.Text != "" && categoria.Buscar(int.Parse(CategoriaIDTextBox.Text)) && DescripcionTextBox.Text != "")
                    {
                        LlenarDatos(categoria);
                        if (categoria.Editar())
                        {
                            MessageBox.Show("Categoria Modificada!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al Modificar Categoria!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al Modificar Categoria.\n Pues esta Cagoria No existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            EliminarButton.Enabled = false;


                        }
                        else
                        {
                            MessageBox.Show("Error en Eliminar Categoria!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Limpiar();
                            EliminarButton.Enabled = false;
                        }

                    }


                    else
                    {
                        MessageBox.Show("Id no existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Limpiar();
                        EliminarButton.Enabled = false;
                    }
                }
            }
            catch (Exception exc)
            {

                throw exc;
            }
        }

        private void CategoriasForm_Load(object sender, EventArgs e)
        {

        }
    }

}