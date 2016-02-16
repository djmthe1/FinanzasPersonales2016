namespace FinanzasPersonales.Registros
{
    partial class TransferenciasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferenciasForm));
            this.textBoxObservacion = new System.Windows.Forms.TextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelCuentaDeOrigen = new System.Windows.Forms.Label();
            this.labelCuentaDeDestino = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.labelObservacion = new System.Windows.Forms.Label();
            this.dateTimePickerTransferencia = new System.Windows.Forms.DateTimePicker();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.buttonBuscarId = new System.Windows.Forms.Button();
            this.labelMontoCuentaOrigen = new System.Windows.Forms.Label();
            this.labelMontoCuentaDestino = new System.Windows.Forms.Label();
            this.textBoxMontoCuentaOrigen = new System.Windows.Forms.TextBox();
            this.textBoxMontoCuentaDestino = new System.Windows.Forms.TextBox();
            this.labelDescripcionCuentaOrigen = new System.Windows.Forms.Label();
            this.labelDescripcionCuentaDestino = new System.Windows.Forms.Label();
            this.textBoxDescricionCuentaOrigen = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionCuentaDestino = new System.Windows.Forms.TextBox();
            this.panelTransferencias = new System.Windows.Forms.Panel();
            this.comboBoxCuentaDestino = new System.Windows.Forms.ComboBox();
            this.comboBoxCuentaOrigen = new System.Windows.Forms.ComboBox();
            this.panelTransferencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxObservacion.Location = new System.Drawing.Point(541, 184);
            this.textBoxObservacion.MaxLength = 50;
            this.textBoxObservacion.Multiline = true;
            this.textBoxObservacion.Name = "textBoxObservacion";
            this.textBoxObservacion.Size = new System.Drawing.Size(116, 39);
            this.textBoxObservacion.TabIndex = 5;
            this.textBoxObservacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxObservacion_KeyPress);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(471, 273);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(111, 41);
            this.EliminarButton.TabIndex = 10;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NuevoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(153, 273);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(111, 41);
            this.NuevoButton.TabIndex = 8;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(312, 273);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(111, 41);
            this.GuardarButton.TabIndex = 9;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(153, 15);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "Id";
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(488, 15);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(42, 13);
            this.labelFecha.TabIndex = 10;
            this.labelFecha.Text = "Fecha";
            // 
            // labelCuentaDeOrigen
            // 
            this.labelCuentaDeOrigen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCuentaDeOrigen.AutoSize = true;
            this.labelCuentaDeOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuentaDeOrigen.Location = new System.Drawing.Point(63, 59);
            this.labelCuentaDeOrigen.Name = "labelCuentaDeOrigen";
            this.labelCuentaDeOrigen.Size = new System.Drawing.Size(108, 13);
            this.labelCuentaDeOrigen.TabIndex = 11;
            this.labelCuentaDeOrigen.Text = "Cuenta De Origen";
            // 
            // labelCuentaDeDestino
            // 
            this.labelCuentaDeDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCuentaDeDestino.AutoSize = true;
            this.labelCuentaDeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuentaDeDestino.Location = new System.Drawing.Point(416, 57);
            this.labelCuentaDeDestino.Name = "labelCuentaDeDestino";
            this.labelCuentaDeDestino.Size = new System.Drawing.Size(114, 13);
            this.labelCuentaDeDestino.TabIndex = 12;
            this.labelCuentaDeDestino.Text = "Cuenta De Destino";
            // 
            // labelMonto
            // 
            this.labelMonto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.Location = new System.Drawing.Point(63, 191);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(107, 13);
            this.labelMonto.TabIndex = 13;
            this.labelMonto.Text = "Monto a transferir";
            // 
            // labelObservacion
            // 
            this.labelObservacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelObservacion.AutoSize = true;
            this.labelObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservacion.Location = new System.Drawing.Point(452, 183);
            this.labelObservacion.Name = "labelObservacion";
            this.labelObservacion.Size = new System.Drawing.Size(78, 13);
            this.labelObservacion.TabIndex = 14;
            this.labelObservacion.Text = "Observación";
            // 
            // dateTimePickerTransferencia
            // 
            this.dateTimePickerTransferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTransferencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerTransferencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTransferencia.Location = new System.Drawing.Point(541, 15);
            this.dateTimePickerTransferencia.Name = "dateTimePickerTransferencia";
            this.dateTimePickerTransferencia.Size = new System.Drawing.Size(116, 20);
            this.dateTimePickerTransferencia.TabIndex = 2;
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxId.Location = new System.Drawing.Point(188, 18);
            this.textBoxId.MaxLength = 10;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(40, 20);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMonto.Location = new System.Drawing.Point(188, 183);
            this.textBoxMonto.MaxLength = 12;
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(116, 20);
            this.textBoxMonto.TabIndex = 4;
            this.textBoxMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonto_KeyPress);
            // 
            // buttonBuscarId
            // 
            this.buttonBuscarId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBuscarId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarId.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarId.Image")));
            this.buttonBuscarId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarId.Location = new System.Drawing.Point(234, 13);
            this.buttonBuscarId.Name = "buttonBuscarId";
            this.buttonBuscarId.Size = new System.Drawing.Size(92, 34);
            this.buttonBuscarId.TabIndex = 22;
            this.buttonBuscarId.Text = "Buscar";
            this.buttonBuscarId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarId.UseVisualStyleBackColor = true;
            this.buttonBuscarId.Click += new System.EventHandler(this.buttonBuscarId_Click);
            // 
            // labelMontoCuentaOrigen
            // 
            this.labelMontoCuentaOrigen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMontoCuentaOrigen.AutoSize = true;
            this.labelMontoCuentaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoCuentaOrigen.Location = new System.Drawing.Point(44, 147);
            this.labelMontoCuentaOrigen.Name = "labelMontoCuentaOrigen";
            this.labelMontoCuentaOrigen.Size = new System.Drawing.Size(127, 13);
            this.labelMontoCuentaOrigen.TabIndex = 26;
            this.labelMontoCuentaOrigen.Text = "Monto Cuenta Origen";
            // 
            // labelMontoCuentaDestino
            // 
            this.labelMontoCuentaDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMontoCuentaDestino.AutoSize = true;
            this.labelMontoCuentaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoCuentaDestino.Location = new System.Drawing.Point(397, 141);
            this.labelMontoCuentaDestino.Name = "labelMontoCuentaDestino";
            this.labelMontoCuentaDestino.Size = new System.Drawing.Size(133, 13);
            this.labelMontoCuentaDestino.TabIndex = 27;
            this.labelMontoCuentaDestino.Text = "Monto Cuenta Destino";
            // 
            // textBoxMontoCuentaOrigen
            // 
            this.textBoxMontoCuentaOrigen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMontoCuentaOrigen.Location = new System.Drawing.Point(188, 142);
            this.textBoxMontoCuentaOrigen.Name = "textBoxMontoCuentaOrigen";
            this.textBoxMontoCuentaOrigen.ReadOnly = true;
            this.textBoxMontoCuentaOrigen.Size = new System.Drawing.Size(116, 20);
            this.textBoxMontoCuentaOrigen.TabIndex = 28;
            // 
            // textBoxMontoCuentaDestino
            // 
            this.textBoxMontoCuentaDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMontoCuentaDestino.Location = new System.Drawing.Point(541, 142);
            this.textBoxMontoCuentaDestino.Name = "textBoxMontoCuentaDestino";
            this.textBoxMontoCuentaDestino.ReadOnly = true;
            this.textBoxMontoCuentaDestino.Size = new System.Drawing.Size(116, 20);
            this.textBoxMontoCuentaDestino.TabIndex = 29;
            // 
            // labelDescripcionCuentaOrigen
            // 
            this.labelDescripcionCuentaOrigen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDescripcionCuentaOrigen.AutoSize = true;
            this.labelDescripcionCuentaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionCuentaOrigen.Location = new System.Drawing.Point(12, 103);
            this.labelDescripcionCuentaOrigen.Name = "labelDescripcionCuentaOrigen";
            this.labelDescripcionCuentaOrigen.Size = new System.Drawing.Size(159, 13);
            this.labelDescripcionCuentaOrigen.TabIndex = 30;
            this.labelDescripcionCuentaOrigen.Text = "Descripcion Cuenta Origen";
            // 
            // labelDescripcionCuentaDestino
            // 
            this.labelDescripcionCuentaDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDescripcionCuentaDestino.AutoSize = true;
            this.labelDescripcionCuentaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionCuentaDestino.Location = new System.Drawing.Point(365, 99);
            this.labelDescripcionCuentaDestino.Name = "labelDescripcionCuentaDestino";
            this.labelDescripcionCuentaDestino.Size = new System.Drawing.Size(165, 13);
            this.labelDescripcionCuentaDestino.TabIndex = 32;
            this.labelDescripcionCuentaDestino.Text = "Descripcion Cuenta Destino";
            // 
            // textBoxDescricionCuentaOrigen
            // 
            this.textBoxDescricionCuentaOrigen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDescricionCuentaOrigen.Location = new System.Drawing.Point(188, 101);
            this.textBoxDescricionCuentaOrigen.Name = "textBoxDescricionCuentaOrigen";
            this.textBoxDescricionCuentaOrigen.ReadOnly = true;
            this.textBoxDescricionCuentaOrigen.Size = new System.Drawing.Size(116, 20);
            this.textBoxDescricionCuentaOrigen.TabIndex = 34;
            // 
            // textBoxDescripcionCuentaDestino
            // 
            this.textBoxDescripcionCuentaDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDescripcionCuentaDestino.Location = new System.Drawing.Point(541, 100);
            this.textBoxDescripcionCuentaDestino.Name = "textBoxDescripcionCuentaDestino";
            this.textBoxDescripcionCuentaDestino.ReadOnly = true;
            this.textBoxDescripcionCuentaDestino.Size = new System.Drawing.Size(116, 20);
            this.textBoxDescripcionCuentaDestino.TabIndex = 35;
            // 
            // panelTransferencias
            // 
            this.panelTransferencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTransferencias.BackColor = System.Drawing.Color.LightGray;
            this.panelTransferencias.Controls.Add(this.comboBoxCuentaDestino);
            this.panelTransferencias.Controls.Add(this.comboBoxCuentaOrigen);
            this.panelTransferencias.Controls.Add(this.labelCuentaDeOrigen);
            this.panelTransferencias.Controls.Add(this.textBoxDescripcionCuentaDestino);
            this.panelTransferencias.Controls.Add(this.textBoxObservacion);
            this.panelTransferencias.Controls.Add(this.labelCuentaDeDestino);
            this.panelTransferencias.Controls.Add(this.textBoxDescricionCuentaOrigen);
            this.panelTransferencias.Controls.Add(this.labelId);
            this.panelTransferencias.Controls.Add(this.labelFecha);
            this.panelTransferencias.Controls.Add(this.labelDescripcionCuentaDestino);
            this.panelTransferencias.Controls.Add(this.labelMonto);
            this.panelTransferencias.Controls.Add(this.buttonBuscarId);
            this.panelTransferencias.Controls.Add(this.labelDescripcionCuentaOrigen);
            this.panelTransferencias.Controls.Add(this.labelObservacion);
            this.panelTransferencias.Controls.Add(this.labelMontoCuentaOrigen);
            this.panelTransferencias.Controls.Add(this.textBoxMonto);
            this.panelTransferencias.Controls.Add(this.textBoxMontoCuentaDestino);
            this.panelTransferencias.Controls.Add(this.labelMontoCuentaDestino);
            this.panelTransferencias.Controls.Add(this.textBoxMontoCuentaOrigen);
            this.panelTransferencias.Controls.Add(this.dateTimePickerTransferencia);
            this.panelTransferencias.Controls.Add(this.textBoxId);
            this.panelTransferencias.Location = new System.Drawing.Point(12, 26);
            this.panelTransferencias.Name = "panelTransferencias";
            this.panelTransferencias.Size = new System.Drawing.Size(727, 236);
            this.panelTransferencias.TabIndex = 37;
            // 
            // comboBoxCuentaDestino
            // 
            this.comboBoxCuentaDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCuentaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCuentaDestino.FormattingEnabled = true;
            this.comboBoxCuentaDestino.Location = new System.Drawing.Point(541, 57);
            this.comboBoxCuentaDestino.Name = "comboBoxCuentaDestino";
            this.comboBoxCuentaDestino.Size = new System.Drawing.Size(116, 21);
            this.comboBoxCuentaDestino.TabIndex = 37;
            this.comboBoxCuentaDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxCuentaDestino_SelectedIndexChanged);
            // 
            // comboBoxCuentaOrigen
            // 
            this.comboBoxCuentaOrigen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCuentaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCuentaOrigen.FormattingEnabled = true;
            this.comboBoxCuentaOrigen.Location = new System.Drawing.Point(188, 59);
            this.comboBoxCuentaOrigen.Name = "comboBoxCuentaOrigen";
            this.comboBoxCuentaOrigen.Size = new System.Drawing.Size(116, 21);
            this.comboBoxCuentaOrigen.TabIndex = 36;
            this.comboBoxCuentaOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxCuentaOrigen_SelectedIndexChanged);
            this.comboBoxCuentaOrigen.SelectedValueChanged += new System.EventHandler(this.comboBoxCuentaOrigen_SelectedValueChanged);
            // 
            // TransferenciasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 326);
            this.Controls.Add(this.panelTransferencias);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TransferenciasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencias";
            this.Load += new System.EventHandler(this.TransferenciasForm_Load);
            this.panelTransferencias.ResumeLayout(false);
            this.panelTransferencias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxObservacion;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelCuentaDeOrigen;
        private System.Windows.Forms.Label labelCuentaDeDestino;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Label labelObservacion;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransferencia;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Button buttonBuscarId;
        private System.Windows.Forms.Label labelMontoCuentaOrigen;
        private System.Windows.Forms.Label labelMontoCuentaDestino;
        private System.Windows.Forms.TextBox textBoxMontoCuentaOrigen;
        private System.Windows.Forms.TextBox textBoxMontoCuentaDestino;
        private System.Windows.Forms.Label labelDescripcionCuentaOrigen;
        private System.Windows.Forms.Label labelDescripcionCuentaDestino;
        private System.Windows.Forms.TextBox textBoxDescricionCuentaOrigen;
        private System.Windows.Forms.TextBox textBoxDescripcionCuentaDestino;
        private System.Windows.Forms.Panel panelTransferencias;
        private System.Windows.Forms.ComboBox comboBoxCuentaOrigen;
        private System.Windows.Forms.ComboBox comboBoxCuentaDestino;
    }
}