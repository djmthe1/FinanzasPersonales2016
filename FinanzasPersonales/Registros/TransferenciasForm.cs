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
    public partial class TransferenciasForm : Form
    {
        public TransferenciasForm()
        {
            InitializeComponent();
        }

        Transferencias transferencias = new Transferencias();
        Cuentas cuentas = new Cuentas();
        //Usuarios usuarios = new Usuarios();

        private void TransferenciasForm_Load(object sender, EventArgs e)
        {

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Transferencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Transferencias", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Transferencias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
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

        private void textBoxCuentaDeOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxCuentaDeDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxObservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Limpiar()
        {
            textBoxId.Clear();
            textBoxUsuario.Clear();
            textBoxMonto.Clear();
            textBoxCuentaDeOrigenId.Clear();
            textBoxCuentaDeDestinoId.Clear();
            textBoxObservacion.Clear();
        }

        private void ObtenerValores()
        {
            int transferenciaId = 0;
            int.TryParse(textBoxId.Text, out transferenciaId);
            transferencias.TransferenciaId = transferenciaId;
            int usuarioId = 0;
            int.TryParse(textBoxUsuario.Text, out usuarioId);
            transferencias.UsuarioId = usuarioId;
            float monto = 0;
            float.TryParse(textBoxMonto.Text, out monto);
            transferencias.Monto = monto;
            int origen = 0;
            int.TryParse(textBoxCuentaDeOrigenId.Text, out origen);
            transferencias.CuentaDeOrigenId = origen;
            int destino = 0;
            int.TryParse(textBoxCuentaDeDestinoId.Text, out destino);
            transferencias.CuentaDeDestinoId = destino;
            transferencias.Fecha = dateTimePickerTransferencia.Text;
            transferencias.Observacion = textBoxObservacion.Text;
        }

        private void buttonBuscarId_Click(object sender, EventArgs e)
        {
                ObtenerValores();
                if (transferencias.Buscar(transferencias.TransferenciaId))
                {
                    textBoxId.Text = transferencias.TransferenciaId.ToString();
                    dateTimePickerTransferencia.Text = transferencias.Fecha.ToString();
                    textBoxUsuario.Text = transferencias.UsuarioId.ToString();
                    textBoxMonto.Text = transferencias.Monto.ToString();
                    textBoxCuentaDeOrigenId.Text = transferencias.CuentaDeOrigenId.ToString();
                    textBoxCuentaDeDestinoId.Text = transferencias.CuentaDeDestinoId.ToString();
                    textBoxObservacion.Text = transferencias.Observacion;
                }
                else
                {
                    MensajeAdvertencia("Id no encontrado");
                    Limpiar();
                }
        }

        private void buttonBuscarCuentaOrigen_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (cuentas.Buscar(transferencias.CuentaDeOrigenId))
            {
                textBoxDescricionCuentaOrigen.Text = cuentas.Descripcion.ToString();
                textBoxMontoCuentaOrigen.Text = cuentas.Balance.ToString();
            }
            else
            {
                MensajeAdvertencia("Id no encontrado");
                Limpiar();
            }
        }

        private void buttonBuscarCuentaDestino_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (cuentas.Buscar(transferencias.CuentaDeDestinoId))
            {
                textBoxDescripcionCuentaDestino.Text = cuentas.Descripcion.ToString();
                textBoxMontoCuentaDestino.Text = cuentas.Balance.ToString();
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
                    if (textBoxUsuario.Text != "" || textBoxMonto.Text != "" || textBoxCuentaDeOrigenId.Text != "" || textBoxCuentaDeDestinoId.Text != "" || textBoxObservacion.Text != "")
                    {
                        if (transferencias.Insertar())
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
                    if (textBoxUsuario.Text != "" || textBoxMonto.Text != "" || textBoxCuentaDeOrigenId.Text != "" || textBoxCuentaDeDestinoId.Text != "")
                    {
                        if (transferencias.Editar())
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
                if (transferencias.Buscar(transferencias.TransferenciaId))
                {
                    if (transferencias.Eliminar())
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
