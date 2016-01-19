namespace FinanzasPersonales
{
    partial class Portada
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
            this.buttonTransferencias = new System.Windows.Forms.Button();
            this.Salidasbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTransferencias
            // 
            this.buttonTransferencias.Location = new System.Drawing.Point(13, 13);
            this.buttonTransferencias.Name = "buttonTransferencias";
            this.buttonTransferencias.Size = new System.Drawing.Size(97, 42);
            this.buttonTransferencias.TabIndex = 0;
            this.buttonTransferencias.Text = "Transferencias";
            this.buttonTransferencias.UseVisualStyleBackColor = true;
            this.buttonTransferencias.Click += new System.EventHandler(this.buttonTransferencias_Click);
            // 
            // Salidasbutton
            // 
            this.Salidasbutton.Location = new System.Drawing.Point(13, 97);
            this.Salidasbutton.Name = "Salidasbutton";
            this.Salidasbutton.Size = new System.Drawing.Size(97, 41);
            this.Salidasbutton.TabIndex = 1;
            this.Salidasbutton.Text = "Salidas";
            this.Salidasbutton.UseVisualStyleBackColor = true;
            this.Salidasbutton.Click += new System.EventHandler(this.Salidasbutton_Click);
            // 
            // Portada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 315);
            this.Controls.Add(this.Salidasbutton);
            this.Controls.Add(this.buttonTransferencias);
            this.Name = "Portada";
            this.Text = "Portada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTransferencias;
        private System.Windows.Forms.Button Salidasbutton;
    }
}

