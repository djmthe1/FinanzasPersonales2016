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
    public partial class EntradasForm : Form
    {
        public EntradasForm()
        {
            InitializeComponent();
        }

        Entradas entrada = new Entradas();
        Cuentas cuenta = new Cuentas();
        Categorias categoria = new Categorias();

      
        private void TryParse()
        {
            int id;
            int.TryParse(IdtextBox.Text, out id);
            entrada.Buscar(id);
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text.Trim() == "")
            {
                EntradaerrorProvider.SetError(IdtextBox, "Debe especificar el ID ");
                IdtextBox.Focus();
            }
            else
            {
                EntradaerrorProvider.Clear();
            }
            if (IdtextBox.TextLength > 0)
            {
                TryParse();
                CuentaIdcomboBox.Text = Convert.ToString(entrada.CuentaId);
                CategoriaIdcomboBox.Text = Convert.ToString(entrada.CategoriaId);
                MontomaskedTextBox.Text = Convert.ToString(entrada.Monto);
                FechadateTimePicker.Text = entrada.Fecha;
            }
        }

        private void limpiar()
        {
            IdtextBox.Clear();
            CuentaIdcomboBox.Items.Clear();
            CategoriaIdcomboBox.Items.Clear();
            MontomaskedTextBox.Clear();
            DescripciontextBox.Clear();
            EntradaerrorProvider.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Datos()
        {
            entrada.CuentaId = (int)Convert.ToInt32(CuentaIdcomboBox.Text);
            entrada.CategoriaId = (int)Convert.ToInt32(CategoriaIdcomboBox.Text);
            entrada.Monto = (float)Convert.ToDouble(MontomaskedTextBox.Text);
            entrada.Descripcion = DescripciontextBox.Text;
            entrada.Fecha = FechadateTimePicker.Value.ToString();
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (CuentaIdcomboBox.Text.Length == 0 && CategoriaIdcomboBox.Text.Length == 0 && MontomaskedTextBox.Text.Length == 0 && DescripciontextBox.Text.Length == 0)
            {
                MessageBox.Show("Los campo deben estar lleno ");
            }
            else
                Datos();
                if (IdtextBox.Text.Length == 0)
                    {
                        if (entrada.Insertar())
                        {
                            MessageBox.Show("La entrada se Guardo Correctamente");
                        }
                        else
                        {
                            MessageBox.Show("La entrada no ha sido Guardada Correctamente");
                        }
                    }else
                        if(IdtextBox.Text.Length != 0)
                        {
                            entrada.EntradaId = Convert.ToInt32(IdtextBox.Text);
                            if (entrada.Editar())
                            {
                                MessageBox.Show("La entrada se editada Correctamente");
                            }
                            else
                            {
                                MessageBox.Show("La entrada no ha sido editada Correctamente");
                            }
                    
                    }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text.Trim() == "")
            {
                EntradaerrorProvider.SetError(IdtextBox, "Debe especificar el ID ");
                IdtextBox.Focus();
            }
            else
            {
                EntradaerrorProvider.Clear();
            }
            if (IdtextBox.Text.Length > 0)
            {
                entrada.EntradaId = int.Parse(IdtextBox.Text);
                if (entrada.Eliminar())
                {
                    MessageBox.Show("La entrada se elimino Correctamente");
                }
                else
                {
                    MessageBox.Show("La entrada no ha sido eliminada Correctamente");
                }
            }
        }

        private void IdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void DescripciontextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)))
                e.Handled = false;
            else
                e.Handled = true;
        }
       
        private void CuentaIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = cuenta.Listado("CuentaId,Nombre", "0=0", "ORDER BY CuentaId");
            CuentaIdcomboBox.DataSource = data;
            CuentaIdcomboBox.ValueMember = "CuentaId";
            CuentaIdcomboBox.DisplayMember = "Descripcion";
        }

        private void CategoriaIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = categoria.Listado("CategoriaId,Descripcion", "0=0", "ORDER BY CategoriaId");
            CategoriaIdcomboBox.DataSource = data;
            CategoriaIdcomboBox.ValueMember = "CategoriaId";
            CategoriaIdcomboBox.DisplayMember = "Descripcion";
        }
    }
}
