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
            this.labelUsuarioId = new System.Windows.Forms.Label();
            this.dateTimePickerTransferencia = new System.Windows.Forms.DateTimePicker();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.textBoxCuentaDeOrigenId = new System.Windows.Forms.TextBox();
            this.textBoxCuentaDeDestinoId = new System.Windows.Forms.TextBox();
            this.buttonBuscarId = new System.Windows.Forms.Button();
            this.buttonBuscarCuentaOrigen = new System.Windows.Forms.Button();
            this.buttonBuscarCuentaDestino = new System.Windows.Forms.Button();
            this.labelMontoCuentaOrigen = new System.Windows.Forms.Label();
            this.labelMontoCuentaDestino = new System.Windows.Forms.Label();
            this.textBoxMontoCuentaOrigen = new System.Windows.Forms.TextBox();
            this.textBoxMontoCuentaDestino = new System.Windows.Forms.TextBox();
            this.labelDescripcionCuentaOrigen = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelDescripcionCuentaDestino = new System.Windows.Forms.Label();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.textBoxDescricionCuentaOrigen = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionCuentaDestino = new System.Windows.Forms.TextBox();
            this.panelTransferencias = new System.Windows.Forms.Panel();
            this.panelTransferencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.Location = new System.Drawing.Point(142, 195);
            this.textBoxObservacion.MaxLength = 50;
            this.textBoxObservacion.Multiline = true;
            this.textBoxObservacion.Name = "textBoxObservacion";
            this.textBoxObservacion.Size = new System.Drawing.Size(138, 39);
            this.textBoxObservacion.TabIndex = 5;
            this.textBoxObservacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxObservacion_KeyPress);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(440, 297);
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
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(122, 297);
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
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(283, 297);
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
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(25, 8);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "Id";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(25, 46);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(42, 13);
            this.labelFecha.TabIndex = 10;
            this.labelFecha.Text = "Fecha";
            // 
            // labelCuentaDeOrigen
            // 
            this.labelCuentaDeOrigen.AutoSize = true;
            this.labelCuentaDeOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuentaDeOrigen.Location = new System.Drawing.Point(314, 18);
            this.labelCuentaDeOrigen.Name = "labelCuentaDeOrigen";
            this.labelCuentaDeOrigen.Size = new System.Drawing.Size(108, 13);
            this.labelCuentaDeOrigen.TabIndex = 11;
            this.labelCuentaDeOrigen.Text = "Cuenta De Origen";
            // 
            // labelCuentaDeDestino
            // 
            this.labelCuentaDeDestino.AutoSize = true;
            this.labelCuentaDeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuentaDeDestino.Location = new System.Drawing.Point(314, 135);
            this.labelCuentaDeDestino.Name = "labelCuentaDeDestino";
            this.labelCuentaDeDestino.Size = new System.Drawing.Size(114, 13);
            this.labelCuentaDeDestino.TabIndex = 12;
            this.labelCuentaDeDestino.Text = "Cuenta De Destino";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.Location = new System.Drawing.Point(25, 160);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(107, 13);
            this.labelMonto.TabIndex = 13;
            this.labelMonto.Text = "Monto a transferir";
            // 
            // labelObservacion
            // 
            this.labelObservacion.AutoSize = true;
            this.labelObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObservacion.Location = new System.Drawing.Point(25, 198);
            this.labelObservacion.Name = "labelObservacion";
            this.labelObservacion.Size = new System.Drawing.Size(78, 13);
            this.labelObservacion.TabIndex = 14;
            this.labelObservacion.Text = "Observación";
            // 
            // labelUsuarioId
            // 
            this.labelUsuarioId.AutoSize = true;
            this.labelUsuarioId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioId.Location = new System.Drawing.Point(25, 84);
            this.labelUsuarioId.Name = "labelUsuarioId";
            this.labelUsuarioId.Size = new System.Drawing.Size(50, 13);
            this.labelUsuarioId.TabIndex = 15;
            this.labelUsuarioId.Text = "Usuario";
            // 
            // dateTimePickerTransferencia
            // 
            this.dateTimePickerTransferencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTransferencia.Location = new System.Drawing.Point(142, 48);
            this.dateTimePickerTransferencia.Name = "dateTimePickerTransferencia";
            this.dateTimePickerTransferencia.Size = new System.Drawing.Size(116, 20);
            this.dateTimePickerTransferencia.TabIndex = 2;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(142, 11);
            this.textBoxId.MaxLength = 10;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(40, 20);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(142, 85);
            this.textBoxUsuario.MaxLength = 10;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.ReadOnly = true;
            this.textBoxUsuario.Size = new System.Drawing.Size(40, 20);
            this.textBoxUsuario.TabIndex = 3;
            this.textBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsuario_KeyPress);
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(142, 159);
            this.textBoxMonto.MaxLength = 12;
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(116, 20);
            this.textBoxMonto.TabIndex = 4;
            this.textBoxMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonto_KeyPress);
            // 
            // textBoxCuentaDeOrigenId
            // 
            this.textBoxCuentaDeOrigenId.Location = new System.Drawing.Point(490, 15);
            this.textBoxCuentaDeOrigenId.MaxLength = 10;
            this.textBoxCuentaDeOrigenId.Name = "textBoxCuentaDeOrigenId";
            this.textBoxCuentaDeOrigenId.Size = new System.Drawing.Size(40, 20);
            this.textBoxCuentaDeOrigenId.TabIndex = 6;
            this.textBoxCuentaDeOrigenId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCuentaDeOrigen_KeyPress);
            // 
            // textBoxCuentaDeDestinoId
            // 
            this.textBoxCuentaDeDestinoId.Location = new System.Drawing.Point(490, 132);
            this.textBoxCuentaDeDestinoId.MaxLength = 10;
            this.textBoxCuentaDeDestinoId.Name = "textBoxCuentaDeDestinoId";
            this.textBoxCuentaDeDestinoId.Size = new System.Drawing.Size(40, 20);
            this.textBoxCuentaDeDestinoId.TabIndex = 7;
            this.textBoxCuentaDeDestinoId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCuentaDeDestino_KeyPress);
            // 
            // buttonBuscarId
            // 
            this.buttonBuscarId.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarId.Image")));
            this.buttonBuscarId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarId.Location = new System.Drawing.Point(188, 3);
            this.buttonBuscarId.Name = "buttonBuscarId";
            this.buttonBuscarId.Size = new System.Drawing.Size(92, 34);
            this.buttonBuscarId.TabIndex = 22;
            this.buttonBuscarId.Text = "Buscar";
            this.buttonBuscarId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarId.UseVisualStyleBackColor = true;
            this.buttonBuscarId.Click += new System.EventHandler(this.buttonBuscarId_Click);
            // 
            // buttonBuscarCuentaOrigen
            // 
            this.buttonBuscarCuentaOrigen.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarCuentaOrigen.Image")));
            this.buttonBuscarCuentaOrigen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarCuentaOrigen.Location = new System.Drawing.Point(536, 7);
            this.buttonBuscarCuentaOrigen.Name = "buttonBuscarCuentaOrigen";
            this.buttonBuscarCuentaOrigen.Size = new System.Drawing.Size(92, 37);
            this.buttonBuscarCuentaOrigen.TabIndex = 23;
            this.buttonBuscarCuentaOrigen.Text = "Buscar";
            this.buttonBuscarCuentaOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarCuentaOrigen.UseVisualStyleBackColor = true;
            this.buttonBuscarCuentaOrigen.Click += new System.EventHandler(this.buttonBuscarCuentaOrigen_Click);
            // 
            // buttonBuscarCuentaDestino
            // 
            this.buttonBuscarCuentaDestino.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarCuentaDestino.Image")));
            this.buttonBuscarCuentaDestino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarCuentaDestino.Location = new System.Drawing.Point(536, 124);
            this.buttonBuscarCuentaDestino.Name = "buttonBuscarCuentaDestino";
            this.buttonBuscarCuentaDestino.Size = new System.Drawing.Size(92, 34);
            this.buttonBuscarCuentaDestino.TabIndex = 25;
            this.buttonBuscarCuentaDestino.Text = "Buscar";
            this.buttonBuscarCuentaDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarCuentaDestino.UseVisualStyleBackColor = true;
            this.buttonBuscarCuentaDestino.Click += new System.EventHandler(this.buttonBuscarCuentaDestino_Click);
            // 
            // labelMontoCuentaOrigen
            // 
            this.labelMontoCuentaOrigen.AutoSize = true;
            this.labelMontoCuentaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoCuentaOrigen.Location = new System.Drawing.Point(314, 96);
            this.labelMontoCuentaOrigen.Name = "labelMontoCuentaOrigen";
            this.labelMontoCuentaOrigen.Size = new System.Drawing.Size(127, 13);
            this.labelMontoCuentaOrigen.TabIndex = 26;
            this.labelMontoCuentaOrigen.Text = "Monto Cuenta Origen";
            // 
            // labelMontoCuentaDestino
            // 
            this.labelMontoCuentaDestino.AutoSize = true;
            this.labelMontoCuentaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoCuentaDestino.Location = new System.Drawing.Point(314, 213);
            this.labelMontoCuentaDestino.Name = "labelMontoCuentaDestino";
            this.labelMontoCuentaDestino.Size = new System.Drawing.Size(133, 13);
            this.labelMontoCuentaDestino.TabIndex = 27;
            this.labelMontoCuentaDestino.Text = "Monto Cuenta Destino";
            // 
            // textBoxMontoCuentaOrigen
            // 
            this.textBoxMontoCuentaOrigen.Location = new System.Drawing.Point(490, 93);
            this.textBoxMontoCuentaOrigen.Name = "textBoxMontoCuentaOrigen";
            this.textBoxMontoCuentaOrigen.ReadOnly = true;
            this.textBoxMontoCuentaOrigen.Size = new System.Drawing.Size(116, 20);
            this.textBoxMontoCuentaOrigen.TabIndex = 28;
            // 
            // textBoxMontoCuentaDestino
            // 
            this.textBoxMontoCuentaDestino.Location = new System.Drawing.Point(490, 210);
            this.textBoxMontoCuentaDestino.Name = "textBoxMontoCuentaDestino";
            this.textBoxMontoCuentaDestino.ReadOnly = true;
            this.textBoxMontoCuentaDestino.Size = new System.Drawing.Size(116, 20);
            this.textBoxMontoCuentaDestino.TabIndex = 29;
            // 
            // labelDescripcionCuentaOrigen
            // 
            this.labelDescripcionCuentaOrigen.AutoSize = true;
            this.labelDescripcionCuentaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionCuentaOrigen.Location = new System.Drawing.Point(314, 57);
            this.labelDescripcionCuentaOrigen.Name = "labelDescripcionCuentaOrigen";
            this.labelDescripcionCuentaOrigen.Size = new System.Drawing.Size(159, 13);
            this.labelDescripcionCuentaOrigen.TabIndex = 30;
            this.labelDescripcionCuentaOrigen.Text = "Descripcion Cuenta Origen";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.Location = new System.Drawing.Point(25, 122);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(50, 13);
            this.labelNombreUsuario.TabIndex = 31;
            this.labelNombreUsuario.Text = "Nombre";
            // 
            // labelDescripcionCuentaDestino
            // 
            this.labelDescripcionCuentaDestino.AutoSize = true;
            this.labelDescripcionCuentaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionCuentaDestino.Location = new System.Drawing.Point(314, 174);
            this.labelDescripcionCuentaDestino.Name = "labelDescripcionCuentaDestino";
            this.labelDescripcionCuentaDestino.Size = new System.Drawing.Size(165, 13);
            this.labelDescripcionCuentaDestino.TabIndex = 32;
            this.labelDescripcionCuentaDestino.Text = "Descripcion Cuenta Destino";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(142, 122);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.ReadOnly = true;
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(116, 20);
            this.textBoxNombreUsuario.TabIndex = 33;
            // 
            // textBoxDescricionCuentaOrigen
            // 
            this.textBoxDescricionCuentaOrigen.Location = new System.Drawing.Point(490, 54);
            this.textBoxDescricionCuentaOrigen.Name = "textBoxDescricionCuentaOrigen";
            this.textBoxDescricionCuentaOrigen.ReadOnly = true;
            this.textBoxDescricionCuentaOrigen.Size = new System.Drawing.Size(116, 20);
            this.textBoxDescricionCuentaOrigen.TabIndex = 34;
            // 
            // textBoxDescripcionCuentaDestino
            // 
            this.textBoxDescripcionCuentaDestino.Location = new System.Drawing.Point(490, 171);
            this.textBoxDescripcionCuentaDestino.Name = "textBoxDescripcionCuentaDestino";
            this.textBoxDescripcionCuentaDestino.ReadOnly = true;
            this.textBoxDescripcionCuentaDestino.Size = new System.Drawing.Size(116, 20);
            this.textBoxDescripcionCuentaDestino.TabIndex = 35;
            // 
            // panelTransferencias
            // 
            this.panelTransferencias.BackColor = System.Drawing.Color.LightGray;
            this.panelTransferencias.Controls.Add(this.labelCuentaDeOrigen);
            this.panelTransferencias.Controls.Add(this.textBoxDescripcionCuentaDestino);
            this.panelTransferencias.Controls.Add(this.textBoxObservacion);
            this.panelTransferencias.Controls.Add(this.labelCuentaDeDestino);
            this.panelTransferencias.Controls.Add(this.textBoxDescricionCuentaOrigen);
            this.panelTransferencias.Controls.Add(this.labelId);
            this.panelTransferencias.Controls.Add(this.textBoxCuentaDeOrigenId);
            this.panelTransferencias.Controls.Add(this.textBoxNombreUsuario);
            this.panelTransferencias.Controls.Add(this.textBoxCuentaDeDestinoId);
            this.panelTransferencias.Controls.Add(this.labelFecha);
            this.panelTransferencias.Controls.Add(this.labelDescripcionCuentaDestino);
            this.panelTransferencias.Controls.Add(this.labelNombreUsuario);
            this.panelTransferencias.Controls.Add(this.buttonBuscarCuentaOrigen);
            this.panelTransferencias.Controls.Add(this.labelMonto);
            this.panelTransferencias.Controls.Add(this.buttonBuscarCuentaDestino);
            this.panelTransferencias.Controls.Add(this.buttonBuscarId);
            this.panelTransferencias.Controls.Add(this.labelDescripcionCuentaOrigen);
            this.panelTransferencias.Controls.Add(this.labelObservacion);
            this.panelTransferencias.Controls.Add(this.labelMontoCuentaOrigen);
            this.panelTransferencias.Controls.Add(this.textBoxMonto);
            this.panelTransferencias.Controls.Add(this.textBoxMontoCuentaDestino);
            this.panelTransferencias.Controls.Add(this.labelUsuarioId);
            this.panelTransferencias.Controls.Add(this.labelMontoCuentaDestino);
            this.panelTransferencias.Controls.Add(this.textBoxUsuario);
            this.panelTransferencias.Controls.Add(this.textBoxMontoCuentaOrigen);
            this.panelTransferencias.Controls.Add(this.dateTimePickerTransferencia);
            this.panelTransferencias.Controls.Add(this.textBoxId);
            this.panelTransferencias.Location = new System.Drawing.Point(12, 21);
            this.panelTransferencias.Name = "panelTransferencias";
            this.panelTransferencias.Size = new System.Drawing.Size(653, 256);
            this.panelTransferencias.TabIndex = 37;
            // 
            // TransferenciasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 350);
            this.Controls.Add(this.panelTransferencias);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Label labelUsuarioId;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransferencia;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.TextBox textBoxCuentaDeOrigenId;
        private System.Windows.Forms.TextBox textBoxCuentaDeDestinoId;
        private System.Windows.Forms.Button buttonBuscarId;
        private System.Windows.Forms.Button buttonBuscarCuentaOrigen;
        private System.Windows.Forms.Button buttonBuscarCuentaDestino;
        private System.Windows.Forms.Label labelMontoCuentaOrigen;
        private System.Windows.Forms.Label labelMontoCuentaDestino;
        private System.Windows.Forms.TextBox textBoxMontoCuentaOrigen;
        private System.Windows.Forms.TextBox textBoxMontoCuentaDestino;
        private System.Windows.Forms.Label labelDescripcionCuentaOrigen;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelDescripcionCuentaDestino;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.TextBox textBoxDescricionCuentaOrigen;
        private System.Windows.Forms.TextBox textBoxDescripcionCuentaDestino;
        private System.Windows.Forms.Panel panelTransferencias;
    }
}