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
            textBoxCuentaDeOrigen.Clear();
            textBoxCuentaDeDestino.Clear();
            textBoxObservacion.Clear();
        }

        private void ObtenerValores()
        {
            int TransferenciaId = 0;
            int.TryParse(textBoxId.Text, out TransferenciaId);
            transferencias.TransferenciaId = TransferenciaId;
            int UsuarioId = 0;
            int.TryParse(textBoxUsuario.Text, out UsuarioId);
            transferencias.UsuarioId = UsuarioId;
            float Monto = 0;
            float.TryParse(textBoxMonto.Text, out Monto);
            transferencias.Monto = Monto;
            int Origen = 0;
            int.TryParse(textBoxCuentaDeOrigen.Text, out Origen);
            transferencias.CuentaDeOrigenId = Origen;
            int Destino = 0;
            int.TryParse(textBoxCuentaDeDestino.Text, out Destino);
            transferencias.CuentaDeDestinoId = Destino;
            transferencias.Fecha = dateTimePickerTranferencia.Text;
            transferencias.Observacion = textBoxObservacion.Text;
        }

        private void buttonBuscarId_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerValores();

                if (transferencias.Buscar(transferencias.TransferenciaId))
                {
                    /*textBoxId.Text = transferencias.TransferenciaId.ToString;
                    dateTimePickerTranferencia.Text = transferencias.Fecha;
                    textBoxUsuario.Text = transferencias.UsuarioId.ToString;
                    textBoxMonto.Text = transferencias.Monto.ToString;
                    textBoxMontoCuentaOrigen.Text = transferencias.CuentaDeOrigenId.ToString;
                    textBoxMontoCuentaDestino.Text = transferencias.CuentaDeDestinoId.ToString;
                    textBoxObservacion.Text = transferencias.Observacion;*/
                }
                else
                {
                    MensajeAdvertencia("Id no encontrado");
                    Limpiar();
                }
            }
            catch (Exception)
            {
                MensajeError("Error al Buscar");
            }
        }

        private void buttonBuscarIdUsuario_Click(object sender, EventArgs e)
        {
            ObtenerValores();
        }

        private void buttonBuscarCuentaOrigen_Click(object sender, EventArgs e)
        {
            ObtenerValores();
        }

        private void buttonBuscarCuentaDestino_Click(object sender, EventArgs e)
        {
            ObtenerValores();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

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
                        MensajeError("Error al Eliminar");
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
                MensajeError("Error al Eliminar");
            }
        }
    }
}
