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
    public partial class Presupuestos : Form
    {
        public Presupuestos()
        {
            InitializeComponent();
        }

        BLL.Presupuestos pre = new BLL.Presupuestos();
        PresupuestosDetalle preD = new PresupuestosDetalle();

        private void Presupuestos_Load(object sender, EventArgs e)
        {

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Presupuestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Presupuestos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Presupuestos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ObtenerValores()
        {
            int presupuestoId = 0;
            int.TryParse(idTextBox.Text, out presupuestoId);
            pre.PresupuestoId = presupuestoId;
            pre.Descripcion = descripcionTextBox.Text;
            int categoriaId = 0;
            int.TryParse(categoriaComboBox.Text, out categoriaId);
            preD.PresupuestoId = categoriaId;
            float monto = 0;
            float.TryParse(montoTextBox.Text, out monto);
            preD.Monto = monto;
        }

        private void DevolverValores()
        {
            string filtro = "1=1";
            idTextBox.Text = pre.PresupuestoId.ToString();
            descripcionTextBox.Text = pre.Descripcion.ToString();
            categoriaComboBox.Text = preD.CategoriaId.ToString();
            montoTextBox.Text = preD.Monto.ToString();
            presupuestosDataGridView.DataSource = pre.ListadoPresupuestos("categoriaId, Monto", filtro, "");
        }

        private void Limpiar()
        {
            idTextBox.Clear();
            descripcionTextBox.Clear();
            categoriaComboBox.SelectedIndex = -1;
            montoTextBox.Clear();
        }

        private void buscarIdButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(idTextBox.Text, out id);
                pre.PresupuestoId = id;

                if (pre.Buscar(pre.PresupuestoId))
                {
                    DevolverValores();
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

        private void agregarButton_Click(object sender, EventArgs e)
        {
            if (!categoriaComboBox.Text.Equals("") && !montoTextBox.Text.Equals(""))
            {
                    float monto = float.Parse(montoTextBox.Text);
                    pre.AgregarPresupuesto(monto);
                    presupuestosDataGridView.Rows.Add(categoriaComboBox.SelectedValue, montoTextBox.Text);
                    montoTextBox.Clear();
                }
               
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            ObtenerValores();

            if (idTextBox.Text == "")
            {
                if (descripcionTextBox.Text != "")
                {
                    if (pre.Insertar())
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
                    MessageBox.Show("Debe llenar la descripcion", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (descripcionTextBox.Text != "")
                {
                    if (pre.Editar())
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
                if (pre.Buscar(pre.PresupuestoId))
                {
                    if (pre.Eliminar())
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
