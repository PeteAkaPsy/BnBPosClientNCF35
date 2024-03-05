namespace BnBPosClientNCF35
{
    partial class ConnectForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.serverUriLabel = new System.Windows.Forms.Label();
            this.serverUriTB = new System.Windows.Forms.TextBox();
            this.serverNameTB = new System.Windows.Forms.TextBox();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Location = new System.Drawing.Point(39, 106);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(164, 20);
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(39, 153);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(164, 20);
            this.passwordLabel.Text = "Password";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(39, 129);
            this.usernameTB.MaxLength = 128;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(164, 21);
            this.usernameTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(39, 176);
            this.passwordTB.MaxLength = 128;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(164, 21);
            this.passwordTB.TabIndex = 3;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(131, 214);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(72, 20);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // serverUriLabel
            // 
            this.serverUriLabel.Location = new System.Drawing.Point(39, 59);
            this.serverUriLabel.Name = "serverUriLabel";
            this.serverUriLabel.Size = new System.Drawing.Size(164, 20);
            this.serverUriLabel.Text = "Server Address";
            // 
            // serverUriTB
            // 
            this.serverUriTB.Location = new System.Drawing.Point(39, 82);
            this.serverUriTB.MaxLength = 255;
            this.serverUriTB.Name = "serverUriTB";
            this.serverUriTB.Size = new System.Drawing.Size(164, 21);
            this.serverUriTB.TabIndex = 8;
            // 
            // serverNameTB
            // 
            this.serverNameTB.Location = new System.Drawing.Point(39, 37);
            this.serverNameTB.MaxLength = 255;
            this.serverNameTB.Name = "serverNameTB";
            this.serverNameTB.Size = new System.Drawing.Size(164, 21);
            this.serverNameTB.TabIndex = 13;
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.Location = new System.Drawing.Point(39, 14);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(164, 20);
            this.serverNameLabel.Text = "Server Name";
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.serverNameTB);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.serverUriTB);
            this.Controls.Add(this.serverUriLabel);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Menu = this.mainMenu1;
            this.Name = "ConnectForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label serverUriLabel;
        private System.Windows.Forms.TextBox serverUriTB;
        private System.Windows.Forms.TextBox serverNameTB;
        private System.Windows.Forms.Label serverNameLabel;
    }
}