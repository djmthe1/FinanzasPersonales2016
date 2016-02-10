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
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            this.labelConteo = new System.Windows.Forms.Label();
            this.textBoxConteo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
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
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // comboBoxCampos
            // 
            this.comboBoxCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampos.FormattingEnabled = true;
            this.comboBoxCampos.Items.AddRange(new object[] {
            "TransferenciaId",
            "Fecha",
            "CuentaDeOrigenId",
            "CuentaDeDestinoId",
            "Monto",
            "Observacion",
            "UsuarioId"});
            this.comboBoxCampos.Location = new System.Drawing.Point(80, 12);
            this.comboBoxCampos.Name = "comboBoxCampos";
            this.comboBoxCampos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCampos.TabIndex = 7;
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(218, 13);
            this.textBoxFiltro.MaxLength = 50;
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(219, 20);
            this.textBoxFiltro.TabIndex = 8;
            this.textBoxFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiltro_KeyPress);
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
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.AllowUserToAddRows = false;
            this.dataGridViewConsulta.AllowUserToDeleteRows = false;
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.ReadOnly = true;
            this.dataGridViewConsulta.Size = new System.Drawing.Size(551, 261);
            this.dataGridViewConsulta.TabIndex = 10;
            // 
            // labelConteo
            // 
            this.labelConteo.AutoSize = true;
            this.labelConteo.Location = new System.Drawing.Point(3, 329);
            this.labelConteo.Name = "labelConteo";
            this.labelConteo.Size = new System.Drawing.Size(44, 13);
            this.labelConteo.TabIndex = 12;
            this.labelConteo.Text = "Conteo:";
            // 
            // textBoxConteo
            // 
            this.textBoxConteo.Location = new System.Drawing.Point(53, 326);
            this.textBoxConteo.Name = "textBoxConteo";
            this.textBoxConteo.ReadOnly = true;
            this.textBoxConteo.Size = new System.Drawing.Size(100, 20);
            this.textBoxConteo.TabIndex = 11;
            // 
            // ConsultaTransferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 351);
            this.Controls.Add(this.labelConteo);
            this.Controls.Add(this.textBoxConteo);
            this.Controls.Add(this.dataGridViewConsulta);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.comboBoxCampos);
            this.Controls.Add(this.buttonBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaTransferencias";
            this.Text = "ConsultaTransferencias";
            this.Load += new System.EventHandler(this.ConsultaTransferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ComboBox comboBoxCampos;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.DataGridView dataGridViewConsulta;
        private System.Windows.Forms.Label labelConteo;
        private System.Windows.Forms.TextBox textBoxConteo;
    }
}