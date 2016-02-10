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

        public Transferencias transferencias = new Transferencias();
        public Cuentas cuentas = new Cuentas();
        public Usuarios usuarios = new Usuarios();
        public DataTable dato = new DataTable();
        public int MontoOrigen;
        public int MontoTransferir;

        private void TransferenciasForm_Load(object sender, EventArgs e)
        {
            dato = cuentas.Listado("*", "0=0", "ORDER BY CuentaId");

            for (int i = 0; i <= dato.Rows.Count - 1; i++)
            {
                comboBoxCuentaOrigen.Items.Add(cuentas.Listado("*", "0=0", "ORDER BY CuentaId").Rows[i]["CuentaId"]);
                comboBoxCuentaDestino.Items.Add(cuentas.Listado("*", "0=0", "ORDER BY CuentaId").Rows[i]["CuentaId"]);
            }


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
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Limpiar()
        {
            textBoxId.Clear();
            textBoxMonto.Clear();
            textBoxObservacion.Clear();
            textBoxDescricionCuentaOrigen.Clear();
            textBoxMontoCuentaOrigen.Clear();
            textBoxDescripcionCuentaDestino.Clear();
            textBoxMontoCuentaDestino.Clear();
        }

        private void ObtenerValores()
        {
            int transferenciaId = 0;
            int.TryParse(textBoxId.Text, out transferenciaId);
            transferencias.TransferenciaId = transferenciaId;
            float monto = 0;
            float.TryParse(textBoxMonto.Text, out monto);
            transferencias.Monto = monto;
            transferencias.Fecha = dateTimePickerTransferencia.Text;
            transferencias.UsuarioId = usuarios.UsuarioId;
            transferencias.Observacion = textBoxObservacion.Text;
            transferencias.UsuarioId = usuarios.UsuarioId;
        }

        private void ObtenerOrigen()
        {
            transferencias.OrigenId = int.Parse(comboBoxCuentaOrigen.Text);
        }

        private void ObtenerDestino()
        {
            transferencias.DestinoId = int.Parse(comboBoxCuentaDestino.Text);
        }

        private void DevolverOrigen()
        {
            textBoxDescricionCuentaOrigen.Text = cuentas.Descripcion;
            textBoxMontoCuentaOrigen.Text = cuentas.Balance.ToString();
        }

        private void DevolverDestino()
        {
            textBoxDescripcionCuentaDestino.Text = cuentas.Descripcion;
            textBoxMontoCuentaDestino.Text = cuentas.Balance.ToString();
        }

        private void DevolverValores()
        {
            textBoxId.Text = transferencias.TransferenciaId.ToString();
            dateTimePickerTransferencia.Text = transferencias.Fecha.ToString();
            textBoxMonto.Text = transferencias.Monto.ToString();
            comboBoxCuentaOrigen.Text = transferencias.OrigenId.ToString();
            comboBoxCuentaDestino.Text = transferencias.DestinoId.ToString();
            textBoxObservacion.Text = transferencias.Observacion;
        }

        private void buttonBuscarId_Click(object sender, EventArgs e)
        {
                ObtenerValores();
                if (transferencias.Buscar(transferencias.TransferenciaId))
                {
                     DevolverValores();
                }
                else
                {
                    MensajeAdvertencia("Id no encontrado");
                    Limpiar();
                }
        }


        private void comboBoxCuentaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerOrigen();
            if (cuentas.Buscar(transferencias.OrigenId))
            {
                DevolverOrigen();
            }
            else
            {
                MensajeAdvertencia("Id no encontrado");
                Limpiar();
            }
        }

        private void comboBoxCuentaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerDestino();
            if (cuentas.Buscar(transferencias.DestinoId))
            {
                DevolverDestino();
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

        private void Verificar()
        {
            int.TryParse(textBoxMontoCuentaOrigen.Text, out MontoOrigen);
            int.TryParse(textBoxMonto.Text, out MontoTransferir);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
                ObtenerValores();
                if (textBoxId.Text == "")
                {
                    if (textBoxMonto.Text != "" && comboBoxCuentaOrigen.Text != "" && comboBoxCuentaDestino.Text != "" && textBoxObservacion.Text != "" && textBoxDescripcionCuentaDestino.Text != "")
                    {
                        Verificar();
                        if (MontoOrigen >= MontoTransferir) { 
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
                                MessageBox.Show("Monto a transferir debe ser menor al monto de la cuenta", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    else
                    {
                        MessageBox.Show("Debe llenar todos los campos", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                Verificar();
                if (MontoOrigen >= MontoTransferir)
                {
                    if (textBoxMonto.Text != "" && textBoxMontoCuentaOrigen.Text != "" && textBoxDescripcionCuentaDestino.Text != "")
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
                else
                {
                    MessageBox.Show("Monto a transferir debe ser menor al monto de la cuenta", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
