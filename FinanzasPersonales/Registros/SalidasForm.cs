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
    public partial class SalidasForm : Form
    {
        int Salida;
        int IdBuscado;
        Salidas Registro = new Salidas();

        public SalidasForm()
        {
            InitializeComponent();
        }

        private void BuscarSalidaIdbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(SalidaIdtextBox.Text, out id);
            IdBuscado = id;
            if (Registro.Buscar(IdBuscado))
            {
                Registro.SalidaId = IdBuscado;
                CuentaIdtextBox.Text = Registro.CuentaId.ToString();
                FechadateTimePicker.Text = Registro.Fecha;
                MontotextBox.Text = Registro.Monto.ToString();
                ObservacionrichTextBox.Text = Registro.Observacion;
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (SalidaIdtextBox.Text.Length == 0)
            {
                double monto;
                double.TryParse(MontotextBox.Text, out monto);
                MontotextBox.Text = monto.ToString();
                Registro.Monto = monto;
                Registro.CuentaId = Convert.ToInt32(CuentaIdtextBox.Text);
                Registro.Fecha = FechadateTimePicker.Text;
                Registro.Observacion = ObservacionrichTextBox.Text;

                if (Registro.Insertar())
                {
                    MessageBox.Show("se guardaron los datos");
                }
                else
                {
                    MessageBox.Show("no se guardaron los datos");
                }

            }
            else
            {
                Registro.SalidaId = Convert.ToInt32(SalidaIdtextBox.Text);
                Registro.CuentaId = Convert.ToInt32(CuentaIdtextBox.Text);
                Registro.Fecha = FechadateTimePicker.Text;
                Registro.Observacion = ObservacionrichTextBox.Text;

                Registro.Editar();

                if (Registro.Editar())
                {
                    MessageBox.Show("se actualizaron los datos");
                }
                else
                {
                    MessageBox.Show("no se actualizaron los datos");
                }
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            SalidaIdtextBox.Clear();
            CuentaIdtextBox.Clear();
            MontotextBox.Clear();
            ObservacionrichTextBox.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int.TryParse(SalidaIdtextBox.Text, out Salida);
            Registro.SalidaId = Salida;
            if (Registro.Eliminar())
            {
                MessageBox.Show("se eliminaron los datos correctamente");
            }
            else
            {
                MessageBox.Show("no se eliminaron los datos");
            }
        }
    }
}
