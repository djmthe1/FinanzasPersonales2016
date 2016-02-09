namespace FinanzasPersonales.Consultas
{
    partial class ConsultaCategoriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCategoriaForm));
            this.ConsultaCategoriaDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltroCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.ConteoLabel = new System.Windows.Forms.Label();
            this.ConteoTextBox = new System.Windows.Forms.TextBox();
            this.FiltradoPorLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaCategoriaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaCategoriaDataGridView
            // 
            this.ConsultaCategoriaDataGridView.AllowUserToAddRows = false;
            this.ConsultaCategoriaDataGridView.AllowUserToDeleteRows = false;
            this.ConsultaCategoriaDataGridView.AllowUserToOrderColumns = true;
            this.ConsultaCategoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaCategoriaDataGridView.Location = new System.Drawing.Point(15, 50);
            this.ConsultaCategoriaDataGridView.Name = "ConsultaCategoriaDataGridView";
            this.ConsultaCategoriaDataGridView.ReadOnly = true;
            this.ConsultaCategoriaDataGridView.Size = new System.Drawing.Size(541, 294);
            this.ConsultaCategoriaDataGridView.TabIndex = 0;
            // 
            // FiltroCategoriaTextBox
            // 
            this.FiltroCategoriaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FiltroCategoriaTextBox.Location = new System.Drawing.Point(260, 18);
            this.FiltroCategoriaTextBox.Name = "FiltroCategoriaTextBox";
            this.FiltroCategoriaTextBox.Size = new System.Drawing.Size(221, 20);
            this.FiltroCategoriaTextBox.TabIndex = 1;
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "CategoriaId",
            "Descripción"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(90, 17);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(147, 21);
            this.FiltrocomboBox.TabIndex = 2;
            // 
            // ConteoLabel
            // 
            this.ConteoLabel.AutoSize = true;
            this.ConteoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConteoLabel.Location = new System.Drawing.Point(15, 347);
            this.ConteoLabel.Name = "ConteoLabel";
            this.ConteoLabel.Size = new System.Drawing.Size(51, 13);
            this.ConteoLabel.TabIndex = 3;
            this.ConteoLabel.Text = "Conteo:";
            // 
            // ConteoTextBox
            // 
            this.ConteoTextBox.Location = new System.Drawing.Point(76, 347);
            this.ConteoTextBox.Name = "ConteoTextBox";
            this.ConteoTextBox.ReadOnly = true;
            this.ConteoTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConteoTextBox.TabIndex = 4;
            // 
            // FiltradoPorLabel
            // 
            this.FiltradoPorLabel.AutoSize = true;
            this.FiltradoPorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltradoPorLabel.Location = new System.Drawing.Point(12, 21);
            this.FiltradoPorLabel.Name = "FiltradoPorLabel";
            this.FiltradoPorLabel.Size = new System.Drawing.Size(75, 13);
            this.FiltradoPorLabel.TabIndex = 5;
            this.FiltradoPorLabel.Text = "Filtrado por:";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(487, 3);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(90, 41);
            this.BuscarButton.TabIndex = 6;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ConsultaCategoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 373);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FiltradoPorLabel);
            this.Controls.Add(this.ConteoTextBox);
            this.Controls.Add(this.ConteoLabel);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.FiltroCategoriaTextBox);
            this.Controls.Add(this.ConsultaCategoriaDataGridView);
            this.Name = "ConsultaCategoriaForm";
            this.Text = "Consulta de Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaCategoriaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaCategoriaDataGridView;
        private System.Windows.Forms.TextBox FiltroCategoriaTextBox;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label ConteoLabel;
        private System.Windows.Forms.TextBox ConteoTextBox;
        private System.Windows.Forms.Label FiltradoPorLabel;
        private System.Windows.Forms.Button BuscarButton;
    }
}