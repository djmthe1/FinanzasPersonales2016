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

namespace FinanzasPersonales.Consultas
{
    public partial class ConsultaCuentas : Form
    {
        public ConsultaCuentas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Cuentas cuenta = new Cuentas();
            string filtro = "1=1";

            if (FiltrotextBox.Text.Length > 0)
            {
                filtro = CamposcomboBox.Text + " like '%" + FiltrotextBox.Text + "%'";
            }

            ConsultadataGridView.DataSource = cuenta.Listado("CuentaId,Descripcion,Balance", filtro, "");

            ConteotextBox.Text = ConsultadataGridView.RowCount.ToString();
        }
    }
}
