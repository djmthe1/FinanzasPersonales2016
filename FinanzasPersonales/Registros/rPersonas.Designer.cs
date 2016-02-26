namespace FinanzasPersonales.Registros
{
    partial class rPersonas
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
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.TelefonosdataGridView = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgregarTelefonobutton = new System.Windows.Forms.Button();
            this.TelefonotextBox = new System.Windows.Forms.TextBox();
            this.TipoTelefonocomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PersonaIdtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PersonaErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TelefonosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::FinanzasPersonales.Properties.Resources.fail;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(306, 323);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(62, 56);
            this.EliminarButton.TabIndex = 18;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::FinanzasPersonales.Properties.Resources.Save;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(175, 323);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(62, 56);
            this.GuardarButton.TabIndex = 17;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::FinanzasPersonales.Properties.Resources.Add;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(40, 323);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(62, 56);
            this.NuevoButton.TabIndex = 16;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::FinanzasPersonales.Properties.Resources.Search;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(191, 3);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(62, 46);
            this.BuscarButton.TabIndex = 15;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // TelefonosdataGridView
            // 
            this.TelefonosdataGridView.AllowUserToAddRows = false;
            this.TelefonosdataGridView.AllowUserToOrderColumns = true;
            this.TelefonosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TelefonosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Telefono});
            this.TelefonosdataGridView.Location = new System.Drawing.Point(40, 163);
            this.TelefonosdataGridView.Name = "TelefonosdataGridView";
            this.TelefonosdataGridView.ReadOnly = true;
            this.TelefonosdataGridView.Size = new System.Drawing.Size(328, 141);
            this.TelefonosdataGridView.TabIndex = 19;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "TipoTelefono";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // AgregarTelefonobutton
            // 
            this.AgregarTelefonobutton.Location = new System.Drawing.Point(297, 134);
            this.AgregarTelefonobutton.Name = "AgregarTelefonobutton";
            this.AgregarTelefonobutton.Size = new System.Drawing.Size(71, 23);
            this.AgregarTelefonobutton.TabIndex = 20;
            this.AgregarTelefonobutton.Text = "Agregar";
            this.AgregarTelefonobutton.UseVisualStyleBackColor = true;
            this.AgregarTelefonobutton.Click += new System.EventHandler(this.AgregarTelefonobutton_Click);
            // 
            // TelefonotextBox
            // 
            this.TelefonotextBox.Location = new System.Drawing.Point(191, 136);
            this.TelefonotextBox.Name = "TelefonotextBox";
            this.TelefonotextBox.Size = new System.Drawing.Size(100, 20);
            this.TelefonotextBox.TabIndex = 21;
            this.TelefonotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonotextBox_KeyPress);
            // 
            // TipoTelefonocomboBox
            // 
            this.TipoTelefonocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoTelefonocomboBox.FormattingEnabled = true;
            this.TipoTelefonocomboBox.Location = new System.Drawing.Point(40, 136);
            this.TipoTelefonocomboBox.Name = "TipoTelefonocomboBox";
            this.TipoTelefonocomboBox.Size = new System.Drawing.Size(120, 21);
            this.TipoTelefonocomboBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Telefono";
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(112, 65);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(125, 20);
            this.NombrestextBox.TabIndex = 21;
            this.NombrestextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombrestextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombres";
            // 
            // PersonaIdtextBox
            // 
            this.PersonaIdtextBox.Location = new System.Drawing.Point(112, 13);
            this.PersonaIdtextBox.Name = "PersonaIdtextBox";
            this.PersonaIdtextBox.Size = new System.Drawing.Size(65, 20);
            this.PersonaIdtextBox.TabIndex = 21;
            this.PersonaIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonaIdtextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Id";
            // 
            // PersonaErrorProvider
            // 
            this.PersonaErrorProvider.ContainerControl = this;
            // 
            // rPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipoTelefonocomboBox);
            this.Controls.Add(this.PersonaIdtextBox);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.TelefonotextBox);
            this.Controls.Add(this.AgregarTelefonobutton);
            this.Controls.Add(this.TelefonosdataGridView);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Name = "rPersonas";
            this.Text = "rPersonas";
            this.Load += new System.EventHandler(this.rPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TelefonosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView TelefonosdataGridView;
        private System.Windows.Forms.Button AgregarTelefonobutton;
        private System.Windows.Forms.TextBox TelefonotextBox;
        private System.Windows.Forms.ComboBox TipoTelefonocomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PersonaIdtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.ErrorProvider PersonaErrorProvider;
    }
}