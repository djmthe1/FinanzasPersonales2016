namespace FinanzasPersonales.Consultas
{
    partial class ConsultaTransferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaTransferencias));
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.comboBoxCampos = new System.Windows.Forms.ComboBox();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(468, 12);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(95, 41);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // comboBoxCampos
            // 
            this.comboBoxCampos.FormattingEnabled = true;
            this.comboBoxCampos.Items.AddRange(new object[] {
            "TransferenciaId",
            "Fecha",
            "Cuenta De Origen",
            "Cuenta De Destino",
            "Monto",
            "Observacion",
            "UsuarioId"});
            this.comboBoxCampos.Location = new System.Drawing.Point(80, 9);
            this.comboBoxCampos.Name = "comboBoxCampos";
            this.comboBoxCampos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCampos.TabIndex = 7;
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(207, 10);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiltro.TabIndex = 8;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(12, 12);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(62, 13);
            this.labelBuscar.TabIndex = 9;
            this.labelBuscar.Text = "Buscar Por:";
            // 
            // ConsultaTransferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 351);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.comboBoxCampos);
            this.Controls.Add(this.buttonBuscar);
            this.Name = "ConsultaTransferencias";
            this.Text = "ConsultaTransferencias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ComboBox comboBoxCampos;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Label labelBuscar;
    }
}