namespace FinanzasPersonales.Consultas
{
    partial class ConsultaCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCuentas));
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ConteotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CamposcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.AllowUserToAddRows = false;
            this.ConsultadataGridView.AllowUserToDeleteRows = false;
            this.ConsultadataGridView.AllowUserToOrderColumns = true;
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(12, 49);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.ReadOnly = true;
            this.ConsultadataGridView.Size = new System.Drawing.Size(551, 274);
            this.ConsultadataGridView.TabIndex = 0;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(468, 2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(95, 41);
            this.BuscarButton.TabIndex = 5;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ConteotextBox
            // 
            this.ConteotextBox.Location = new System.Drawing.Point(67, 326);
            this.ConteotextBox.Name = "ConteotextBox";
            this.ConteotextBox.ReadOnly = true;
            this.ConteotextBox.Size = new System.Drawing.Size(100, 20);
            this.ConteotextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Conteo:";
            // 
            // CamposcomboBox
            // 
            this.CamposcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CamposcomboBox.FormattingEnabled = true;
            this.CamposcomboBox.Items.AddRange(new object[] {
            "CuentaId",
            "Descripcion"});
            this.CamposcomboBox.Location = new System.Drawing.Point(98, 22);
            this.CamposcomboBox.Name = "CamposcomboBox";
            this.CamposcomboBox.Size = new System.Drawing.Size(121, 21);
            this.CamposcomboBox.TabIndex = 8;
            this.CamposcomboBox.SelectedIndexChanged += new System.EventHandler(this.CamposcomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filtrar Por";
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Location = new System.Drawing.Point(236, 23);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(226, 20);
            this.FiltrotextBox.TabIndex = 10;
            // 
            // ConsultaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 351);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CamposcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConteotextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ConsultadataGridView);
            this.Name = "ConsultaCuentas";
            this.Text = "ConsultaCuentas";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox ConteotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CamposcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FiltrotextBox;
    }
}