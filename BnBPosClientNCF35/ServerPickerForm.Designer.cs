namespace BnBPosClientNCF35
{
    partial class ServerPickerForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addEntryIBtn = new Retrolab.ImageButton();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 224);
            // 
            // addEntryIBtn
            // 
            this.addEntryIBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addEntryIBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addEntryIBtn.Image = null;
            this.addEntryIBtn.Location = new System.Drawing.Point(205, 3);
            this.addEntryIBtn.Name = "addEntryIBtn";
            this.addEntryIBtn.Size = new System.Drawing.Size(32, 32);
            this.addEntryIBtn.TabIndex = 7;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(224, 41);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(13, 224);
            this.vScrollBar1.TabIndex = 0;
            // 
            // ServerPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.addEntryIBtn);
            this.Controls.Add(this.panel1);
            this.Menu = this.mainMenu1;
            this.Name = "ServerPickerForm";
            this.Text = "ServerPicker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Retrolab.ImageButton addEntryIBtn;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}