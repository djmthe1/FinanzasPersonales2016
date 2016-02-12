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
    public partial class CuantasxCobrarForm : Form
    {
        public CuantasxCobrarForm()
        {
            InitializeComponent();
        }
        CuentasxCobrar CxC = new CuentasxCobrar();
        Cuentas cuentas = new Cuentas();
        private void Limpiar()
        {
            this.CxcIdTextBox.Clear();
            this.ComboBoxCuentaId.Text = "";
            this.textBoxConcepto.Clear();
            this.TextBoxMonto.Clear();
            this.TextBoxBalance.Clear();
        }
        public void LlenarDatos()
        {
            int CuentasxC = 0;
            int.TryParse(CxcIdTextBox.Text, out CuentasxC);
            CxC.CxcId = CuentasxC;
            CxC.Fecha = dateTimePickerCuentasxCobrar.Text;
            cuentas.CuentaId = CxC.CuentaId;
            CxC.Concepto = textBoxConcepto.Text;
            float Monto = 0;
            float.TryParse(TextBoxMonto.Text, out Monto);
            CxC.Monto = Monto;
            float balance = 0;
            float.TryParse(TextBoxBalance.Text, out balance);
            CxC.Balance = balance-Monto;

        }
        private void ValidarTexbox(TextBox tb)
        {
            if (tb.Text == "")
            {
                errorProviderCuentasxCobrar.SetError(tb, "El Campo esta vacio!!");
                tb.Focus();
            }
            else
            {
                errorProviderCuentasxCobrar.Clear();
            }
        }
        //1 Informacion...2 Error....3 Cuidado.
        private void Mensajes(int selec, string mensaje)
        {
            switch (selec)
            {
                case 1:
                    MessageBox.Show(mensaje, "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
        //Esto es para llenar el combobox con Las CuentaId de la tabla Cuenta
        private void CuantasxCobrarForm_Load(object sender, EventArgs e)
        {
            DataTable datos = new DataTable();
            datos = cuentas.Listado("*", "0=0", "ORDER BY CuentaId");

            for (int i = 0; i <= datos.Rows.Count - 1; i++)
            {
                ComboBoxCuentaId.Items.Add(cuentas.Listado("*", "0=0", "ORDER BY CuentaId").Rows[i]["CuentaId"]);
            }
        }
        private void CxcIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar>=48 && e.KeyChar <=57) || (e.KeyChar==8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void ComboBoxCuentaId_SelectedIndexChanged(object sender, EventArgs e)
        {
            CxC.CuentaId = int.Parse(this.ComboBoxCuentaId.Text);
            if (cuentas.Buscar(CxC.CuentaId))
            {
                textBoxConcepto.Text = cuentas.Descripcion.ToString();
                TextBoxBalance.Text = cuentas.Balance.ToString();
            }
            else
            {
                Mensajes(2, "Id de Cuenta no Existe!");
                Limpiar();
            }

        }
        private void textBoxConcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)|| (e.KeyChar==130) || (e.KeyChar >= 160 && e.KeyChar <= 165)))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TextBoxMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 46))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBoxBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar == 46))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarDatos();
                EliminarButton.Enabled = true;
                ValidarTexbox(CxcIdTextBox);
                if (CxC.Buscar(int.Parse(CxcIdTextBox.Text)))
                {
                    CxcIdTextBox.Text=  CxC.CxcId.ToString();
                    dateTimePickerCuentasxCobrar.Text = CxC.Fecha.ToString();
                    ComboBoxCuentaId.Text = cuentas.CuentaId.ToString();
                    textBoxConcepto.Text = CxC.Concepto.ToString();
                    TextBoxMonto.Text = CxC.Monto.ToString();
                    TextBoxBalance.Text = CxC.Balance.ToString();
                }
                else
                {
                    Mensajes(2, "Id No Existe, \n Intente Nuevamente!");
                    Limpiar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            GuardarButton.Enabled = true;
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {

                
                ValidarTexbox(textBoxConcepto);
                ValidarTexbox(TextBoxMonto);
                ValidarTexbox(TextBoxBalance);
                LlenarDatos();
                if (CxcIdTextBox.Text == "")
                {
                    if (ComboBoxCuentaId.Text != "" && textBoxConcepto.Text != "" && TextBoxMonto.Text != "" && TextBoxBalance.Text != "")
                    {
                        
                        errorProviderCuentasxCobrar.Clear();
                       
                        if (CxC.Insertar())
                        {
                            Mensajes(1, "Guardado Correctamente!");
                            Limpiar();
                        }
                        else
                        {
                            Mensajes(2, "Error en Guardar!");

                        }
                    }
                    else
                    {
                        Mensajes(3, "No debe de haber campos Vacios!");
                        Limpiar();
                        textBoxConcepto.Focus();
                    }
                }
                else
                {
                    ValidarTexbox(CxcIdTextBox);
                    ValidarTexbox(textBoxConcepto);
                    ValidarTexbox(TextBoxMonto);
                    ValidarTexbox(TextBoxBalance);
                    if (CxC.Buscar(int.Parse(CxcIdTextBox.Text)) && ComboBoxCuentaId.Text != "" && textBoxConcepto.Text != "" && TextBoxMonto.Text != "" && TextBoxBalance.Text != "")
                    {
                        LlenarDatos();
                        if (CxC.Editar())
                        {
                            Mensajes(1, "Modificado Correctamente!");
                            Limpiar();
                        }
                        else
                        {
                            Mensajes(2, "Error en Modificar.");
                        }
                    }
                    else
                    {
                        Mensajes(3, "Id No Existe!");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
          
        

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarDatos();
                DialogResult resut;
                //Dialogo para confirmar que se desea Eliminar...
                resut = MessageBox.Show("¿Esta seguro que desea eliminar?", "Meensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resut == DialogResult.Yes)
                {

                    if (CxC.Buscar(int.Parse(CxcIdTextBox.Text)))
                    {
                        if (CxC.Eliminar())
                        {
                            Mensajes(1, "Eliminado Correctamente!");
                            Limpiar();
                            EliminarButton.Enabled = false;
                        }
                        else
                        {
                            Mensajes(2, "Error en Eliminar!");
                            Limpiar();
                        }
                    }
                    else
                    {
                        Mensajes(1, "Id No Encontrado!");
                        CxcIdTextBox.Focus();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        

    }
}
