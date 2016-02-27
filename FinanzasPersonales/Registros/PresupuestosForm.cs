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
    public partial class PresupuestosForm : Form
    {
        Presupuestosj presupuesto = new Presupuestosj();
        public PresupuestosForm()
        {
            InitializeComponent();
        }
        private void Limpiar() {
            PresupuestoDataGridView.Rows.Clear();
            PresupuestoerrorProvider.Clear();
          //  CategoriaComboBox.SelectedIndex = 0;
           PresupuestoIdtexboxNumerico.Clear();
            DescripcionTextBox.Clear();
            MontotexboxNumerico.Clear();
            DescripcionTextBox.Focus();

        }
        private void LLenarDatos()
        {
            int id = 0;
            int.TryParse(PresupuestoIdtexboxNumerico.Text, out id);
            presupuesto.PresupuestoId = id;
            DescripcionTextBox.Text = presupuesto.Descripcion;
            foreach (DataGridViewRow row in PresupuestoDataGridView.Rows)
            {
                presupuesto.AgregarPresupuesto((float)row.Cells["Monto"].Value);
            }
            
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
            if (!DescripcionTextBox.Text.Equals("") && MontotexboxNumerico.Text.Equals("") && PresupuestoDataGridView.RowCount > 0)
            {
                PresupuestoerrorProvider.Clear();
                DescripcionTextBox.Focus();
                return false;
            }
            else
            {
                PresupuestoerrorProvider.SetError(DescripcionTextBox, "Introduzca Una Descripcion!");
                PresupuestoerrorProvider.SetError(MontotexboxNumerico, "Este Campo debe de esta vacio!");
                PresupuestoerrorProvider.SetError(PresupuestoDataGridView, "Debe de Añadir por lo menos un Presupusto!");

                return false;
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
        private void PresupuestosForm_Load(object sender, EventArgs e)
        {
            DataTable datos = new DataTable();
            Categorias categoria = new Categorias();
            datos = categoria.Listado("CategoriaId, Descripcion", "0=0", "ORDEN BY CategoriId");

            CategoriaComboBox.ValueMember = "CategoriaId";
            CategoriaComboBox.DisplayMember = "Descripcion";

            CategoriaComboBox.DataSource = datos;
        }

        private void CategoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoriaComboBox.SelectedValue != null)
            {
                DataRow row = (DataRow)CategoriaComboBox.SelectedItem;

            }
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            string filtro = "1=1";
            try
            {
                int.TryParse(PresupuestoIdtexboxNumerico.Text, out id);
                if (ValidarTexbox(PresupuestoIdtexboxNumerico) && presupuesto.Buscar(id))
                {
                    PresupuestoIdtexboxNumerico.Text = presupuesto.PresupuestoId.ToString();
                    DescripcionTextBox.Text = presupuesto.Descripcion;
                    PresupuestoDataGridView.DataSource = presupuesto.ListadoPresupuesto("CategoriaId,Monto", filtro, "");
                    ActivarBotones(true);
                }
                else
                {
                    Mensajes(2, "Id no Existe!");
                    Limpiar();
                    ActivarBotones(false);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (ValidarTexbox(MontotexboxNumerico))
            {
                float monto = float.Parse(MontotexboxNumerico.Text);
                presupuesto.AgregarPresupuesto(monto);
                PresupuestoDataGridView.Rows.Add(CategoriaComboBox.SelectedValue, MontotexboxNumerico.Text);
                MontotexboxNumerico.Clear();
                MontotexboxNumerico.Focus();
            }
            else
            {
                MontotexboxNumerico.Focus();
            }


        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            GuardarButton.Enabled = true;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            LLenarDatos();
            try
            {
                
                if (PresupuestoIdtexboxNumerico.Equals("") && Validar()==false)
                {
                    if (presupuesto.Insertar())
                    {
                        Mensajes(1, "Presupuesto insertado Correctamente!");
                        Limpiar();
                        ActivarBotones(false);
                    }
                    else
                    {
                        Mensajes(2, "Error en Insertar!");
                        Limpiar();
                        ActivarBotones(false);
                    }
                }
                else
                {
                    int.TryParse(PresupuestoIdtexboxNumerico.Text, out id);
                    if (presupuesto.Buscar(id) &&Validar()==false)
                    {
                        if (presupuesto.Editar())
                        {
                            Mensajes(1, "Presupuesto Modificado Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Mensajes(2, "Error en Modificar Presupuesto!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                int.TryParse(PresupuestoIdtexboxNumerico.Text, out id);
                if (ValidarTexbox(PresupuestoIdtexboxNumerico) && presupuesto.Buscar(id))
                {
                    if (presupuesto.Eliminar())
                    {
                        Mensajes(1, "Presupuesto Eliminado!");
                        Limpiar();
                        ActivarBotones(false);
                    }else
                    {
                        Mensajes(2, "Error en Eliminar!");
                        Limpiar();
                        ActivarBotones(false);
                    }
                }
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
