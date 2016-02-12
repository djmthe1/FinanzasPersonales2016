namespace FinanzasPersonales.Consultas
{
    partial class ConsultaCuentasxCobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCuentasxCobrar));
            this.ConsultaCuentasxCobrarDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltroLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.FiltroCxCTextBox = new System.Windows.Forms.TextBox();
            this.ConteoTextBox = new System.Windows.Forms.TextBox();
            this.ConteoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaCuentasxCobrarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaCuentasxCobrarDataGridView
            // 
            this.ConsultaCuentasxCobrarDataGridView.AllowUserToAddRows = false;
            this.ConsultaCuentasxCobrarDataGridView.AllowUserToDeleteRows = false;
            this.ConsultaCuentasxCobrarDataGridView.AllowUserToOrderColumns = true;
            this.ConsultaCuentasxCobrarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaCuentasxCobrarDataGridView.Location = new System.Drawing.Point(12, 46);
            this.ConsultaCuentasxCobrarDataGridView.Name = "ConsultaCuentasxCobrarDataGridView";
            this.ConsultaCuentasxCobrarDataGridView.ReadOnly = true;
            this.ConsultaCuentasxCobrarDataGridView.Size = new System.Drawing.Size(687, 290);
            this.ConsultaCuentasxCobrarDataGridView.TabIndex = 0;
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroLabel.Location = new System.Drawing.Point(12, 18);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(92, 16);
            this.FiltroLabel.TabIndex = 1;
            this.FiltroLabel.Text = "Filtrado por:";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "ID",
            "Fecha",
            "CuentaId",
            "Concepto",
            "Monto",
            "Balance"});
            this.FiltroComboBox.Location = new System.Drawing.Point(120, 18);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(153, 21);
            this.FiltroComboBox.TabIndex = 2;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(543, 6);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(90, 40);
            this.BuscarButton.TabIndex = 8;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // FiltroCxCTextBox
            // 
            this.FiltroCxCTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FiltroCxCTextBox.Location = new System.Drawing.Point(290, 21);
            this.FiltroCxCTextBox.Name = "FiltroCxCTextBox";
            this.FiltroCxCTextBox.Size = new System.Drawing.Size(228, 20);
            this.FiltroCxCTextBox.TabIndex = 7;
            this.FiltroCxCTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FiltroCxCTextBox_KeyPress);
            // 
            // ConteoTextBox
            // 
            this.ConteoTextBox.Location = new System.Drawing.Point(70, 342);
            this.ConteoTextBox.Name = "ConteoTextBox";
            this.ConteoTextBox.ReadOnly = true;
            this.ConteoTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConteoTextBox.TabIndex = 10;
            // 
            // ConteoLabel
            // 
            this.ConteoLabel.AutoSize = true;
            this.ConteoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConteoLabel.Location = new System.Drawing.Point(9, 342);
            this.ConteoLabel.Name = "ConteoLabel";
            this.ConteoLabel.Size = new System.Drawing.Size(51, 13);
            this.ConteoLabel.TabIndex = 9;
            this.ConteoLabel.Text = "Conteo:";
            // 
            // ConsultaCuentasxCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 366);
            this.Controls.Add(this.ConteoTextBox);
            this.Controls.Add(this.ConteoLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FiltroCxCTextBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.FiltroLabel);
            this.Controls.Add(this.ConsultaCuentasxCobrarDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaCuentasxCobrar";
            this.Text = "Consulta Cuentas por Cobrar";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaCuentasxCobrarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaCuentasxCobrarDataGridView;
        private System.Windows.Forms.Label FiltroLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox FiltroCxCTextBox;
        private System.Windows.Forms.TextBox ConteoTextBox;
        private System.Windows.Forms.Label ConteoLabel;
    }
}