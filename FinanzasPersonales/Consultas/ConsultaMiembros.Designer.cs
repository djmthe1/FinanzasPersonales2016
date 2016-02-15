namespace FinanzasPersonales.Consultas
{
    partial class ConsultaMiembros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaMiembros));
            this.MiembrosdataGridView = new System.Windows.Forms.DataGridView();
            this.Buscarlabel = new System.Windows.Forms.Label();
            this.BuscarcomboBox = new System.Windows.Forms.ComboBox();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MiembrosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MiembrosdataGridView
            // 
            this.MiembrosdataGridView.AllowUserToAddRows = false;
            this.MiembrosdataGridView.AllowUserToDeleteRows = false;
            this.MiembrosdataGridView.AllowUserToOrderColumns = true;
            this.MiembrosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MiembrosdataGridView.Location = new System.Drawing.Point(12, 92);
            this.MiembrosdataGridView.Name = "MiembrosdataGridView";
            this.MiembrosdataGridView.ReadOnly = true;
            this.MiembrosdataGridView.Size = new System.Drawing.Size(669, 225);
            this.MiembrosdataGridView.TabIndex = 0;
            // 
            // Buscarlabel
            // 
            this.Buscarlabel.AutoSize = true;
            this.Buscarlabel.Location = new System.Drawing.Point(12, 29);
            this.Buscarlabel.Name = "Buscarlabel";
            this.Buscarlabel.Size = new System.Drawing.Size(40, 13);
            this.Buscarlabel.TabIndex = 1;
            this.Buscarlabel.Text = "Buscar";
            // 
            // BuscarcomboBox
            // 
            this.BuscarcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarcomboBox.FormattingEnabled = true;
            this.BuscarcomboBox.Location = new System.Drawing.Point(53, 29);
            this.BuscarcomboBox.Name = "BuscarcomboBox";
            this.BuscarcomboBox.Size = new System.Drawing.Size(160, 21);
            this.BuscarcomboBox.TabIndex = 2;
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(219, 29);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(365, 20);
            this.BuscartextBox.TabIndex = 3;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::FinanzasPersonales.Properties.Resources.Search;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(591, 26);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(90, 47);
            this.Buscarbutton.TabIndex = 4;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // ConsultaMiembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 351);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.BuscarcomboBox);
            this.Controls.Add(this.Buscarlabel);
            this.Controls.Add(this.MiembrosdataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaMiembros";
            this.Text = "Consulta Miembros";
            ((System.ComponentModel.ISupportInitialize)(this.MiembrosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MiembrosdataGridView;
        private System.Windows.Forms.Label Buscarlabel;
        private System.Windows.Forms.ComboBox BuscarcomboBox;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.Button Buscarbutton;
    }
}