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
        Personas persona = new Personas();
        public rPersonas()
        {
            InitializeComponent();
            GuardarButton.Enabled = false;
            EliminarButton.Enabled = false;

        }

        private void rPersonas_Load(object sender, EventArgs e)
        {
            TipoTelefonocomboBox.DataSource = Enum.GetValues(typeof(TiposTelefonos));
        }
        private void LlenarDatos(Personas persona)
        {
            int id = 0;
            int.TryParse(PersonaIdtextBox.Text, out id);
            persona.PersonaId = id;
      
            persona.Nombre = NombrestextBox.Text;
            foreach (DataGridViewRow row in TelefonosdataGridView.Rows)
            {
                persona.AgregarTelefono((TiposTelefonos)row.Cells["Tipo"].Value, row.Cells["Telefono"].ToString());

            }
        }
        //1 Informacion...2 Error....3 Cuidado.
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
        public void ActivarBotones(bool btn)
        {
            GuardarButton.Enabled = btn;
            EliminarButton.Enabled = btn;
        }
        private void Limpiar()
        {
            PersonaIdtextBox.Clear();
            NombrestextBox.Clear();
            TelefonotextBox.Clear();
            TipoTelefonocomboBox.SelectedIndex = 0;
            TelefonosdataGridView.Rows.Clear();
            PersonaErrorProvider.Clear();
        }
        private bool Validar()
        {
            if (!NombrestextBox.Text.Equals("") && TelefonotextBox.Text.Equals("") && TelefonosdataGridView.RowCount > 0)
            {
                PersonaErrorProvider.Clear();
                NombrestextBox.Focus();
                return false;
            }
            else
            {
                PersonaErrorProvider.SetError(NombrestextBox, "Introduzca Un Nombre!");
                PersonaErrorProvider.SetError(TelefonotextBox, "Introduzca Un Numero de Teleno!");
                PersonaErrorProvider.SetError(TelefonosdataGridView, "Debe de Añadir por lo menos un Numero de Telefono!");
               
                return true;
            }
                
                
        }
        private bool ValidarTexbox(TextBox tb)
        {
            if (!tb.Text.Equals(""))
            {
               
                PersonaErrorProvider.Clear();
                return true;
            }
            else
            {
                PersonaErrorProvider.SetError(tb, "El Campo esta vacio!!");
                tb.Focus();
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
            if ((e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 160 && e.KeyChar <= 163))
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
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            
            int.TryParse(PersonaIdtextBox.Text, out id);
            try
            {
                if (ValidarTexbox(PersonaIdtextBox) && persona.Buscar(id))
                {
                    PersonaIdtextBox.Text = persona.PersonaId.ToString();
                    NombrestextBox.Text = persona.Nombre;
                    
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

                throw ex;
            }
        }
        private void AgregarTelefonobutton_Click(object sender, EventArgs e)
        {
            persona.AgregarTelefono((TiposTelefonos)TipoTelefonocomboBox.SelectedValue, TelefonotextBox.Text);
            //TelefonosdataGridView.AutoGenerateColumns = false;
                        //TelefonosdataGridView.DataSource = persona.Telefonos;

            TelefonosdataGridView.Rows.Add(TipoTelefonocomboBox.SelectedValue,TelefonotextBox.Text );

            TelefonotextBox.Clear();
            TelefonotextBox.Focus();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
            GuardarButton.Enabled = true;
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Personas persona = new Personas();

            LlenarDatos( persona);
            try
            {
                if (PersonaIdtextBox.Text.Equals("") && Validar()==false)
                {
                    if (persona.Insertar())
                    {
                        Mensajes(1, "Insertado Correctamente!");
                        Limpiar();
                        ActivarBotones(false);
                    }
                    else
                    {
                        Mensajes(2, "Error en Insertar");
                        Limpiar();
                        ActivarBotones(false);
                    }
                }
                else
                {
                    if (Validar()==false)
                    {
                        if (persona.Editar())
                        {
                            Mensajes(1, "Modificado Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Mensajes(2, "Error en Modificar!");
                            Limpiar();
                            ActivarBotones(false);
                        }
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
            int id = 0;
            DialogResult resut;
            int.TryParse(PersonaIdtextBox.Text, out id);
            try
            {
                if (persona.Buscar(id))
                {
                    //Dialogo para confirmar que se desea Eliminar...
                    resut = MessageBox.Show("¿Esta seguro que desea eliminar?", "Meensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resut == DialogResult.Yes)
                    {
                        if (persona.Eliminar())
                        {
                            Mensajes(1, "Eliminado Correctamente!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                        else
                        {
                            Mensajes(2, "Error en Elimnar!");
                            Limpiar();
                            ActivarBotones(false);
                        }
                    }
                }
                else
                {
                    PersonaErrorProvider.SetError(PersonaIdtextBox, "Este Id no Existe!");
                    PersonaIdtextBox.Focus();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
    }
}
