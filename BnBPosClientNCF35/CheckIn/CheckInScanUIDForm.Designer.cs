namespace BnBPosClientNCF35
{
    partial class CheckInScanUIDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInScanUIDForm));
            this.imageButton2 = new Retrolab.ImageButton();
            this.backBtn = new Retrolab.ImageButton();
            this.nextBtn = new Retrolab.ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.idTBLabel = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
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
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.BackColor = System.Drawing.SystemColors.Control;
            this.nextBtn.Image = null;
            this.nextBtn.Location = new System.Drawing.Point(205, 259);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(32, 32);
            this.nextBtn.TabIndex = 14;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 57);
            this.label1.Text = "Scan Seller\'s Barcode or input the Seller ID!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // idTBLabel
            // 
            this.idTBLabel.Location = new System.Drawing.Point(25, 167);
            this.idTBLabel.Name = "idTBLabel";
            this.idTBLabel.Size = new System.Drawing.Size(92, 20);
            this.idTBLabel.Text = "Seller ID:";
            this.idTBLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(123, 166);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(81, 21);
            this.idTB.TabIndex = 17;
            // 
            // CheckInScanUIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.idTBLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.imageButton2);
            this.Controls.Add(this.backBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckInScanUIDForm";
            this.Text = "CheckInForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Retrolab.ImageButton imageButton2;
        private Retrolab.ImageButton backBtn;
        private Retrolab.ImageButton nextBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idTBLabel;
        private System.Windows.Forms.TextBox idTB;
    }
}