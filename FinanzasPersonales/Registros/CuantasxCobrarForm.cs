﻿using System;
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
            float Monto = 0;
            float.TryParse(TextBoxMonto.Text, out Monto);
            CxC.Monto = Monto;
            float balance = 0;
            float.TryParse(TextBoxBalance.Text, out balance);
            CxC.Balance = balance;

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

        private void textBoxConcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 96 && e.KeyChar <= 122 || (e.KeyChar == 32) || (e.KeyChar >= 160 && e.KeyChar <= 165)))
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
                ValidarTexbox(CxcIdTextBox);
                if (CxC.Buscar(int.Parse(CxcIdTextBox.Text)))
                {
                    CxcIdTextBox.Text=  CxC.CxcId.ToString();
                    dateTimePickerCuentasxCobrar.Text = CxC.Fecha.ToString();
                    ComboBoxCuentaId.Text = cuentas.CuentaId.ToString();
                    textBoxConcepto.Text = CxC.Copcepto.ToString();
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

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

        }
    }
}