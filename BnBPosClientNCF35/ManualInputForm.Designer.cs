namespace BnBPosClientNCF35
{
    partial class ManualInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualInputForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.backBtn = new Retrolab.ImageButton();
            this.manualInputLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
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
            // 
            // manualInputLabel
            // 
            this.manualInputLabel.Location = new System.Drawing.Point(69, 103);
            this.manualInputLabel.Name = "manualInputLabel";
            this.manualInputLabel.Size = new System.Drawing.Size(100, 20);
            this.manualInputLabel.Text = "Please Input the ID here";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 8;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(129, 154);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(72, 20);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "ADD";
            // 
            // ManualInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.manualInputLabel);
            this.Controls.Add(this.backBtn);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "ManualInputForm";
            this.Text = "ManualInputForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Retrolab.ImageButton backBtn;
        private System.Windows.Forms.Label manualInputLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addBtn;
    }
}