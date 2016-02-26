namespace FinanzasPersonales.Registros
{
    partial class PresupuestosForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresupuestosForm));
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PresupuestoDataGridView = new System.Windows.Forms.DataGridView();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.CategoriaLabel = new System.Windows.Forms.Label();
            this.Montolabel = new System.Windows.Forms.Label();
            this.PresupuestoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AgregarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.PresupuestoIdtextboxNumerico = new FinanzasPersonales.TexboxNumerico();
            this.MontotexboxNumerico = new FinanzasPersonales.TexboxNumerico();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(155, 73);
            this.DescripcionTextBox.MaxLength = 100;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(160, 20);
            this.DescripcionTextBox.TabIndex = 13;
            this.DescripcionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripcionTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descripción:";
            // 
            // PresupuestoDataGridView
            // 
            this.PresupuestoDataGridView.AllowUserToAddRows = false;
            this.PresupuestoDataGridView.AllowUserToOrderColumns = true;
            this.PresupuestoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PresupuestoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria,
            this.Monto});
            this.PresupuestoDataGridView.Location = new System.Drawing.Point(39, 170);
            this.PresupuestoDataGridView.Name = "PresupuestoDataGridView";
            this.PresupuestoDataGridView.ReadOnly = true;
            this.PresupuestoDataGridView.Size = new System.Drawing.Size(357, 111);
            this.PresupuestoDataGridView.TabIndex = 14;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(39, 143);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoriaComboBox.TabIndex = 15;
            // 
            // CategoriaLabel
            // 
            this.CategoriaLabel.AutoSize = true;
            this.CategoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLabel.Location = new System.Drawing.Point(36, 123);
            this.CategoriaLabel.Name = "CategoriaLabel";
            this.CategoriaLabel.Size = new System.Drawing.Size(78, 17);
            this.CategoriaLabel.TabIndex = 17;
            this.CategoriaLabel.Text = "Categoria";
            // 
            // Montolabel
            // 
            this.Montolabel.AutoSize = true;
            this.Montolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Montolabel.Location = new System.Drawing.Point(184, 123);
            this.Montolabel.Name = "Montolabel";
            this.Montolabel.Size = new System.Drawing.Size(52, 17);
            this.Montolabel.TabIndex = 18;
            this.Montolabel.Text = "Monto";
            // 
            // PresupuestoerrorProvider
            // 
            this.PresupuestoerrorProvider.ContainerControl = this;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Image = global::FinanzasPersonales.Properties.Resources._1456532541_money_add;
            this.AgregarButton.Location = new System.Drawing.Point(290, 113);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(84, 51);
            this.AgregarButton.TabIndex = 19;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Enabled = false;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.Location = new System.Drawing.Point(243, 308);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(72, 51);
            this.EliminarButton.TabIndex = 9;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.Location = new System.Drawing.Point(39, 308);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(64, 51);
            this.NuevoButton.TabIndex = 6;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.Location = new System.Drawing.Point(155, 308);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(68, 51);
            this.GuardarButton.TabIndex = 7;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(243, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(72, 51);
            this.BuscarButton.TabIndex = 8;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // PresupuestoIdtextboxNumerico
            // 
            this.PresupuestoIdtextboxNumerico.Location = new System.Drawing.Point(155, 34);
            this.PresupuestoIdtextboxNumerico.MaxLength = 5;
            this.PresupuestoIdtextboxNumerico.Name = "PresupuestoIdtextboxNumerico";
            this.PresupuestoIdtextboxNumerico.Size = new System.Drawing.Size(82, 20);
            this.PresupuestoIdtextboxNumerico.TabIndex = 20;
            // 
            // MontotexboxNumerico
            // 
            this.MontotexboxNumerico.Location = new System.Drawing.Point(178, 144);
            this.MontotexboxNumerico.MaxLength = 5;
            this.MontotexboxNumerico.Name = "MontotexboxNumerico";
            this.MontotexboxNumerico.Size = new System.Drawing.Size(106, 20);
            this.MontotexboxNumerico.TabIndex = 21;
            // 
            // PresupuestosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 371);
            this.Controls.Add(this.MontotexboxNumerico);
            this.Controls.Add(this.PresupuestoIdtextboxNumerico);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.Montolabel);
            this.Controls.Add(this.CategoriaLabel);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.PresupuestoDataGridView);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.BuscarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PresupuestosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presupuestos";
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PresupuestoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.Label CategoriaLabel;
        private System.Windows.Forms.Label Montolabel;
        private System.Windows.Forms.ErrorProvider PresupuestoerrorProvider;
        private System.Windows.Forms.Button AgregarButton;
        private TexboxNumerico MontotexboxNumerico;
        private TexboxNumerico PresupuestoIdtextboxNumerico;
    }
}