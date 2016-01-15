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
            this.dateTimePickerTranferencia = new System.Windows.Forms.DateTimePicker();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.textBoxCuentaDeOrigen = new System.Windows.Forms.TextBox();
            this.textBoxCuentaDeDestino = new System.Windows.Forms.TextBox();
            this.buttonBuscarId = new System.Windows.Forms.Button();
            this.buttonBuscarCuentaOrigen = new System.Windows.Forms.Button();
            this.buttonBuscarIdUsuario = new System.Windows.Forms.Button();
            this.buttonBuscarCuentaDestino = new System.Windows.Forms.Button();
            this.labelMontoCuentaOrigen = new System.Windows.Forms.Label();
            this.labelMontoCuentaDestino = new System.Windows.Forms.Label();
            this.textBoxMontoCuentaOrigen = new System.Windows.Forms.TextBox();
            this.textBoxMontoCuentaDestino = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.Location = new System.Drawing.Point(439, 189);
            this.textBoxObservacion.Multiline = true;
            this.textBoxObservacion.Name = "textBoxObservacion";
            this.textBoxObservacion.Size = new System.Drawing.Size(152, 47);
            this.textBoxObservacion.TabIndex = 0;
            this.textBoxObservacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxObservacion_KeyPress);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(390, 264);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(95, 41);
            this.EliminarButton.TabIndex = 8;
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
            this.NuevoButton.Location = new System.Drawing.Point(117, 264);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(95, 41);
            this.NuevoButton.TabIndex = 6;
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
            this.GuardarButton.Location = new System.Drawing.Point(255, 264);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(95, 41);
            this.GuardarButton.TabIndex = 7;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 29);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "Id";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(13, 70);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 10;
            this.labelFecha.Text = "Fecha";
            // 
            // labelCuentaDeOrigen
            // 
            this.labelCuentaDeOrigen.AutoSize = true;
            this.labelCuentaDeOrigen.Location = new System.Drawing.Point(315, 29);
            this.labelCuentaDeOrigen.Name = "labelCuentaDeOrigen";
            this.labelCuentaDeOrigen.Size = new System.Drawing.Size(92, 13);
            this.labelCuentaDeOrigen.TabIndex = 11;
            this.labelCuentaDeOrigen.Text = "Cuenta De Origen";
            // 
            // labelCuentaDeDestino
            // 
            this.labelCuentaDeDestino.AutoSize = true;
            this.labelCuentaDeDestino.Location = new System.Drawing.Point(315, 109);
            this.labelCuentaDeDestino.Name = "labelCuentaDeDestino";
            this.labelCuentaDeDestino.Size = new System.Drawing.Size(97, 13);
            this.labelCuentaDeDestino.TabIndex = 12;
            this.labelCuentaDeDestino.Text = "Cuenta De Destino";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(13, 152);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(84, 13);
            this.labelMonto.TabIndex = 13;
            this.labelMonto.Text = "Monto a tranferir";
            // 
            // labelObservacion
            // 
            this.labelObservacion.AutoSize = true;
            this.labelObservacion.Location = new System.Drawing.Point(315, 189);
            this.labelObservacion.Name = "labelObservacion";
            this.labelObservacion.Size = new System.Drawing.Size(67, 13);
            this.labelObservacion.TabIndex = 14;
            this.labelObservacion.Text = "Observación";
            // 
            // labelUsuarioId
            // 
            this.labelUsuarioId.AutoSize = true;
            this.labelUsuarioId.Location = new System.Drawing.Point(13, 111);
            this.labelUsuarioId.Name = "labelUsuarioId";
            this.labelUsuarioId.Size = new System.Drawing.Size(43, 13);
            this.labelUsuarioId.TabIndex = 15;
            this.labelUsuarioId.Text = "Usuario";
            // 
            // dateTimePickerTranferencia
            // 
            this.dateTimePickerTranferencia.Location = new System.Drawing.Point(102, 71);
            this.dateTimePickerTranferencia.Name = "dateTimePickerTranferencia";
            this.dateTimePickerTranferencia.Size = new System.Drawing.Size(195, 20);
            this.dateTimePickerTranferencia.TabIndex = 16;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(102, 29);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(35, 20);
            this.textBoxId.TabIndex = 17;
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(102, 113);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(35, 20);
            this.textBoxUsuario.TabIndex = 18;
            this.textBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsuario_KeyPress);
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(102, 155);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonto.TabIndex = 19;
            this.textBoxMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonto_KeyPress);
            // 
            // textBoxCuentaDeOrigen
            // 
            this.textBoxCuentaDeOrigen.Location = new System.Drawing.Point(439, 29);
            this.textBoxCuentaDeOrigen.Name = "textBoxCuentaDeOrigen";
            this.textBoxCuentaDeOrigen.Size = new System.Drawing.Size(35, 20);
            this.textBoxCuentaDeOrigen.TabIndex = 20;
            this.textBoxCuentaDeOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCuentaDeOrigen_KeyPress);
            // 
            // textBoxCuentaDeDestino
            // 
            this.textBoxCuentaDeDestino.Location = new System.Drawing.Point(439, 109);
            this.textBoxCuentaDeDestino.Name = "textBoxCuentaDeDestino";
            this.textBoxCuentaDeDestino.Size = new System.Drawing.Size(35, 20);
            this.textBoxCuentaDeDestino.TabIndex = 21;
            this.textBoxCuentaDeDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCuentaDeDestino_KeyPress);
            // 
            // buttonBuscarId
            // 
            this.buttonBuscarId.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarId.Image")));
            this.buttonBuscarId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarId.Location = new System.Drawing.Point(143, 21);
            this.buttonBuscarId.Name = "buttonBuscarId";
            this.buttonBuscarId.Size = new System.Drawing.Size(79, 34);
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
            this.buttonBuscarCuentaOrigen.Location = new System.Drawing.Point(480, 12);
            this.buttonBuscarCuentaOrigen.Name = "buttonBuscarCuentaOrigen";
            this.buttonBuscarCuentaOrigen.Size = new System.Drawing.Size(79, 37);
            this.buttonBuscarCuentaOrigen.TabIndex = 23;
            this.buttonBuscarCuentaOrigen.Text = "Buscar";
            this.buttonBuscarCuentaOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarCuentaOrigen.UseVisualStyleBackColor = true;
            this.buttonBuscarCuentaOrigen.Click += new System.EventHandler(this.buttonBuscarCuentaOrigen_Click);
            // 
            // buttonBuscarIdUsuario
            // 
            this.buttonBuscarIdUsuario.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarIdUsuario.Image")));
            this.buttonBuscarIdUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarIdUsuario.Location = new System.Drawing.Point(143, 106);
            this.buttonBuscarIdUsuario.Name = "buttonBuscarIdUsuario";
            this.buttonBuscarIdUsuario.Size = new System.Drawing.Size(79, 34);
            this.buttonBuscarIdUsuario.TabIndex = 24;
            this.buttonBuscarIdUsuario.Text = "Buscar";
            this.buttonBuscarIdUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarIdUsuario.UseVisualStyleBackColor = true;
            this.buttonBuscarIdUsuario.Click += new System.EventHandler(this.buttonBuscarIdUsuario_Click);
            // 
            // buttonBuscarCuentaDestino
            // 
            this.buttonBuscarCuentaDestino.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarCuentaDestino.Image")));
            this.buttonBuscarCuentaDestino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarCuentaDestino.Location = new System.Drawing.Point(480, 98);
            this.buttonBuscarCuentaDestino.Name = "buttonBuscarCuentaDestino";
            this.buttonBuscarCuentaDestino.Size = new System.Drawing.Size(79, 34);
            this.buttonBuscarCuentaDestino.TabIndex = 25;
            this.buttonBuscarCuentaDestino.Text = "Buscar";
            this.buttonBuscarCuentaDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarCuentaDestino.UseVisualStyleBackColor = true;
            this.buttonBuscarCuentaDestino.Click += new System.EventHandler(this.buttonBuscarCuentaDestino_Click);
            // 
            // labelMontoCuentaOrigen
            // 
            this.labelMontoCuentaOrigen.AutoSize = true;
            this.labelMontoCuentaOrigen.Location = new System.Drawing.Point(315, 69);
            this.labelMontoCuentaOrigen.Name = "labelMontoCuentaOrigen";
            this.labelMontoCuentaOrigen.Size = new System.Drawing.Size(108, 13);
            this.labelMontoCuentaOrigen.TabIndex = 26;
            this.labelMontoCuentaOrigen.Text = "Monto Cuenta Origen";
            // 
            // labelMontoCuentaDestino
            // 
            this.labelMontoCuentaDestino.AutoSize = true;
            this.labelMontoCuentaDestino.Location = new System.Drawing.Point(315, 149);
            this.labelMontoCuentaDestino.Name = "labelMontoCuentaDestino";
            this.labelMontoCuentaDestino.Size = new System.Drawing.Size(113, 13);
            this.labelMontoCuentaDestino.TabIndex = 27;
            this.labelMontoCuentaDestino.Text = "Monto Cuenta Destino";
            // 
            // textBoxMontoCuentaOrigen
            // 
            this.textBoxMontoCuentaOrigen.Location = new System.Drawing.Point(439, 69);
            this.textBoxMontoCuentaOrigen.Name = "textBoxMontoCuentaOrigen";
            this.textBoxMontoCuentaOrigen.ReadOnly = true;
            this.textBoxMontoCuentaOrigen.Size = new System.Drawing.Size(100, 20);
            this.textBoxMontoCuentaOrigen.TabIndex = 28;
            // 
            // textBoxMontoCuentaDestino
            // 
            this.textBoxMontoCuentaDestino.Location = new System.Drawing.Point(439, 149);
            this.textBoxMontoCuentaDestino.Name = "textBoxMontoCuentaDestino";
            this.textBoxMontoCuentaDestino.ReadOnly = true;
            this.textBoxMontoCuentaDestino.Size = new System.Drawing.Size(100, 20);
            this.textBoxMontoCuentaDestino.TabIndex = 29;
            // 
            // TransferenciasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 317);
            this.Controls.Add(this.textBoxMontoCuentaDestino);
            this.Controls.Add(this.textBoxMontoCuentaOrigen);
            this.Controls.Add(this.labelMontoCuentaDestino);
            this.Controls.Add(this.labelMontoCuentaOrigen);
            this.Controls.Add(this.buttonBuscarCuentaDestino);
            this.Controls.Add(this.buttonBuscarIdUsuario);
            this.Controls.Add(this.buttonBuscarCuentaOrigen);
            this.Controls.Add(this.buttonBuscarId);
            this.Controls.Add(this.textBoxCuentaDeDestino);
            this.Controls.Add(this.textBoxCuentaDeOrigen);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dateTimePickerTranferencia);
            this.Controls.Add(this.labelUsuarioId);
            this.Controls.Add(this.labelObservacion);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.labelCuentaDeDestino);
            this.Controls.Add(this.labelCuentaDeOrigen);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.textBoxObservacion);
            this.Name = "TransferenciasForm";
            this.Text = "Transferencias";
            this.Load += new System.EventHandler(this.TransferenciasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DateTimePicker dateTimePickerTranferencia;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.TextBox textBoxCuentaDeOrigen;
        private System.Windows.Forms.TextBox textBoxCuentaDeDestino;
        private System.Windows.Forms.Button buttonBuscarId;
        private System.Windows.Forms.Button buttonBuscarCuentaOrigen;
        private System.Windows.Forms.Button buttonBuscarIdUsuario;
        private System.Windows.Forms.Button buttonBuscarCuentaDestino;
        private System.Windows.Forms.Label labelMontoCuentaOrigen;
        private System.Windows.Forms.Label labelMontoCuentaDestino;
        private System.Windows.Forms.TextBox textBoxMontoCuentaOrigen;
        private System.Windows.Forms.TextBox textBoxMontoCuentaDestino;
    }
}