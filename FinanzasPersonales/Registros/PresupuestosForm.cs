using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanzasPersonales.Registros
{
    public partial class PresupuestosForm : Form
    {
        public PresupuestosForm()
        {
            InitializeComponent();
        }
        private void Limpiar() {
            PresupuestoDataGridView.Rows.Clear();
            PresupuestoerrorProvider.Clear();
            CategoriaComboBox.SelectedIndex = 0;
            PresupuestoIdtextboxNumerico.Clear();
            DescripcionTextBox.Clear();
            MontotexboxNumerico.Clear();
            DescripcionTextBox.Focus();

        }
        private void Mensajes(int selec, string mensaje)
        {
            switch (selec)
            {
                case 1:
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show(mensaje, "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
        }
        //Metodo para activar y desaptivar botones
        public void ActivarBotones(bool btn)
        {
            GuardarButton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
        //Metodos para validar Llos textbox y el DataGripView
        private bool Validar()
        {
            if (!DescripcionTextBox.Text.Equals("") && !MontotexboxNumerico.Text.Equals("") && PresupuestoDataGridView.RowCount > 0)
            {
                PresupuestoerrorProvider.Clear();
                DescripcionTextBox.Focus();
                return false;
            }
            else
            {
                PresupuestoerrorProvider.SetError(DescripcionTextBox, "Introduzca Un Nombre!");
                PresupuestoerrorProvider.SetError(MontotexboxNumerico, "Introduzca Un Numero de Teleno!");
                PresupuestoerrorProvider.SetError(PresupuestoDataGridView, "Debe de Añadir por lo menos un Numero de Telefono!");

                return true;
            }


        }
        private bool ValidarTexbox(TextBox tb)
        {
            if (!tb.Text.Equals(""))
            {

                PresupuestoerrorProvider.Clear();
                return true;
            }
            else
            {
                PresupuestoerrorProvider.SetError(tb, "El Campo esta vacio!!");
                tb.Focus();
                return false;

            }
        }
        private void DescripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;

            if (e.KeyChar == 13)
            {
                MontotexboxNumerico.Focus();
            }
        }
    }
}
