using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace FinanzasPersonales
{
    public partial class RegistroUsuarios : Form
    {
        private Usuarios usuario = new Usuarios();
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            UsuarioIdtextBox.Clear();
            NombreUsuariotextBox.Clear();
            ContrasenatextBox.Clear();
            Contrasena1textBox.Clear();
            ActivocheckBox.Checked = false;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {

            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            usuario.NombreUsuario = NombreUsuariotextBox.Text;
            if (ActivocheckBox.Checked == true)
            {
                usuario.Activo = true;
            }
            else if (ActivocheckBox.Checked == false)
            {
                usuario.Activo = false;
            }

            if (ContrasenatextBox.Text == ContrasenatextBox.Text)
            {
                usuario.Contrasenia = ContrasenatextBox.Text;

                int id;
                int.TryParse(UsuarioIdtextBox.Text, out id);

                if (id == 0)
                {
                    Limpiar();
                    MessageBox.Show("Guardado Correcto", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Contraseña no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            usuario.UsuarioId = int.Parse(UsuarioIdtextBox.Text);
            if (usuario.Eliminar())
            {
                Limpiar();
                MessageBox.Show("Eliminado Correcto", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //sftyfdrtd
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (usuario.Buscar(int.Parse(UsuarioIdtextBox.Text)))
            {

                NombreUsuariotextBox.Text = usuario.NombreUsuario;
                ContrasenatextBox.Text = usuario.Contrasenia;
            }
        }

        private void UsuarioIdtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

