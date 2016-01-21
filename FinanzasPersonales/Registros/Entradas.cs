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
    public partial class Entradas : Form
    {
        public Entradas()
        {
            InitializeComponent();
        }
        BLL.Entradas entrada = new BLL.Entradas();

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text.Trim() == "")
            {
                EntradaerrorProvider.SetError(IdtextBox, "Debe especificar el ID ");
                IdtextBox.Focus();
            }
            else
            {
                EntradaerrorProvider.Clear();
            }


            if (IdtextBox.TextLength > 0)
            {
                int id;
                int.TryParse(IdtextBox.Text, out id);
                entrada.Buscar(id);
                NombretextBox.Text = entrada.Nombres;
                ApellidotextBox.Text = entrada.Apellidos;
                DirecciontextBox.Text = entrada.Direccion;
                TelefonomaskedTextBox.Text = entrada.Telefono;
                MovilmaskedTextBox.Text = entrada.Movil;
                MontomaskedTextBox.Text = Convert.ToString(entrada.Monto);
                FechadateTimePicker.Text = entrada.Fecha;
            }
        }

        private void limpiar()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
            ApellidotextBox.Clear();
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();
            MovilmaskedTextBox.Clear();
            MontomaskedTextBox.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (NombretextBox.Text.Length == 0 && ApellidotextBox.Text.Length == 0 && DirecciontextBox.Text.Length == 0 && TelefonomaskedTextBox.Text.Length == 0 && MovilmaskedTextBox.Text.Length == 0 && MontomaskedTextBox.Text.Length == 0)
            {
                MessageBox.Show("El campo debe estar lleno ");
            }
            else
                
                if (IdtextBox.Text.Length == 0)
                {
                    entrada.Nombres = NombretextBox.Text;
                    entrada.Apellidos = ApellidotextBox.Text;
                    entrada.Direccion = DirecciontextBox.Text;
                    entrada.Telefono = TelefonomaskedTextBox.Text;
                    entrada.Movil = MovilmaskedTextBox.Text;
                    float id;
                    float.TryParse(MontomaskedTextBox.Text, out id);
                    entrada.Monto = id;
                    entrada.Fecha = FechadateTimePicker.Value.ToString();
                    if (entrada.Insertar())
                    {
                        MessageBox.Show("La entrada se Guardo Correctamente");
                    }else
                    {
                        MessageBox.Show("La entrada no ha sido Guardada Correctamente");
                    }
                }else 
                if (IdtextBox.TextLength != 0)
                {
                    entrada.EntradaId = Convert.ToInt32(IdtextBox.Text);
                    if (entrada.Editar())
                    {
                        MessageBox.Show("La entrada se editada Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("La entrada no ha sido editada Correctamente");
                    }
                }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.TextLength > 0)
            {
                entrada.EntradaId = int.Parse(IdtextBox.Text);
                if (entrada.Eliminar())
                {
                    MessageBox.Show("La entrada se elimino Correctamente");
                }
                else
                {
                    MessageBox.Show("La entrada no ha sido eliminada Correctamente");
                }
            }
        }

        private void IdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ApellidotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void DireccionxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)))
                e.Handled = false;
            else
                e.Handled = true;
        }
        
    }
}
