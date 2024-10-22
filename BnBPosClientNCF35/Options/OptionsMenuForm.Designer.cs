namespace BnBPosClientNCF35
{
    partial class OptionsMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsMenuForm));
            this.backBtn = new Retrolab.ImageButton();
            this.generalSettingsBtn = new System.Windows.Forms.Button();
            this.printerSettingsBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.Control;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(3, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(32, 32);
            this.backBtn.TabIndex = 5;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // generalSettingsBtn
            // 
            this.generalSettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.generalSettingsBtn.Location = new System.Drawing.Point(3, 41);
            this.generalSettingsBtn.Name = "generalSettingsBtn";
            this.generalSettingsBtn.Size = new System.Drawing.Size(234, 20);
            this.generalSettingsBtn.TabIndex = 6;
            this.generalSettingsBtn.Text = "General Settings";
            this.generalSettingsBtn.Click += new System.EventHandler(this.generalSettingsBtn_Click);
            // 
            // printerSettingsBtn
            // 
            this.printerSettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.printerSettingsBtn.Location = new System.Drawing.Point(3, 67);
            this.printerSettingsBtn.Name = "printerSettingsBtn";
            this.printerSettingsBtn.Size = new System.Drawing.Size(234, 20);
            this.printerSettingsBtn.TabIndex = 7;
            this.printerSettingsBtn.Text = "Printer Settings";
            this.printerSettingsBtn.Click += new System.EventHandler(this.printerSettingsBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(3, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "...";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OptionsMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.printerSettingsBtn);
            this.Controls.Add(this.generalSettingsBtn);
            this.Controls.Add(this.backBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsMenuForm";
            this.Text = "Options Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Retrolab.ImageButton backBtn;
        private System.Windows.Forms.Button generalSettingsBtn;
        private System.Windows.Forms.Button printerSettingsBtn;
        private System.Windows.Forms.Button button2;
    }
}