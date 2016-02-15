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
    public partial class MiembrosForm : Form
    {
        Miembros Registro = new Miembros();

        public MiembrosForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            MiembroIdtextBox.Clear();
            NombrestextBox.Clear();
            ApellidostextBox.Clear();
            ParentrichTextBox.Clear();
        }

        private void ObtenerValores()
        {
            int miembroId= 0;
            int.TryParse(MiembroIdtextBox.Text, out miembroId);
            Registro.MiembroId = miembroId;
            Registro.Nombres = NombrestextBox.Text;
            Registro.Apellidos = ApellidostextBox.Text;
            Registro.Parentesco = ParentrichTextBox.Text;
        }

        private void DevolverValores()
        {
            MiembroIdtextBox.Text = Registro.MiembroId.ToString();
            NombrestextBox.Text = Registro.Nombres.ToString();
            ApellidostextBox.Text = Registro.Apellidos.ToString();
            ParentrichTextBox.Text = Registro.Parentesco.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApellidostextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void NombrestextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void MiembroIdtextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (MiembroIdtextBox.Text == "")
            {
                if (NombrestextBox.Text != "" && ApellidostextBox.Text != "" && ParentrichTextBox.Text != "")
                {
                    if (Registro.Insertar())
                    {
                        Limpiar();
                        MensajeOk("Insertado correctamente");
                    }
                    else
                    {
                        MensajeError("Error al insertar");
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (NombrestextBox.Text != "" && ApellidostextBox.Text != "" && ParentrichTextBox.Text != "")
                {
                    if (Registro.Editar())
                    {
                        Limpiar();
                        MensajeOk("Modificado correctamente");
                    }
                    else
                    {
                        MensajeError("Error al modificar");
                    }
                }
                else
                {
                    MessageBox.Show("Debes llenar todos los campos", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Miembros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Miembros", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Miembros", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (Registro.Buscar(Registro.MiembroId))
            {
                DevolverValores();
            }
            else
            {
                MensajeAdvertencia("Id no encontrado o no existe");
                Limpiar();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerValores();
                if (Registro.Buscar(Registro.MiembroId))
                {
                    if (Registro.Eliminar())
                    {
                        MensajeOk("se ha eliminado correctamente");
                        Limpiar();
                    }
                    else
                    {
                        MensajeError("Error al eliminar");
                    }
                }
                else
                {
                    MensajeAdvertencia("Este Id no existe");
                    Limpiar();
                }
            }
            catch (Exception)
            {
                MensajeError("Error al eliminar");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
