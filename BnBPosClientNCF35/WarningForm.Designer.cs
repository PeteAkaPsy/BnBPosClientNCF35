namespace BnBPosClientNCF35
{
    partial class WarningForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new Retrolab.ImageButton();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.SystemColors.Control;
            this.okButton.Image = null;
            this.okButton.Location = new System.Drawing.Point(57, 98);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(128, 128);
            this.okButton.TabIndex = 15;
            this.okButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(3, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(234, 56);
            this.label.Text = "18+";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.label);
            this.Controls.Add(this.okButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WarningForm";
            this.Text = "WarningForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Retrolab.ImageButton okButton;
        private System.Windows.Forms.Label label;
    }
}