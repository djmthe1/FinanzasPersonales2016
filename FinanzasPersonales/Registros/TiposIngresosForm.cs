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
    public partial class TiposIngresosForm : Form
    {
        public TiposIngresosForm()
        {
            InitializeComponent();
        }

        TiposIngresos tipoingreso = new TiposIngresos();
        Usuarios usuario = new Usuarios();

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text.Trim() == "")
            {
                TipoIngresoerrorProvider.SetError(IdtextBox, "Debe especificar el ID ");
                IdtextBox.Focus();
            }
            else
            {
                TipoIngresoerrorProvider.Clear();
            }
            if (IdtextBox.TextLength > 0)
            {
                int id;
                int.TryParse(IdtextBox.Text, out id);
                tipoingreso.Buscar(id);
                DescripciontextBox.Text = tipoingreso.Descripcion;
                if(tipoingreso.EsActivo == true)
                {
                     SiradioButton.Checked = true;
                }
                if (tipoingreso.EsActivo == false)
                {
                    NoradioButton.Checked = true;
                }
            }
        }
        private void Limpiar()
        {
            IdtextBox.Clear();
            DescripciontextBox.Clear();
            NoradioButton.Checked = false;
            SiradioButton.Checked = false;
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (DescripciontextBox.Text.Length == 0)
            {
                MessageBox.Show("Los campo deben estar lleno ");
            }
            else
            {
                tipoingreso.Descripcion = DescripciontextBox.Text;
                if (SiradioButton.Checked == true)
                {
                    tipoingreso.EsActivo = true;
                }
                if (NoradioButton.Checked == true)
                {
                    tipoingreso.EsActivo = false;
                }
                tipoingreso.UsuarioId = usuario.UsuarioId;
                if (IdtextBox.Text.Length == 0)
                {
                    if (tipoingreso.Insertar())
                    {
                        MessageBox.Show("El tipo de Ingreso se Guardo Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("El tipo de Ingreso no ha sido Guardada Correctamente");
                    }
                }
                else
                {
                    if (IdtextBox.Text.Length != 0)
                    {
                        tipoingreso.TipoIngresoId = Convert.ToInt32(IdtextBox.Text);
                        if (tipoingreso.Editar())
                        {
                            MessageBox.Show("El tipo de Ingreso se editada Correctamente");
                        }
                        else
                        {
                            MessageBox.Show("El tipo de Ingreso no ha sido editada Correctamente");
                        }
                    }
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text.Trim() == "")
            {
                TipoIngresoerrorProvider.SetError(IdtextBox, "Debe especificar el ID ");
                IdtextBox.Focus();
            }
            else
            {
                TipoIngresoerrorProvider.Clear();
                if (IdtextBox.Text.Length > 0)
                {
                    tipoingreso.TipoIngresoId = int.Parse(IdtextBox.Text);

                    if (tipoingreso.Eliminar())
                    {
                        MessageBox.Show("El tipo de Ingreso se elimino Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("El tipo de Ingreso no ha sido eliminada Correctamente");
                    }
                }
            }
        }

        private void TiposIngresosForm_Load(object sender, EventArgs e)
        {

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
    }
}
