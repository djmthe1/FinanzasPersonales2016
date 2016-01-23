namespace FinanzasPersonales.Consultas
{
    partial class ConsultaSalidasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaSalidasForm));
            this.Buscarlabel = new System.Windows.Forms.Label();
            this.SalidasdataGridView = new System.Windows.Forms.DataGridView();
            this.ConsultaSalidascomboBox = new System.Windows.Forms.ComboBox();
            this.ConsultaSalidastextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalidasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarlabel
            // 
            this.Buscarlabel.AutoSize = true;
            this.Buscarlabel.Location = new System.Drawing.Point(34, 30);
            this.Buscarlabel.Name = "Buscarlabel";
            this.Buscarlabel.Size = new System.Drawing.Size(40, 13);
            this.Buscarlabel.TabIndex = 0;
            this.Buscarlabel.Text = "Buscar";
            // 
            // SalidasdataGridView
            // 
            this.SalidasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalidasdataGridView.Location = new System.Drawing.Point(12, 91);
            this.SalidasdataGridView.Name = "SalidasdataGridView";
            this.SalidasdataGridView.Size = new System.Drawing.Size(536, 202);
            this.SalidasdataGridView.TabIndex = 1;
            // 
            // ConsultaSalidascomboBox
            // 
            this.ConsultaSalidascomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultaSalidascomboBox.FormattingEnabled = true;
            this.ConsultaSalidascomboBox.Location = new System.Drawing.Point(75, 30);
            this.ConsultaSalidascomboBox.Name = "ConsultaSalidascomboBox";
            this.ConsultaSalidascomboBox.Size = new System.Drawing.Size(121, 21);
            this.ConsultaSalidascomboBox.TabIndex = 2;
            // 
            // ConsultaSalidastextBox
            // 
            this.ConsultaSalidastextBox.Location = new System.Drawing.Point(216, 30);
            this.ConsultaSalidastextBox.Name = "ConsultaSalidastextBox";
            this.ConsultaSalidastextBox.Size = new System.Drawing.Size(223, 20);
            this.ConsultaSalidastextBox.TabIndex = 3;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(453, 30);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(95, 41);
            this.Buscarbutton.TabIndex = 7;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // ConsultaSalidasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 321);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.ConsultaSalidastextBox);
            this.Controls.Add(this.ConsultaSalidascomboBox);
            this.Controls.Add(this.SalidasdataGridView);
            this.Controls.Add(this.Buscarlabel);
            this.Name = "ConsultaSalidasForm";
            this.Text = "ConsultaSalidasForm";
            ((System.ComponentModel.ISupportInitialize)(this.SalidasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Buscarlabel;
        private System.Windows.Forms.DataGridView SalidasdataGridView;
        private System.Windows.Forms.ComboBox ConsultaSalidascomboBox;
        private System.Windows.Forms.TextBox ConsultaSalidastextBox;
        private System.Windows.Forms.Button Buscarbutton;
    }
}