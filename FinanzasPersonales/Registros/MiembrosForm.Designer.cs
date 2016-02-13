namespace FinanzasPersonales.Registros
{
    partial class MiembrosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MiembroIdlabel = new System.Windows.Forms.Label();
            this.UsuarioIdlabel = new System.Windows.Forms.Label();
            this.Nombreslabel = new System.Windows.Forms.Label();
            this.Apellidoslabel = new System.Windows.Forms.Label();
            this.Parentescolabel = new System.Windows.Forms.Label();
            this.MiembroIdtextBox = new System.Windows.Forms.TextBox();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.ApellidostextBox = new System.Windows.Forms.TextBox();
            this.UsuarioIdcomboBox = new System.Windows.Forms.ComboBox();
            this.ParentrichTextBox = new System.Windows.Forms.RichTextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MiembroIdlabel
            // 
            this.MiembroIdlabel.AutoSize = true;
            this.MiembroIdlabel.Location = new System.Drawing.Point(41, 45);
            this.MiembroIdlabel.Name = "MiembroIdlabel";
            this.MiembroIdlabel.Size = new System.Drawing.Size(59, 13);
            this.MiembroIdlabel.TabIndex = 0;
            this.MiembroIdlabel.Text = "Miembro Id";
            // 
            // UsuarioIdlabel
            // 
            this.UsuarioIdlabel.AutoSize = true;
            this.UsuarioIdlabel.Location = new System.Drawing.Point(41, 101);
            this.UsuarioIdlabel.Name = "UsuarioIdlabel";
            this.UsuarioIdlabel.Size = new System.Drawing.Size(55, 13);
            this.UsuarioIdlabel.TabIndex = 1;
            this.UsuarioIdlabel.Text = "Usuario Id";
            // 
            // Nombreslabel
            // 
            this.Nombreslabel.AutoSize = true;
            this.Nombreslabel.Location = new System.Drawing.Point(41, 141);
            this.Nombreslabel.Name = "Nombreslabel";
            this.Nombreslabel.Size = new System.Drawing.Size(49, 13);
            this.Nombreslabel.TabIndex = 2;
            this.Nombreslabel.Text = "Nombres";
            // 
            // Apellidoslabel
            // 
            this.Apellidoslabel.AutoSize = true;
            this.Apellidoslabel.Location = new System.Drawing.Point(41, 202);
            this.Apellidoslabel.Name = "Apellidoslabel";
            this.Apellidoslabel.Size = new System.Drawing.Size(49, 13);
            this.Apellidoslabel.TabIndex = 3;
            this.Apellidoslabel.Text = "Apellidos";
            // 
            // Parentescolabel
            // 
            this.Parentescolabel.AutoSize = true;
            this.Parentescolabel.Location = new System.Drawing.Point(41, 248);
            this.Parentescolabel.Name = "Parentescolabel";
            this.Parentescolabel.Size = new System.Drawing.Size(61, 13);
            this.Parentescolabel.TabIndex = 4;
            this.Parentescolabel.Text = "Parentesco";
            // 
            // MiembroIdtextBox
            // 
            this.MiembroIdtextBox.Location = new System.Drawing.Point(106, 45);
            this.MiembroIdtextBox.Name = "MiembroIdtextBox";
            this.MiembroIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.MiembroIdtextBox.TabIndex = 5;
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(106, 141);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(169, 20);
            this.NombrestextBox.TabIndex = 6;
            this.NombrestextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ApellidostextBox
            // 
            this.ApellidostextBox.Location = new System.Drawing.Point(106, 202);
            this.ApellidostextBox.Name = "ApellidostextBox";
            this.ApellidostextBox.Size = new System.Drawing.Size(169, 20);
            this.ApellidostextBox.TabIndex = 7;
            // 
            // UsuarioIdcomboBox
            // 
            this.UsuarioIdcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsuarioIdcomboBox.FormattingEnabled = true;
            this.UsuarioIdcomboBox.Items.AddRange(new object[] {
            "Esperando",
            "que",
            "suban",
            "la",
            "tabla",
            "Usuarios"});
            this.UsuarioIdcomboBox.Location = new System.Drawing.Point(106, 101);
            this.UsuarioIdcomboBox.Name = "UsuarioIdcomboBox";
            this.UsuarioIdcomboBox.Size = new System.Drawing.Size(100, 21);
            this.UsuarioIdcomboBox.TabIndex = 9;
            // 
            // ParentrichTextBox
            // 
            this.ParentrichTextBox.Location = new System.Drawing.Point(106, 248);
            this.ParentrichTextBox.Name = "ParentrichTextBox";
            this.ParentrichTextBox.Size = new System.Drawing.Size(169, 58);
            this.ParentrichTextBox.TabIndex = 16;
            this.ParentrichTextBox.Text = "";
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::FinanzasPersonales.Properties.Resources.fail;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(213, 331);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(62, 56);
            this.Eliminarbutton.TabIndex = 14;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::FinanzasPersonales.Properties.Resources.Save;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(129, 331);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(62, 56);
            this.Guardarbutton.TabIndex = 13;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::FinanzasPersonales.Properties.Resources.Add;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(44, 331);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(62, 56);
            this.Nuevobutton.TabIndex = 12;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::FinanzasPersonales.Properties.Resources.Search;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(213, 45);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(62, 46);
            this.Buscarbutton.TabIndex = 11;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // MiembrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 403);
            this.Controls.Add(this.ParentrichTextBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.UsuarioIdcomboBox);
            this.Controls.Add(this.ApellidostextBox);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.MiembroIdtextBox);
            this.Controls.Add(this.Parentescolabel);
            this.Controls.Add(this.Apellidoslabel);
            this.Controls.Add(this.Nombreslabel);
            this.Controls.Add(this.UsuarioIdlabel);
            this.Controls.Add(this.MiembroIdlabel);
            this.Name = "MiembrosForm";
            this.Text = "Miembros Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MiembroIdlabel;
        private System.Windows.Forms.Label UsuarioIdlabel;
        private System.Windows.Forms.Label Nombreslabel;
        private System.Windows.Forms.Label Apellidoslabel;
        private System.Windows.Forms.Label Parentescolabel;
        private System.Windows.Forms.TextBox MiembroIdtextBox;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.TextBox ApellidostextBox;
        private System.Windows.Forms.ComboBox UsuarioIdcomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.RichTextBox ParentrichTextBox;
    }
}