namespace FinanzasPersonales.Registros
{
    partial class Presupuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presupuestos));
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.buscarIdButton = new System.Windows.Forms.Button();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.agregarButton = new System.Windows.Forms.Button();
            this.montoLabel = new System.Windows.Forms.Label();
            this.CategoriaLabel = new System.Windows.Forms.Label();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.presupuestosDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(328, 338);
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
            this.NuevoButton.Location = new System.Drawing.Point(10, 338);
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
            this.GuardarButton.Location = new System.Drawing.Point(169, 338);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(111, 41);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionLabel.Location = new System.Drawing.Point(20, 90);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(74, 13);
            this.descripcionLabel.TabIndex = 26;
            this.descripcionLabel.Text = "Descripcion";
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(76, 51);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 25;
            this.idLabel.Text = "Id";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.descripcionTextBox.Location = new System.Drawing.Point(101, 87);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(81, 20);
            this.descripcionTextBox.TabIndex = 24;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.idTextBox.Location = new System.Drawing.Point(101, 45);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(45, 20);
            this.idTextBox.TabIndex = 23;
            // 
            // buscarIdButton
            // 
            this.buscarIdButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buscarIdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarIdButton.Image = ((System.Drawing.Image)(resources.GetObject("buscarIdButton.Image")));
            this.buscarIdButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarIdButton.Location = new System.Drawing.Point(152, 43);
            this.buscarIdButton.Name = "buscarIdButton";
            this.buscarIdButton.Size = new System.Drawing.Size(70, 34);
            this.buscarIdButton.TabIndex = 27;
            this.buscarIdButton.Text = "Buscar";
            this.buscarIdButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarIdButton.UseVisualStyleBackColor = true;
            this.buscarIdButton.Click += new System.EventHandler(this.buscarIdButton_Click);
            // 
            // montoTextBox
            // 
            this.montoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.montoTextBox.Location = new System.Drawing.Point(259, 127);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(100, 20);
            this.montoTextBox.TabIndex = 29;
            // 
            // agregarButton
            // 
            this.agregarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.agregarButton.Location = new System.Drawing.Point(365, 122);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(70, 34);
            this.agregarButton.TabIndex = 28;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // montoLabel
            // 
            this.montoLabel.AutoSize = true;
            this.montoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoLabel.Location = new System.Drawing.Point(213, 130);
            this.montoLabel.Name = "montoLabel";
            this.montoLabel.Size = new System.Drawing.Size(42, 13);
            this.montoLabel.TabIndex = 30;
            this.montoLabel.Text = "Monto";
            // 
            // CategoriaLabel
            // 
            this.CategoriaLabel.AutoSize = true;
            this.CategoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLabel.Location = new System.Drawing.Point(33, 130);
            this.CategoriaLabel.Name = "CategoriaLabel";
            this.CategoriaLabel.Size = new System.Drawing.Size(61, 13);
            this.CategoriaLabel.TabIndex = 31;
            this.CategoriaLabel.Text = "Categoria";
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(101, 126);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(106, 21);
            this.categoriaComboBox.TabIndex = 32;
            // 
            // presupuestosDataGridView
            // 
            this.presupuestosDataGridView.AllowUserToAddRows = false;
            this.presupuestosDataGridView.AllowUserToOrderColumns = true;
            this.presupuestosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.presupuestosDataGridView.Location = new System.Drawing.Point(23, 162);
            this.presupuestosDataGridView.Name = "presupuestosDataGridView";
            this.presupuestosDataGridView.ReadOnly = true;
            this.presupuestosDataGridView.Size = new System.Drawing.Size(397, 150);
            this.presupuestosDataGridView.TabIndex = 33;
            // 
            // Presupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 391);
            this.Controls.Add(this.presupuestosDataGridView);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.CategoriaLabel);
            this.Controls.Add(this.montoLabel);
            this.Controls.Add(this.montoTextBox);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.buscarIdButton);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Presupuestos";
            this.Text = "Presupuestos";
            this.Load += new System.EventHandler(this.Presupuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button buscarIdButton;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Label montoLabel;
        private System.Windows.Forms.Label CategoriaLabel;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.DataGridView presupuestosDataGridView;
    }
}