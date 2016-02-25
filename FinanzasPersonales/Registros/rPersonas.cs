using BLL;
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
    public partial class rPersonas : Form
    {
        //private Personas persona;
        public rPersonas()
        {
            InitializeComponent();
            //persona = new Personas();
        }

        private void rPersonas_Load(object sender, EventArgs e)
        {
            TipoTelefonocomboBox.DataSource = Enum.GetValues(typeof(TiposTelefonos));
        }
        private void LlenarDatos(Personas persona)
        {
            persona.PersonaId = 0;
            persona.Nombre = "";

            foreach (DataGridViewRow row in TelefonosdataGridView.Rows)
            {
                persona.AgregarTelefono((TiposTelefonos)row.Cells["Tipo"].Value, row.Cells["Telefono"].ToString());

            }
        }
        private void Limpiar()
        {
            PersonaIdtextBox.Clear();
            NombrestextBox.Clear();
            TipoTelefonocomboBox.SelectedIndex = 0;
            TelefonosdataGridView.Rows.Clear();
            PersonaErrorProvider.Clear();
        }
        private bool ComprobarTextbox()
        {
            if (NombrestextBox.Text.Equals("") && TelefonotextBox.Text.Equals("") && TelefonosdataGridView.RowCount == 0)
            {
                PersonaErrorProvider.SetError(NombrestextBox, "Introduzca Un Nombre!");
                PersonaErrorProvider.SetError(TelefonotextBox, "Introduzca Un Numero de Teleno!");
                PersonaErrorProvider.SetError(TelefonosdataGridView, "Debe de Añadir por lo menos un Numero de Telefono!");
                NombrestextBox.Focus();
                return true;
            }
            else
            {
                PersonaErrorProvider.Clear();
                return false;
            }
                
                
        }
        private void PersonaIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {

                NombrestextBox.Focus();
            }
        }

        private void NombrestextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;

            if (e.KeyChar == 13)
            {
                TelefonotextBox.Focus();
            }
        }
        private void TelefonotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                NombrestextBox.Focus();
            }
        }

        private void AgregarTelefonobutton_Click(object sender, EventArgs e)
        {
            //persona.AgregarTelefono((TiposTelefonos)TipoTelefonocomboBox.SelectedValue, TelefonotextBox.Text);
            //TelefonosdataGridView.AutoGenerateColumns = false;
                        //TelefonosdataGridView.DataSource = persona.Telefonos;

            TelefonosdataGridView.Rows.Add(TipoTelefonocomboBox.SelectedValue,TelefonotextBox.Text );

            TelefonotextBox.Clear();
            TelefonotextBox.Focus();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Personas persona = new Personas();

            LlenarDatos( persona);
            try
            {
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
           

        }

        

        
        
    }
}
