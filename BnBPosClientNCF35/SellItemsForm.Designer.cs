namespace BnBPosClientNCF35
{
    partial class SellItemsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellItemsForm));
            this.imageButton2 = new Retrolab.ImageButton();
            this.backBtn = new Retrolab.ImageButton();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.manualInputButton = new Retrolab.ImageButton();
            this.payButton = new Retrolab.ImageButton();
            this.cancelButton = new Retrolab.ImageButton();
            this.tempSumLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageButton2
            // 
            this.imageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton2.BackColor = System.Drawing.SystemColors.Control;
            this.imageButton2.Image = null;
            this.imageButton2.Location = new System.Drawing.Point(205, 3);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.Size = new System.Drawing.Size(32, 32);
            this.imageButton2.TabIndex = 8;
            this.imageButton2.Click += new System.EventHandler(this.imageButton2_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.Control;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(3, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(32, 32);
            this.backBtn.TabIndex = 7;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(224, 41);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(13, 215);
            this.vScrollBar1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 215);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Location = new System.Drawing.Point(4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 215);
            // 
            // manualInputButton
            // 
            this.manualInputButton.BackColor = System.Drawing.SystemColors.Control;
            this.manualInputButton.Image = null;
            this.manualInputButton.Location = new System.Drawing.Point(104, 259);
            this.manualInputButton.Name = "manualInputButton";
            this.manualInputButton.Size = new System.Drawing.Size(32, 32);
            this.manualInputButton.TabIndex = 12;
            this.manualInputButton.Click += new System.EventHandler(this.manualInputButton_Click);
            // 
            // payButton
            // 
            this.payButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.payButton.BackColor = System.Drawing.SystemColors.Control;
            this.payButton.Image = null;
            this.payButton.Location = new System.Drawing.Point(205, 259);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(32, 32);
            this.payButton.TabIndex = 14;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.Location = new System.Drawing.Point(3, 259);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(32, 32);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tempSumLabel
            // 
            this.tempSumLabel.Location = new System.Drawing.Point(142, 259);
            this.tempSumLabel.Name = "tempSumLabel";
            this.tempSumLabel.Size = new System.Drawing.Size(57, 18);
            this.tempSumLabel.Text = "000.00 $";
            this.tempSumLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SellItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.tempSumLabel);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.manualInputButton);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imageButton2);
            this.Controls.Add(this.backBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellItemsForm";
            this.Text = "SellForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Retrolab.ImageButton imageButton2;
        private Retrolab.ImageButton backBtn;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Retrolab.ImageButton manualInputButton;
        private Retrolab.ImageButton payButton;
        private Retrolab.ImageButton cancelButton;
        private System.Windows.Forms.Label tempSumLabel;
    }
}