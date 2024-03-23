namespace BnBPosClientNCF35
{
    partial class ManualInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualInputForm));
            this.backBtn = new Retrolab.ImageButton();
            this.manualInputLabel = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.sellRB = new System.Windows.Forms.RadioButton();
            this.auctRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.Control;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(3, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(32, 32);
            this.backBtn.TabIndex = 6;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // manualInputLabel
            // 
            this.manualInputLabel.Location = new System.Drawing.Point(15, 144);
            this.manualInputLabel.Name = "manualInputLabel";
            this.manualInputLabel.Size = new System.Drawing.Size(53, 20);
            this.manualInputLabel.Text = "ID:";
            this.manualInputLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(74, 144);
            this.idTB.MaxLength = 10;
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 21);
            this.idTB.TabIndex = 8;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(165, 245);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(72, 20);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "ADD";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // sellRB
            // 
            this.sellRB.Checked = true;
            this.sellRB.Location = new System.Drawing.Point(74, 92);
            this.sellRB.Name = "sellRB";
            this.sellRB.Size = new System.Drawing.Size(100, 20);
            this.sellRB.TabIndex = 11;
            this.sellRB.Text = "Sell";
            this.sellRB.CheckedChanged += new System.EventHandler(this.sellRB_CheckedChanged);
            // 
            // auctRB
            // 
            this.auctRB.Location = new System.Drawing.Point(74, 118);
            this.auctRB.Name = "auctRB";
            this.auctRB.Size = new System.Drawing.Size(100, 20);
            this.auctRB.TabIndex = 12;
            this.auctRB.TabStop = false;
            this.auctRB.Text = "Auction";
            this.auctRB.CheckedChanged += new System.EventHandler(this.auctRB_CheckedChanged);
            // 
            // ManualInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.auctRB);
            this.Controls.Add(this.sellRB);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.manualInputLabel);
            this.Controls.Add(this.backBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManualInputForm";
            this.Text = "ManualInputForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Retrolab.ImageButton backBtn;
        private System.Windows.Forms.Label manualInputLabel;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.RadioButton sellRB;
        private System.Windows.Forms.RadioButton auctRB;
    }
}