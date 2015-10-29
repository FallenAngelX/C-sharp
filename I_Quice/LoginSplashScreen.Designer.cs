namespace I_Quice
{
    partial class LoginSplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectMySQLLogingroupBox = new System.Windows.Forms.GroupBox();
            this.Portlabel = new System.Windows.Forms.Label();
            this.Realmdlabel = new System.Windows.Forms.Label();
            this.Worldlabel = new System.Windows.Forms.Label();
            this.Characterslabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.Serverlabel = new System.Windows.Forms.Label();
            this.LoginConnectbutton = new System.Windows.Forms.Button();
            this.LoginClearbutton = new System.Windows.Forms.Button();
            this.LoginCancelbutton = new System.Windows.Forms.Button();
            this.LoginServeAddressrcomboBox = new System.Windows.Forms.ComboBox();
            this.LoginServerNamecomboBox = new System.Windows.Forms.ComboBox();
            this.LoginServerPasswordcomboBox = new System.Windows.Forms.ComboBox();
            this.LoginServerPortcomboBox = new System.Windows.Forms.ComboBox();
            this.LoginServerCharactersDBcomboBox = new System.Windows.Forms.ComboBox();
            this.LoginServerWorldDBcomboBox = new System.Windows.Forms.ComboBox();
            this.LoginServerRealmdDBcomboBox = new System.Windows.Forms.ComboBox();
            this.ConnectMySQLLogingroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectMySQLLogingroupBox
            // 
            this.ConnectMySQLLogingroupBox.BackgroundImage = global::I_Quice.Properties.Resources.InfinityLogin;
            this.ConnectMySQLLogingroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConnectMySQLLogingroupBox.Controls.Add(this.LoginServerRealmdDBcomboBox);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.LoginServerWorldDBcomboBox);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.LoginServerCharactersDBcomboBox);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.LoginServerPortcomboBox);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.LoginServerPasswordcomboBox);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.LoginServerNamecomboBox);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.LoginServeAddressrcomboBox);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.LoginCancelbutton);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.LoginClearbutton);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.LoginConnectbutton);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.Portlabel);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.Realmdlabel);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.Worldlabel);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.Characterslabel);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.passwordLabel);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.UserNamelabel);
            this.ConnectMySQLLogingroupBox.Controls.Add(this.Serverlabel);
            this.ConnectMySQLLogingroupBox.Location = new System.Drawing.Point(12, 12);
            this.ConnectMySQLLogingroupBox.Name = "ConnectMySQLLogingroupBox";
            this.ConnectMySQLLogingroupBox.Size = new System.Drawing.Size(486, 330);
            this.ConnectMySQLLogingroupBox.TabIndex = 0;
            this.ConnectMySQLLogingroupBox.TabStop = false;
            this.ConnectMySQLLogingroupBox.Text = ":Connect to MySQL Server:";
            // 
            // Portlabel
            // 
            this.Portlabel.AutoSize = true;
            this.Portlabel.Location = new System.Drawing.Point(345, 62);
            this.Portlabel.Name = "Portlabel";
            this.Portlabel.Size = new System.Drawing.Size(29, 13);
            this.Portlabel.TabIndex = 6;
            this.Portlabel.Text = "Port:";
            // 
            // Realmdlabel
            // 
            this.Realmdlabel.AutoSize = true;
            this.Realmdlabel.Location = new System.Drawing.Point(345, 234);
            this.Realmdlabel.Name = "Realmdlabel";
            this.Realmdlabel.Size = new System.Drawing.Size(64, 13);
            this.Realmdlabel.TabIndex = 5;
            this.Realmdlabel.Text = "Realmd DB:";
            // 
            // Worldlabel
            // 
            this.Worldlabel.AutoSize = true;
            this.Worldlabel.Location = new System.Drawing.Point(345, 182);
            this.Worldlabel.Name = "Worldlabel";
            this.Worldlabel.Size = new System.Drawing.Size(56, 13);
            this.Worldlabel.TabIndex = 4;
            this.Worldlabel.Text = "World DB:";
            // 
            // Characterslabel
            // 
            this.Characterslabel.AutoSize = true;
            this.Characterslabel.Location = new System.Drawing.Point(345, 119);
            this.Characterslabel.Name = "Characterslabel";
            this.Characterslabel.Size = new System.Drawing.Size(79, 13);
            this.Characterslabel.TabIndex = 3;
            this.Characterslabel.Text = "Characters DB:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(30, 182);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.Location = new System.Drawing.Point(30, 119);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(63, 13);
            this.UserNamelabel.TabIndex = 1;
            this.UserNamelabel.Text = "User Name:";
            // 
            // Serverlabel
            // 
            this.Serverlabel.AutoSize = true;
            this.Serverlabel.Location = new System.Drawing.Point(30, 62);
            this.Serverlabel.Name = "Serverlabel";
            this.Serverlabel.Size = new System.Drawing.Size(41, 13);
            this.Serverlabel.TabIndex = 0;
            this.Serverlabel.Text = "Server:";
            // 
            // LoginConnectbutton
            // 
            this.LoginConnectbutton.Location = new System.Drawing.Point(33, 291);
            this.LoginConnectbutton.Name = "LoginConnectbutton";
            this.LoginConnectbutton.Size = new System.Drawing.Size(75, 23);
            this.LoginConnectbutton.TabIndex = 8;
            this.LoginConnectbutton.Text = "&Connect";
            this.LoginConnectbutton.UseVisualStyleBackColor = true;
            // 
            // LoginClearbutton
            // 
            this.LoginClearbutton.Location = new System.Drawing.Point(114, 291);
            this.LoginClearbutton.Name = "LoginClearbutton";
            this.LoginClearbutton.Size = new System.Drawing.Size(75, 23);
            this.LoginClearbutton.TabIndex = 9;
            this.LoginClearbutton.Text = "C&lear";
            this.LoginClearbutton.UseVisualStyleBackColor = true;
            // 
            // LoginCancelbutton
            // 
            this.LoginCancelbutton.Location = new System.Drawing.Point(195, 291);
            this.LoginCancelbutton.Name = "LoginCancelbutton";
            this.LoginCancelbutton.Size = new System.Drawing.Size(75, 23);
            this.LoginCancelbutton.TabIndex = 10;
            this.LoginCancelbutton.Text = "C&ancel";
            this.LoginCancelbutton.UseVisualStyleBackColor = true;
            // 
            // LoginServeAddressrcomboBox
            // 
            this.LoginServeAddressrcomboBox.FormattingEnabled = true;
            this.LoginServeAddressrcomboBox.Location = new System.Drawing.Point(33, 79);
            this.LoginServeAddressrcomboBox.Name = "LoginServeAddressrcomboBox";
            this.LoginServeAddressrcomboBox.Size = new System.Drawing.Size(121, 21);
            this.LoginServeAddressrcomboBox.TabIndex = 1;
            // 
            // LoginServerNamecomboBox
            // 
            this.LoginServerNamecomboBox.FormattingEnabled = true;
            this.LoginServerNamecomboBox.Location = new System.Drawing.Point(33, 135);
            this.LoginServerNamecomboBox.Name = "LoginServerNamecomboBox";
            this.LoginServerNamecomboBox.Size = new System.Drawing.Size(121, 21);
            this.LoginServerNamecomboBox.TabIndex = 2;
            // 
            // LoginServerPasswordcomboBox
            // 
            this.LoginServerPasswordcomboBox.FormattingEnabled = true;
            this.LoginServerPasswordcomboBox.Location = new System.Drawing.Point(33, 198);
            this.LoginServerPasswordcomboBox.Name = "LoginServerPasswordcomboBox";
            this.LoginServerPasswordcomboBox.Size = new System.Drawing.Size(121, 21);
            this.LoginServerPasswordcomboBox.TabIndex = 3;
            // 
            // LoginServerPortcomboBox
            // 
            this.LoginServerPortcomboBox.FormattingEnabled = true;
            this.LoginServerPortcomboBox.Location = new System.Drawing.Point(348, 79);
            this.LoginServerPortcomboBox.Name = "LoginServerPortcomboBox";
            this.LoginServerPortcomboBox.Size = new System.Drawing.Size(121, 21);
            this.LoginServerPortcomboBox.TabIndex = 4;
            // 
            // LoginServerCharactersDBcomboBox
            // 
            this.LoginServerCharactersDBcomboBox.FormattingEnabled = true;
            this.LoginServerCharactersDBcomboBox.Location = new System.Drawing.Point(348, 135);
            this.LoginServerCharactersDBcomboBox.Name = "LoginServerCharactersDBcomboBox";
            this.LoginServerCharactersDBcomboBox.Size = new System.Drawing.Size(121, 21);
            this.LoginServerCharactersDBcomboBox.TabIndex = 5;
            // 
            // LoginServerWorldDBcomboBox
            // 
            this.LoginServerWorldDBcomboBox.FormattingEnabled = true;
            this.LoginServerWorldDBcomboBox.Location = new System.Drawing.Point(348, 198);
            this.LoginServerWorldDBcomboBox.Name = "LoginServerWorldDBcomboBox";
            this.LoginServerWorldDBcomboBox.Size = new System.Drawing.Size(121, 21);
            this.LoginServerWorldDBcomboBox.TabIndex = 6;
            // 
            // LoginServerRealmdDBcomboBox
            // 
            this.LoginServerRealmdDBcomboBox.FormattingEnabled = true;
            this.LoginServerRealmdDBcomboBox.Location = new System.Drawing.Point(348, 250);
            this.LoginServerRealmdDBcomboBox.Name = "LoginServerRealmdDBcomboBox";
            this.LoginServerRealmdDBcomboBox.Size = new System.Drawing.Size(121, 21);
            this.LoginServerRealmdDBcomboBox.TabIndex = 7;
            // 
            // LoginSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(512, 356);
            this.Controls.Add(this.ConnectMySQLLogingroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ConnectMySQLLogingroupBox.ResumeLayout(false);
            this.ConnectMySQLLogingroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ConnectMySQLLogingroupBox;
        private System.Windows.Forms.Label Portlabel;
        private System.Windows.Forms.Label Realmdlabel;
        private System.Windows.Forms.Label Worldlabel;
        private System.Windows.Forms.Label Characterslabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.Label Serverlabel;
        private System.Windows.Forms.ComboBox LoginServerRealmdDBcomboBox;
        private System.Windows.Forms.ComboBox LoginServerWorldDBcomboBox;
        private System.Windows.Forms.ComboBox LoginServerCharactersDBcomboBox;
        private System.Windows.Forms.ComboBox LoginServerPortcomboBox;
        private System.Windows.Forms.ComboBox LoginServerPasswordcomboBox;
        private System.Windows.Forms.ComboBox LoginServerNamecomboBox;
        private System.Windows.Forms.ComboBox LoginServeAddressrcomboBox;
        private System.Windows.Forms.Button LoginCancelbutton;
        private System.Windows.Forms.Button LoginClearbutton;
        private System.Windows.Forms.Button LoginConnectbutton;
    }
}