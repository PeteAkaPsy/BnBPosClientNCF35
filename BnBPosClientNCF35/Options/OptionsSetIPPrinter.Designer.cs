namespace BnBPosClientNCF35
{
    partial class OptionsSetIPPrinter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsSetIPPrinter));
            this.backBtn = new Retrolab.ImageButton();
            this.lpNameTB = new System.Windows.Forms.TextBox();
            this.lpUriTB = new System.Windows.Forms.TextBox();
            this.lpUriLabel = new System.Windows.Forms.Label();
            this.labelPrinterPanel = new System.Windows.Forms.Panel();
            this.lpTestBtn = new System.Windows.Forms.Button();
            this.lpProtocolCB = new System.Windows.Forms.ComboBox();
            this.lpProtocolLabel = new System.Windows.Forms.Label();
            this.lpPortLabel = new System.Windows.Forms.Label();
            this.lpPortTB = new System.Windows.Forms.TextBox();
            this.lpSearchBtn = new Retrolab.ImageButton();
            this.lpLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stdpTestBtn = new System.Windows.Forms.Button();
            this.stdpPortLabel = new System.Windows.Forms.Label();
            this.stdpPortTB = new System.Windows.Forms.TextBox();
            this.imageButton1 = new Retrolab.ImageButton();
            this.stdpLabel = new System.Windows.Forms.Label();
            this.stdpNameTB = new System.Windows.Forms.TextBox();
            this.stdpUriLabel = new System.Windows.Forms.Label();
            this.stdUriTB = new System.Windows.Forms.TextBox();
            this.labelPrinterPanel.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // lpNameTB
            // 
            this.lpNameTB.Location = new System.Drawing.Point(3, 23);
            this.lpNameTB.MaxLength = 255;
            this.lpNameTB.Name = "lpNameTB";
            this.lpNameTB.Size = new System.Drawing.Size(189, 21);
            this.lpNameTB.TabIndex = 17;
            this.lpNameTB.Text = "LP2824";
            // 
            // lpUriTB
            // 
            this.lpUriTB.Location = new System.Drawing.Point(32, 50);
            this.lpUriTB.MaxLength = 15;
            this.lpUriTB.Name = "lpUriTB";
            this.lpUriTB.Size = new System.Drawing.Size(107, 21);
            this.lpUriTB.TabIndex = 16;
            this.lpUriTB.Text = "192.168.178.40";
            // 
            // lpUriLabel
            // 
            this.lpUriLabel.Location = new System.Drawing.Point(3, 51);
            this.lpUriLabel.Name = "lpUriLabel";
            this.lpUriLabel.Size = new System.Drawing.Size(23, 20);
            this.lpUriLabel.Text = "IP";
            this.lpUriLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPrinterPanel
            // 
            this.labelPrinterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrinterPanel.Controls.Add(this.lpTestBtn);
            this.labelPrinterPanel.Controls.Add(this.lpProtocolCB);
            this.labelPrinterPanel.Controls.Add(this.lpProtocolLabel);
            this.labelPrinterPanel.Controls.Add(this.lpPortLabel);
            this.labelPrinterPanel.Controls.Add(this.lpPortTB);
            this.labelPrinterPanel.Controls.Add(this.lpSearchBtn);
            this.labelPrinterPanel.Controls.Add(this.lpLabel);
            this.labelPrinterPanel.Controls.Add(this.lpNameTB);
            this.labelPrinterPanel.Controls.Add(this.lpUriLabel);
            this.labelPrinterPanel.Controls.Add(this.lpUriTB);
            this.labelPrinterPanel.Location = new System.Drawing.Point(4, 42);
            this.labelPrinterPanel.Name = "labelPrinterPanel";
            this.labelPrinterPanel.Size = new System.Drawing.Size(233, 105);
            // 
            // lpTestBtn
            // 
            this.lpTestBtn.Location = new System.Drawing.Point(158, 77);
            this.lpTestBtn.Name = "lpTestBtn";
            this.lpTestBtn.Size = new System.Drawing.Size(72, 20);
            this.lpTestBtn.TabIndex = 30;
            this.lpTestBtn.Text = "Test";
            this.lpTestBtn.Click += new System.EventHandler(this.lpTestBtn_Click);
            // 
            // lpProtocolCB
            // 
            this.lpProtocolCB.Items.Add("ZPL");
            this.lpProtocolCB.Location = new System.Drawing.Point(68, 77);
            this.lpProtocolCB.Name = "lpProtocolCB";
            this.lpProtocolCB.Size = new System.Drawing.Size(71, 22);
            this.lpProtocolCB.TabIndex = 29;
            // 
            // lpProtocolLabel
            // 
            this.lpProtocolLabel.Location = new System.Drawing.Point(3, 77);
            this.lpProtocolLabel.Name = "lpProtocolLabel";
            this.lpProtocolLabel.Size = new System.Drawing.Size(59, 20);
            this.lpProtocolLabel.Text = "Protocol";
            this.lpProtocolLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lpPortLabel
            // 
            this.lpPortLabel.Location = new System.Drawing.Point(145, 51);
            this.lpPortLabel.Name = "lpPortLabel";
            this.lpPortLabel.Size = new System.Drawing.Size(39, 20);
            this.lpPortLabel.Text = "Port";
            this.lpPortLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lpPortTB
            // 
            this.lpPortTB.Location = new System.Drawing.Point(190, 50);
            this.lpPortTB.MaxLength = 5;
            this.lpPortTB.Name = "lpPortTB";
            this.lpPortTB.Size = new System.Drawing.Size(40, 21);
            this.lpPortTB.TabIndex = 24;
            this.lpPortTB.Text = "9100";
            // 
            // lpSearchBtn
            // 
            this.lpSearchBtn.BackColor = System.Drawing.SystemColors.Control;
            this.lpSearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("lpSearchBtn.Image")));
            this.lpSearchBtn.Location = new System.Drawing.Point(198, 3);
            this.lpSearchBtn.Name = "lpSearchBtn";
            this.lpSearchBtn.Size = new System.Drawing.Size(32, 32);
            this.lpSearchBtn.TabIndex = 22;
            this.lpSearchBtn.Click += new System.EventHandler(this.lpSearchBtn_Click);
            // 
            // lpLabel
            // 
            this.lpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lpLabel.Location = new System.Drawing.Point(3, 3);
            this.lpLabel.Name = "lpLabel";
            this.lpLabel.Size = new System.Drawing.Size(189, 20);
            this.lpLabel.Text = "Label Printer";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.stdpTestBtn);
            this.panel1.Controls.Add(this.stdpPortLabel);
            this.panel1.Controls.Add(this.stdpPortTB);
            this.panel1.Controls.Add(this.imageButton1);
            this.panel1.Controls.Add(this.stdpLabel);
            this.panel1.Controls.Add(this.stdpNameTB);
            this.panel1.Controls.Add(this.stdpUriLabel);
            this.panel1.Controls.Add(this.stdUriTB);
            this.panel1.Location = new System.Drawing.Point(4, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 105);
            // 
            // stdpTestBtn
            // 
            this.stdpTestBtn.Location = new System.Drawing.Point(158, 76);
            this.stdpTestBtn.Name = "stdpTestBtn";
            this.stdpTestBtn.Size = new System.Drawing.Size(72, 20);
            this.stdpTestBtn.TabIndex = 31;
            this.stdpTestBtn.Text = "Test";
            this.stdpTestBtn.Click += new System.EventHandler(this.stdpTestBtn_Click);
            // 
            // stdpPortLabel
            // 
            this.stdpPortLabel.Location = new System.Drawing.Point(145, 51);
            this.stdpPortLabel.Name = "stdpPortLabel";
            this.stdpPortLabel.Size = new System.Drawing.Size(39, 20);
            this.stdpPortLabel.Text = "Port";
            this.stdpPortLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stdpPortTB
            // 
            this.stdpPortTB.Location = new System.Drawing.Point(190, 50);
            this.stdpPortTB.MaxLength = 5;
            this.stdpPortTB.Name = "stdpPortTB";
            this.stdpPortTB.Size = new System.Drawing.Size(40, 21);
            this.stdpPortTB.TabIndex = 24;
            this.stdpPortTB.Text = "9100";
            // 
            // imageButton1
            // 
            this.imageButton1.BackColor = System.Drawing.SystemColors.Control;
            this.imageButton1.Image = ((System.Drawing.Image)(resources.GetObject("imageButton1.Image")));
            this.imageButton1.Location = new System.Drawing.Point(198, 3);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(32, 32);
            this.imageButton1.TabIndex = 22;
            this.imageButton1.Click += new System.EventHandler(this.imageButton1_Click);
            // 
            // stdpLabel
            // 
            this.stdpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.stdpLabel.Location = new System.Drawing.Point(3, 3);
            this.stdpLabel.Name = "stdpLabel";
            this.stdpLabel.Size = new System.Drawing.Size(189, 20);
            this.stdpLabel.Text = "Standard Printer";
            // 
            // stdpNameTB
            // 
            this.stdpNameTB.Location = new System.Drawing.Point(3, 23);
            this.stdpNameTB.MaxLength = 255;
            this.stdpNameTB.Name = "stdpNameTB";
            this.stdpNameTB.Size = new System.Drawing.Size(189, 21);
            this.stdpNameTB.TabIndex = 17;
            this.stdpNameTB.Text = "CLP-680ND";
            // 
            // stdpUriLabel
            // 
            this.stdpUriLabel.Location = new System.Drawing.Point(2, 51);
            this.stdpUriLabel.Name = "stdpUriLabel";
            this.stdpUriLabel.Size = new System.Drawing.Size(24, 20);
            this.stdpUriLabel.Text = "IP";
            this.stdpUriLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // stdUriTB
            // 
            this.stdUriTB.Location = new System.Drawing.Point(32, 50);
            this.stdUriTB.MaxLength = 15;
            this.stdUriTB.Name = "stdUriTB";
            this.stdUriTB.Size = new System.Drawing.Size(107, 21);
            this.stdUriTB.TabIndex = 16;
            this.stdUriTB.Text = "192.168.178.58";
            // 
            // OptionsSetIPPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPrinterPanel);
            this.Controls.Add(this.backBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsSetIPPrinter";
            this.Text = "Printers";
            this.labelPrinterPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Retrolab.ImageButton backBtn;
        private System.Windows.Forms.TextBox lpNameTB;
        private System.Windows.Forms.TextBox lpUriTB;
        private System.Windows.Forms.Label lpUriLabel;
        private System.Windows.Forms.Panel labelPrinterPanel;
        private System.Windows.Forms.Label lpPortLabel;
        private System.Windows.Forms.TextBox lpPortTB;
        private Retrolab.ImageButton lpSearchBtn;
        private System.Windows.Forms.Label lpLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stdpPortLabel;
        private System.Windows.Forms.TextBox stdpPortTB;
        private Retrolab.ImageButton imageButton1;
        private System.Windows.Forms.Label stdpLabel;
        private System.Windows.Forms.TextBox stdpNameTB;
        private System.Windows.Forms.Label stdpUriLabel;
        private System.Windows.Forms.TextBox stdUriTB;
        private System.Windows.Forms.Label lpProtocolLabel;
        private System.Windows.Forms.ComboBox lpProtocolCB;
        private System.Windows.Forms.Button lpTestBtn;
        private System.Windows.Forms.Button stdpTestBtn;
    }
}