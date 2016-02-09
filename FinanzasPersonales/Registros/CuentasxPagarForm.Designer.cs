namespace FinanzasPersonales.Registros
{
    partial class CuentasxPagarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuentasxPagarForm));
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonBuscarId = new System.Windows.Forms.Button();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePickeCuentasxPagar = new System.Windows.Forms.DateTimePicker();
            this.labelMonto = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.textBoxConcepto = new System.Windows.Forms.TextBox();
            this.labelConcepto = new System.Windows.Forms.Label();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(327, 316);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(111, 41);
            this.EliminarButton.TabIndex = 13;
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
            this.NuevoButton.Location = new System.Drawing.Point(9, 316);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(111, 41);
            this.NuevoButton.TabIndex = 11;
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
            this.GuardarButton.Location = new System.Drawing.Point(168, 316);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(111, 41);
            this.GuardarButton.TabIndex = 12;
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
            this.labelId.Location = new System.Drawing.Point(125, 49);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 14;
            this.labelId.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxId.Location = new System.Drawing.Point(163, 46);
            this.textBoxId.MaxLength = 10;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(40, 20);
            this.textBoxId.TabIndex = 15;
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // buttonBuscarId
            // 
            this.buttonBuscarId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBuscarId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarId.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarId.Image")));
            this.buttonBuscarId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarId.Location = new System.Drawing.Point(214, 38);
            this.buttonBuscarId.Name = "buttonBuscarId";
            this.buttonBuscarId.Size = new System.Drawing.Size(92, 34);
            this.buttonBuscarId.TabIndex = 23;
            this.buttonBuscarId.Text = "Buscar";
            this.buttonBuscarId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarId.UseVisualStyleBackColor = true;
            this.buttonBuscarId.Click += new System.EventHandler(this.buttonBuscarId_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(101, 92);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(42, 13);
            this.labelFecha.TabIndex = 24;
            this.labelFecha.Text = "Fecha";
            // 
            // dateTimePickeCuentasxPagar
            // 
            this.dateTimePickeCuentasxPagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickeCuentasxPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickeCuentasxPagar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickeCuentasxPagar.Location = new System.Drawing.Point(163, 84);
            this.dateTimePickeCuentasxPagar.Name = "dateTimePickeCuentasxPagar";
            this.dateTimePickeCuentasxPagar.Size = new System.Drawing.Size(116, 20);
            this.dateTimePickeCuentasxPagar.TabIndex = 25;
            // 
            // labelMonto
            // 
            this.labelMonto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.Location = new System.Drawing.Point(103, 191);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(42, 13);
            this.labelMonto.TabIndex = 27;
            this.labelMonto.Text = "Monto";
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMonto.Location = new System.Drawing.Point(163, 192);
            this.textBoxMonto.MaxLength = 12;
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(116, 20);
            this.textBoxMonto.TabIndex = 26;
            this.textBoxMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonto_KeyPress);
            // 
            // textBoxConcepto
            // 
            this.textBoxConcepto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxConcepto.Location = new System.Drawing.Point(163, 132);
            this.textBoxConcepto.MaxLength = 50;
            this.textBoxConcepto.Multiline = true;
            this.textBoxConcepto.Name = "textBoxConcepto";
            this.textBoxConcepto.Size = new System.Drawing.Size(116, 39);
            this.textBoxConcepto.TabIndex = 28;
            this.textBoxConcepto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxConcepto_KeyPress);
            // 
            // labelConcepto
            // 
            this.labelConcepto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConcepto.AutoSize = true;
            this.labelConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConcepto.Location = new System.Drawing.Point(82, 132);
            this.labelConcepto.Name = "labelConcepto";
            this.labelConcepto.Size = new System.Drawing.Size(61, 13);
            this.labelConcepto.TabIndex = 29;
            this.labelConcepto.Text = "Concepto";
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Location = new System.Drawing.Point(163, 230);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.Size = new System.Drawing.Size(116, 20);
            this.textBoxBalance.TabIndex = 30;
            this.textBoxBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBalance_KeyPress);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(90, 233);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(53, 13);
            this.labelBalance.TabIndex = 31;
            this.labelBalance.Text = "Balance";
            // 
            // CuentasxPagarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 382);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.textBoxConcepto);
            this.Controls.Add(this.labelConcepto);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.dateTimePickeCuentasxPagar);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.buttonBuscarId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Name = "CuentasxPagarForm";
            this.Text = "Cuentas por Pagar";
            this.Load += new System.EventHandler(this.CuentasxPagarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonBuscarId;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickeCuentasxPagar;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.TextBox textBoxConcepto;
        private System.Windows.Forms.Label labelConcepto;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label labelBalance;
    }
}