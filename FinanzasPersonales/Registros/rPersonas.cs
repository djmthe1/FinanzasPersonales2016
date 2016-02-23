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

        private void AgregarTelefonobutton_Click(object sender, EventArgs e)
        {
            //persona.AgregarTelefono((TiposTelefonos)TipoTelefonocomboBox.SelectedValue, TelefonotextBox.Text);
            //TelefonosdataGridView.AutoGenerateColumns = false;
                        //TelefonosdataGridView.DataSource = persona.Telefonos;

            TelefonosdataGridView.Rows.Add(TipoTelefonocomboBox.SelectedValue,TelefonotextBox.Text );

            TelefonotextBox.Clear();
            TelefonotextBox.Focus();
        }

        
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Personas persona = new Personas();

            LlenarDatos( persona);

            persona.Insertar();

        }

        private void LlenarDatos(Personas persona)
        {
            persona.PersonaId = 0;
            persona.Nombre = "";

            foreach (DataGridViewRow  row in TelefonosdataGridView.Rows )
            {
                persona.AgregarTelefono((TiposTelefonos )row.Cells["Tipo"].Value,row.Cells["Telefono"].ToString());

            }  
        }
    }
}
