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
            this.label8 = new System.Windows.Forms.Label();
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
            this.CuentaIdcomboBox = new System.Windows.Forms.ComboBox();
            this.CategoriaIdcomboBox = new System.Windows.Forms.ComboBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(306, 85);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.FechadateTimePicker.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Monto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categoria ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cuenta ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Entradas";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(85, 85);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(111, 20);
            this.IdtextBox.TabIndex = 0;
            this.IdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdtextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::FinanzasPersonales.Properties.Resources.fail;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(295, 373);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(57, 51);
            this.Eliminarbutton.TabIndex = 8;
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
            this.MontomaskedTextBox.Location = new System.Drawing.Point(84, 203);
            this.MontomaskedTextBox.Mask = "999999.99";
            this.MontomaskedTextBox.Name = "MontomaskedTextBox";
            this.MontomaskedTextBox.PromptChar = ' ';
            this.MontomaskedTextBox.Size = new System.Drawing.Size(112, 20);
            this.MontomaskedTextBox.TabIndex = 4;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::FinanzasPersonales.Properties.Resources.Search;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(206, 68);
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
            this.Guardarbutton.Location = new System.Drawing.Point(190, 373);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(55, 51);
            this.Guardarbutton.TabIndex = 7;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::FinanzasPersonales.Properties.Resources.Add;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(84, 373);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(56, 51);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // CuentaIdcomboBox
            // 
            this.CuentaIdcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CuentaIdcomboBox.FormattingEnabled = true;
            this.CuentaIdcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CuentaIdcomboBox.Location = new System.Drawing.Point(84, 148);
            this.CuentaIdcomboBox.Name = "CuentaIdcomboBox";
            this.CuentaIdcomboBox.Size = new System.Drawing.Size(112, 21);
            this.CuentaIdcomboBox.TabIndex = 2;
            // 
            // CategoriaIdcomboBox
            // 
            this.CategoriaIdcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriaIdcomboBox.FormattingEnabled = true;
            this.CategoriaIdcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3\t\t\t"});
            this.CategoriaIdcomboBox.Location = new System.Drawing.Point(316, 148);
            this.CategoriaIdcomboBox.Name = "CategoriaIdcomboBox";
            this.CategoriaIdcomboBox.Size = new System.Drawing.Size(110, 21);
            this.CategoriaIdcomboBox.TabIndex = 3;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(22, 268);
            this.DescripciontextBox.Multiline = true;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(404, 79);
            this.DescripciontextBox.TabIndex = 5;
            this.DescripciontextBox.TextChanged += new System.EventHandler(this.DescripciontextBox_TextChanged);
            this.DescripciontextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripciontextBox_KeyPress);
            // 
            // EntradasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.CuentaIdcomboBox);
            this.Controls.Add(this.CategoriaIdcomboBox);
            this.Controls.Add(this.MontomaskedTextBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdtextBox);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider EntradaerrorProvider;
        private System.Windows.Forms.MaskedTextBox MontomaskedTextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.ComboBox CuentaIdcomboBox;
        private System.Windows.Forms.ComboBox CategoriaIdcomboBox;
    }
}