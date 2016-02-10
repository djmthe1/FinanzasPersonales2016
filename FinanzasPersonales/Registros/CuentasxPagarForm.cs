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
    public partial class CuentasxPagarForm : Form
    {
        public CuentasxPagarForm()
        {
            InitializeComponent();
        }

        CuentasxPagar cuentasxP = new CuentasxPagar();

        private void CuentasxPagarForm_Load(object sender, EventArgs e)
        {

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Cuentas por Pagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Cuentas por Pagar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Cuentas por Pagar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxConcepto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 46))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ObtenerValores()
        {
            int cxpId = 0;
            int.TryParse(textBoxId.Text, out cxpId);
            cuentasxP.CxpId = cxpId;
            cuentasxP.Fecha = dateTimePickeCuentasxPagar.Text;
            cuentasxP.Concepto = textBoxConcepto.Text;
            float monto = 0;
            float.TryParse(textBoxMonto.Text, out monto);
            cuentasxP.Monto = monto;
            float balance = 0;
            float.TryParse(textBoxBalance.Text, out balance);
            cuentasxP.Balance = balance;
        }

        private void DevolverValores()
        {
            textBoxId.Text = cuentasxP.CxpId.ToString();
            dateTimePickeCuentasxPagar.Text = cuentasxP.Fecha.ToString();
            textBoxConcepto.Text = cuentasxP.Concepto.ToString();
            textBoxMonto.Text = cuentasxP.Monto.ToString();
            textBoxBalance.Text = cuentasxP.Balance.ToString();
        }

        private void Limpiar()
        {
            textBoxId.Clear();
            textBoxConcepto.Clear();
            textBoxMonto.Clear();
            textBoxBalance.Clear();
        }

        private void buttonBuscarId_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (cuentasxP.Buscar(cuentasxP.CxpId))
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
                if (textBoxConcepto.Text != "" && textBoxMonto.Text != "" && textBoxBalance.Text != "")
                {
                    if (cuentasxP.Insertar())
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
                if (textBoxConcepto.Text != "" && textBoxMonto.Text != "" && textBoxBalance.Text != "")
                {
                    if (cuentasxP.Editar())
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
                if (cuentasxP.Buscar(cuentasxP.CxpId))
                {
                    if (cuentasxP.Eliminar())
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
