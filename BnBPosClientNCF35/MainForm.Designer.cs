using Retrolab;

namespace BnBPosClientNCF35
{
    partial class MainForm
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
            this.sellBtn = new Retrolab.ImageButton();
            this.checkInBtn = new Retrolab.ImageButton();
            this.checkOutBtn = new Retrolab.ImageButton();
            this.imageButton1 = new Retrolab.ImageButton();
            this.confBtn = new Retrolab.ImageButton();
            this.imageButton2 = new Retrolab.ImageButton();
            this.sellLabel = new System.Windows.Forms.Label();
            this.checkInLabel = new System.Windows.Forms.Label();
            this.checkOutLabel = new System.Windows.Forms.Label();
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
            // 
            // imageButton1
            // 
            this.imageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton1.BackColor = System.Drawing.SystemColors.Control;
            this.imageButton1.Image = null;
            this.imageButton1.Location = new System.Drawing.Point(129, 153);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(64, 64);
            this.imageButton1.TabIndex = 4;
            // 
            // confBtn
            // 
            this.confBtn.BackColor = System.Drawing.SystemColors.Control;
            this.confBtn.Image = null;
            this.confBtn.Location = new System.Drawing.Point(3, 3);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(32, 32);
            this.confBtn.TabIndex = 5;
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
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.checkOutLabel);
            this.Controls.Add(this.checkInLabel);
            this.Controls.Add(this.sellLabel);
            this.Controls.Add(this.imageButton2);
            this.Controls.Add(this.confBtn);
            this.Controls.Add(this.imageButton1);
            this.Controls.Add(this.checkOutBtn);
            this.Controls.Add(this.checkInBtn);
            this.Controls.Add(this.sellBtn);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "BnBPos Main";
            this.ResumeLayout(false);

        }

        #endregion

        private ImageButton sellBtn;
        private ImageButton checkInBtn;
        private ImageButton checkOutBtn;
        private ImageButton imageButton1;
        private ImageButton confBtn;
        private ImageButton imageButton2;
        private System.Windows.Forms.Label sellLabel;
        private System.Windows.Forms.Label checkInLabel;
        private System.Windows.Forms.Label checkOutLabel;
    }
}

