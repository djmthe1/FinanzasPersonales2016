namespace FinanzasPersonales.Consultas
{
    partial class ConsultaCuentasxPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCuentasxPagar));
            this.labelConteo = new System.Windows.Forms.Label();
            this.textBoxConteo = new System.Windows.Forms.TextBox();
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.comboBoxCampos = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConteo
            // 
            this.labelConteo.AutoSize = true;
            this.labelConteo.Location = new System.Drawing.Point(7, 325);
            this.labelConteo.Name = "labelConteo";
            this.labelConteo.Size = new System.Drawing.Size(44, 13);
            this.labelConteo.TabIndex = 19;
            this.labelConteo.Text = "Conteo:";
            // 
            // textBoxConteo
            // 
            this.textBoxConteo.Location = new System.Drawing.Point(57, 322);
            this.textBoxConteo.Name = "textBoxConteo";
            this.textBoxConteo.ReadOnly = true;
            this.textBoxConteo.Size = new System.Drawing.Size(100, 20);
            this.textBoxConteo.TabIndex = 18;
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.AllowUserToAddRows = false;
            this.dataGridViewConsulta.AllowUserToDeleteRows = false;
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Location = new System.Drawing.Point(16, 55);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.ReadOnly = true;
            this.dataGridViewConsulta.Size = new System.Drawing.Size(551, 261);
            this.dataGridViewConsulta.TabIndex = 17;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(16, 12);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(73, 13);
            this.labelBuscar.TabIndex = 16;
            this.labelBuscar.Text = "Buscar Por:";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(222, 8);
            this.textBoxFiltro.MaxLength = 50;
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(219, 20);
            this.textBoxFiltro.TabIndex = 15;
            // 
            // comboBoxCampos
            // 
            this.comboBoxCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampos.FormattingEnabled = true;
            this.comboBoxCampos.Items.AddRange(new object[] {
            "TransferenciaId",
            "Fecha",
            "Cuenta De Origen",
            "Cuenta De Destino",
            "Monto",
            "Observacion",
            "UsuarioId"});
            this.comboBoxCampos.Location = new System.Drawing.Point(95, 8);
            this.comboBoxCampos.Name = "comboBoxCampos";
            this.comboBoxCampos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCampos.TabIndex = 14;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(472, 8);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(95, 41);
            this.buttonBuscar.TabIndex = 13;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // ConsultaCuentasxPagar
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
            this.Name = "ConsultaCuentasxPagar";
            this.Text = "Consulta Cuentas por Pagar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConteo;
        private System.Windows.Forms.TextBox textBoxConteo;
        private System.Windows.Forms.DataGridView dataGridViewConsulta;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.ComboBox comboBoxCampos;
        private System.Windows.Forms.Button buttonBuscar;
    }
}