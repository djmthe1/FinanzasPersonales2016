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
    public partial class CuentasForm : Form
    {
        public CuentasForm()
        {
            InitializeComponent();
        }

        Cuentas cuentas = new Cuentas();

        private void CuentasForm_Load(object sender, EventArgs e)
        {

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 46))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ObtenerValores()
        {
            int cuentaId = 0;
            int.TryParse(textBoxId.Text, out cuentaId);
            cuentas.CuentaId = cuentaId;
            cuentas.Descripcion = textBoxDescripcion.Text;
            float balance = 0;
            float.TryParse(textBoxBalance.Text, out balance);
            cuentas.Balance = balance;
        }

        private void DevolverValores()
        {
            textBoxId.Text = cuentas.CuentaId.ToString();
            textBoxDescripcion.Text = cuentas.Descripcion.ToString();
            textBoxBalance.Text = cuentas.Balance.ToString();
        }

        private void Limpiar()
        {
            textBoxId.Clear();
            textBoxDescripcion.Clear();
            textBoxBalance.Clear();
        }

        private void buttonBuscarId_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (cuentas.Buscar(cuentas.CuentaId))
            {
                DevolverValores();
            }
            else
            {
                MensajeAdvertencia("Id no encontrado");
                Limpiar();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            ObtenerValores();

            if (textBoxId.Text == "")
            {
                if (textBoxDescripcion.Text != "" && textBoxBalance.Text != "")
                {
                    if (cuentas.Insertar())
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
                if (textBoxDescripcion.Text != "" && textBoxBalance.Text != "")
                {
                    if (cuentas.Editar())
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
                    MessageBox.Show("Debe llenar todos los campos", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerValores();
                if (cuentas.Buscar(cuentas.CuentaId))
                {
                    if (cuentas.Eliminar())
                    {
                        MensajeOk("Eliminado correctamente");
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
    }
}
