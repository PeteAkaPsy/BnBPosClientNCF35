namespace BnBPosClientNCF35
{
    partial class CameraForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lightButton = new Retrolab.ImageButton();
            this.imageButton1 = new Retrolab.ImageButton();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 250);
            // 
            // lightButton
            // 
            this.lightButton.BackColor = System.Drawing.SystemColors.Control;
            this.lightButton.Image = null;
            this.lightButton.Location = new System.Drawing.Point(104, 259);
            this.lightButton.Name = "lightButton";
            this.lightButton.Size = new System.Drawing.Size(32, 32);
            this.lightButton.TabIndex = 13;
            this.lightButton.Click += new System.EventHandler(this.lightButton_Click);
            // 
            // imageButton1
            // 
            this.imageButton1.BackColor = System.Drawing.SystemColors.Control;
            this.imageButton1.Image = null;
            this.imageButton1.Location = new System.Drawing.Point(3, 259);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(32, 32);
            this.imageButton1.TabIndex = 15;
            this.imageButton1.Click += new System.EventHandler(this.imageButton1_Click);
            // 
            // CameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.imageButton1);
            this.Controls.Add(this.lightButton);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CameraForm";
            this.Text = "CameraForm";
            this.Closed += new System.EventHandler(this.CameraForm_Closed);
            this.Activated += new System.EventHandler(this.CameraForm_Activate);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CameraForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Retrolab.ImageButton lightButton;
        private Retrolab.ImageButton imageButton1;
    }
}