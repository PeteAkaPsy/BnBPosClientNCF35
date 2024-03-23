namespace BnBPosClientNCF35
{
    partial class AuctionItemsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuctionItemsForm));
            this.imageButton2 = new Retrolab.ImageButton();
            this.backBtn = new Retrolab.ImageButton();
            this.manualInputButton = new Retrolab.ImageButton();
            this.payButton = new Retrolab.ImageButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.startPriceLabel = new System.Windows.Forms.Label();
            this.startPriceTextLabel = new System.Windows.Forms.Label();
            this.categoryTextLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
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
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(41, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(158, 32);
            this.nameLabel.Text = "Name";
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(3, 57);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.ReadOnly = true;
            this.descriptionTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.descriptionTB.Size = new System.Drawing.Size(234, 176);
            this.descriptionTB.TabIndex = 16;
            this.descriptionTB.TabStop = false;
            this.descriptionTB.Text = "Description";
            // 
            // startPriceLabel
            // 
            this.startPriceLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.startPriceLabel.Location = new System.Drawing.Point(173, 236);
            this.startPriceLabel.Name = "startPriceLabel";
            this.startPriceLabel.Size = new System.Drawing.Size(64, 20);
            this.startPriceLabel.Text = "0000,00 $";
            // 
            // startPriceTextLabel
            // 
            this.startPriceTextLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.startPriceTextLabel.Location = new System.Drawing.Point(3, 236);
            this.startPriceTextLabel.Name = "startPriceTextLabel";
            this.startPriceTextLabel.Size = new System.Drawing.Size(164, 20);
            this.startPriceTextLabel.Text = "Starting Price:";
            this.startPriceTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // categoryTextLabel
            // 
            this.categoryTextLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.categoryTextLabel.Location = new System.Drawing.Point(3, 38);
            this.categoryTextLabel.Name = "categoryTextLabel";
            this.categoryTextLabel.Size = new System.Drawing.Size(164, 16);
            this.categoryTextLabel.Text = "Category: ";
            this.categoryTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.categoryLabel.Location = new System.Drawing.Point(173, 38);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(64, 16);
            this.categoryLabel.Text = "Other";
            // 
            // AuctionItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.categoryTextLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.startPriceTextLabel);
            this.Controls.Add(this.startPriceLabel);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.manualInputButton);
            this.Controls.Add(this.imageButton2);
            this.Controls.Add(this.backBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuctionItemsForm";
            this.Text = "CheckInForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Retrolab.ImageButton imageButton2;
        private Retrolab.ImageButton backBtn;
        private Retrolab.ImageButton manualInputButton;
        private Retrolab.ImageButton payButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.Label startPriceLabel;
        private System.Windows.Forms.Label startPriceTextLabel;
        private System.Windows.Forms.Label categoryTextLabel;
        private System.Windows.Forms.Label categoryLabel;
    }
}