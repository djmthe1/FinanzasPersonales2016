namespace FinanzasPersonales.Registros
{
    partial class TiposIngresosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiposIngresosForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoradioButton = new System.Windows.Forms.RadioButton();
            this.SiradioButton = new System.Windows.Forms.RadioButton();
            this.TipoIngresoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TipoIngresoerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipos de Ingresos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripción:";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(12, 167);
            this.DescripciontextBox.Multiline = true;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(269, 54);
            this.DescripciontextBox.TabIndex = 1;
            this.DescripciontextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripciontextBox_KeyPress);
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(72, 103);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(104, 20);
            this.IdtextBox.TabIndex = 3;
            this.IdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdtextBox_KeyPress);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.Location = new System.Drawing.Point(182, 320);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(51, 40);
            this.Eliminarbutton.TabIndex = 4;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::FinanzasPersonales.Properties.Resources.Save;
            this.Guardarbutton.Location = new System.Drawing.Point(115, 320);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(43, 40);
            this.Guardarbutton.TabIndex = 4;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::FinanzasPersonales.Properties.Resources.Add;
            this.Nuevobutton.Location = new System.Drawing.Point(43, 320);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(50, 40);
            this.Nuevobutton.TabIndex = 4;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::FinanzasPersonales.Properties.Resources.Search;
            this.Buscarbutton.Location = new System.Drawing.Point(189, 74);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(44, 49);
            this.Buscarbutton.TabIndex = 4;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoradioButton);
            this.groupBox1.Controls.Add(this.SiradioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 33);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EsActivo";
            // 
            // NoradioButton
            // 
            this.NoradioButton.AutoSize = true;
            this.NoradioButton.Location = new System.Drawing.Point(60, 14);
            this.NoradioButton.Name = "NoradioButton";
            this.NoradioButton.Size = new System.Drawing.Size(39, 17);
            this.NoradioButton.TabIndex = 1;
            this.NoradioButton.TabStop = true;
            this.NoradioButton.Text = "No";
            this.NoradioButton.UseVisualStyleBackColor = true;
            // 
            // SiradioButton
            // 
            this.SiradioButton.AutoSize = true;
            this.SiradioButton.Location = new System.Drawing.Point(20, 14);
            this.SiradioButton.Name = "SiradioButton";
            this.SiradioButton.Size = new System.Drawing.Size(34, 17);
            this.SiradioButton.TabIndex = 0;
            this.SiradioButton.TabStop = true;
            this.SiradioButton.Text = "Si";
            this.SiradioButton.UseVisualStyleBackColor = true;
            // 
            // TipoIngresoerrorProvider
            // 
            this.TipoIngresoerrorProvider.ContainerControl = this;
            // 
            // TiposIngresosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TiposIngresosForm";
            this.Text = "TiposIngresosForm";
            this.Load += new System.EventHandler(this.TiposIngresosForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TipoIngresoerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NoradioButton;
        private System.Windows.Forms.RadioButton SiradioButton;
        private System.Windows.Forms.ErrorProvider TipoIngresoerrorProvider;
    }
}