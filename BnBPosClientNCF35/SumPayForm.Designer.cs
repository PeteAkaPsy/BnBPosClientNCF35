namespace BnBPosClientNCF35
{
    partial class SumPayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SumPayForm));
            this.imageButton2 = new Retrolab.ImageButton();
            this.backBtn = new Retrolab.ImageButton();
            this.handedTB = new System.Windows.Forms.TextBox();
            this.sumTextLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.sumPayedBtn = new Retrolab.ImageButton();
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
            this.imageButton2.TabIndex = 4;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.Control;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(3, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(32, 32);
            this.backBtn.TabIndex = 3;
            // 
            // handedTB
            // 
            this.handedTB.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.handedTB.Location = new System.Drawing.Point(90, 147);
            this.handedTB.Name = "handedTB";
            this.handedTB.Size = new System.Drawing.Size(100, 24);
            this.handedTB.TabIndex = 1;
            // 
            // sumTextLabel
            // 
            this.sumTextLabel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.sumTextLabel.Location = new System.Drawing.Point(35, 124);
            this.sumTextLabel.Name = "sumTextLabel";
            this.sumTextLabel.Size = new System.Drawing.Size(49, 20);
            this.sumTextLabel.Text = "Total: ";
            this.sumTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sumLabel
            // 
            this.sumLabel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.sumLabel.Location = new System.Drawing.Point(90, 124);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(100, 20);
            this.sumLabel.Text = "000.00 $";
            // 
            // sumPayedBtn
            // 
            this.sumPayedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sumPayedBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sumPayedBtn.Image = null;
            this.sumPayedBtn.Location = new System.Drawing.Point(205, 259);
            this.sumPayedBtn.Name = "sumPayedBtn";
            this.sumPayedBtn.Size = new System.Drawing.Size(32, 32);
            this.sumPayedBtn.TabIndex = 2;
            this.sumPayedBtn.Click += new System.EventHandler(this.sumPayedBtn_Click);
            // 
            // SumPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.sumPayedBtn);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.sumTextLabel);
            this.Controls.Add(this.handedTB);
            this.Controls.Add(this.imageButton2);
            this.Controls.Add(this.backBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SumPayForm";
            this.Text = "SumPayForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Retrolab.ImageButton imageButton2;
        private Retrolab.ImageButton backBtn;
        private System.Windows.Forms.TextBox handedTB;
        private System.Windows.Forms.Label sumTextLabel;
        private System.Windows.Forms.Label sumLabel;
        private Retrolab.ImageButton sumPayedBtn;
    }
}