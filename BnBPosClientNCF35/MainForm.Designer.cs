using Retrolab;
using BnBPosClientNCF35.Properties;

namespace BnBPosClientNCF35
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sellBtn = new Retrolab.ImageButton();
            this.checkInBtn = new Retrolab.ImageButton();
            this.checkOutBtn = new Retrolab.ImageButton();
            this.auctionBtn = new Retrolab.ImageButton();
            this.backBtn = new Retrolab.ImageButton();
            this.imageButton2 = new Retrolab.ImageButton();
            this.sellLabel = new System.Windows.Forms.Label();
            this.checkInLabel = new System.Windows.Forms.Label();
            this.checkOutLabel = new System.Windows.Forms.Label();
            this.auctionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sellBtn
            // 
            this.sellBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sellBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sellBtn.Image = null;
            this.sellBtn.Location = new System.Drawing.Point(129, 53);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(64, 64);
            this.sellBtn.TabIndex = 1;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // checkInBtn
            // 
            this.checkInBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkInBtn.BackColor = System.Drawing.SystemColors.Control;
            this.checkInBtn.Image = null;
            this.checkInBtn.Location = new System.Drawing.Point(59, 53);
            this.checkInBtn.Name = "checkInBtn";
            this.checkInBtn.Size = new System.Drawing.Size(64, 64);
            this.checkInBtn.TabIndex = 2;
            this.checkInBtn.Click += new System.EventHandler(this.checkInBtn_Click);
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkOutBtn.BackColor = System.Drawing.SystemColors.Control;
            this.checkOutBtn.Image = null;
            this.checkOutBtn.Location = new System.Drawing.Point(59, 153);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(64, 64);
            this.checkOutBtn.TabIndex = 3;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // auctionBtn
            // 
            this.auctionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.auctionBtn.BackColor = System.Drawing.SystemColors.Control;
            this.auctionBtn.Image = null;
            this.auctionBtn.Location = new System.Drawing.Point(129, 153);
            this.auctionBtn.Name = "auctionBtn";
            this.auctionBtn.Size = new System.Drawing.Size(64, 64);
            this.auctionBtn.TabIndex = 4;
            this.auctionBtn.Click += new System.EventHandler(this.auctionBtn_Click);
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
            // imageButton2
            // 
            this.imageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton2.BackColor = System.Drawing.SystemColors.Control;
            this.imageButton2.Image = null;
            this.imageButton2.Location = new System.Drawing.Point(205, 3);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.Size = new System.Drawing.Size(32, 32);
            this.imageButton2.TabIndex = 6;
            this.imageButton2.Click += new System.EventHandler(this.imageButton2_Click);
            // 
            // sellLabel
            // 
            this.sellLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.sellLabel.Location = new System.Drawing.Point(129, 120);
            this.sellLabel.Name = "sellLabel";
            this.sellLabel.Size = new System.Drawing.Size(64, 20);
            this.sellLabel.Text = "Sell";
            this.sellLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkInLabel
            // 
            this.checkInLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.checkInLabel.Location = new System.Drawing.Point(59, 120);
            this.checkInLabel.Name = "checkInLabel";
            this.checkInLabel.Size = new System.Drawing.Size(64, 20);
            this.checkInLabel.Text = "CheckIn";
            this.checkInLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkOutLabel
            // 
            this.checkOutLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.checkOutLabel.Location = new System.Drawing.Point(59, 220);
            this.checkOutLabel.Name = "checkOutLabel";
            this.checkOutLabel.Size = new System.Drawing.Size(64, 20);
            this.checkOutLabel.Text = "CheckOut";
            this.checkOutLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // auctionLabel
            // 
            this.auctionLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.auctionLabel.Location = new System.Drawing.Point(129, 220);
            this.auctionLabel.Name = "auctionLabel";
            this.auctionLabel.Size = new System.Drawing.Size(64, 20);
            this.auctionLabel.Text = "Auction";
            this.auctionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.auctionLabel);
            this.Controls.Add(this.checkOutLabel);
            this.Controls.Add(this.checkInLabel);
            this.Controls.Add(this.sellLabel);
            this.Controls.Add(this.imageButton2);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.auctionBtn);
            this.Controls.Add(this.checkOutBtn);
            this.Controls.Add(this.checkInBtn);
            this.Controls.Add(this.sellBtn);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BnBPos Main";
            this.ResumeLayout(false);

        }

        #endregion

        private ImageButton sellBtn;
        private ImageButton checkInBtn;
        private ImageButton checkOutBtn;
        private ImageButton auctionBtn;
        private ImageButton backBtn;
        private ImageButton imageButton2;
        private System.Windows.Forms.Label sellLabel;
        private System.Windows.Forms.Label checkInLabel;
        private System.Windows.Forms.Label checkOutLabel;
        private System.Windows.Forms.Label auctionLabel;
    }
}

