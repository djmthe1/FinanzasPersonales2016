namespace FinanzasPersonales.Registros
{
    partial class EntradasForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradasForm));
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MovilmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.ApellidotextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.EntradaerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MontomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(562, 81);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.FechadateTimePicker.TabIndex = 11;
            // 
            // MovilmaskedTextBox
            // 
            this.MovilmaskedTextBox.Location = new System.Drawing.Point(85, 248);
            this.MovilmaskedTextBox.Mask = "(999) 000-0000";
            this.MovilmaskedTextBox.Name = "MovilmaskedTextBox";
            this.MovilmaskedTextBox.Size = new System.Drawing.Size(107, 20);
            this.MovilmaskedTextBox.TabIndex = 6;
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(445, 202);
            this.TelefonomaskedTextBox.Mask = "(999) 000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(107, 20);
            this.TelefonomaskedTextBox.TabIndex = 5;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(85, 202);
            this.DirecciontextBox.MaxLength = 100;
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(240, 20);
            this.DirecciontextBox.TabIndex = 4;
            this.DirecciontextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DireccionxtBox_KeyPress);
            // 
            // ApellidotextBox
            // 
            this.ApellidotextBox.Location = new System.Drawing.Point(442, 149);
            this.ApellidotextBox.MaxLength = 30;
            this.ApellidotextBox.Name = "ApellidotextBox";
            this.ApellidotextBox.Size = new System.Drawing.Size(240, 20);
            this.ApellidotextBox.TabIndex = 3;
            this.ApellidotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidotextBox_KeyPress);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(85, 149);
            this.NombretextBox.MaxLength = 30;
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(272, 20);
            this.NombretextBox.TabIndex = 2;
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Monto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Movil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Entradas";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(85, 85);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(89, 20);
            this.IdtextBox.TabIndex = 0;
            this.IdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdtextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::FinanzasPersonales.Properties.Resources.fail;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(433, 343);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(57, 51);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // EntradaerrorProvider
            // 
            this.EntradaerrorProvider.ContainerControl = this;
            // 
            // MontomaskedTextBox
            // 
            this.MontomaskedTextBox.Location = new System.Drawing.Point(442, 248);
            this.MontomaskedTextBox.Mask = "999999.99";
            this.MontomaskedTextBox.Name = "MontomaskedTextBox";
            this.MontomaskedTextBox.PromptChar = ' ';
            this.MontomaskedTextBox.Size = new System.Drawing.Size(110, 20);
            this.MontomaskedTextBox.TabIndex = 7;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::FinanzasPersonales.Properties.Resources.Search;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(190, 74);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(39, 40);
            this.Buscarbutton.TabIndex = 1;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::FinanzasPersonales.Properties.Resources.Save;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(328, 343);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(55, 51);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::FinanzasPersonales.Properties.Resources.Add;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(222, 343);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(56, 51);
            this.Nuevobutton.TabIndex = 8;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // EntradasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(703, 420);
            this.Controls.Add(this.MontomaskedTextBox);
            this.Controls.Add(this.MovilmaskedTextBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.ApellidotextBox);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntradasForm";
            this.Text = "EntradasForm";
            ((System.ComponentModel.ISupportInitialize)(this.EntradaerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.MaskedTextBox MovilmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.TextBox ApellidotextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider EntradaerrorProvider;
        private System.Windows.Forms.MaskedTextBox MontomaskedTextBox;
    }
}