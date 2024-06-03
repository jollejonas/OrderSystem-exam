namespace OrderSystem
{
    partial class StartView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameText = new TextBox();
            passwordText = new TextBox();
            usernameLbl = new Label();
            passwordLbl = new Label();
            loginBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // usernameText
            // 
            usernameText.Location = new Point(210, 140);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(156, 23);
            usernameText.TabIndex = 0;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(210, 190);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(156, 23);
            passwordText.TabIndex = 1;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Location = new Point(210, 120);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(68, 15);
            usernameLbl.TabIndex = 2;
            usernameLbl.Text = "Brugernavn";
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(210, 170);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(57, 15);
            passwordLbl.TabIndex = 3;
            passwordLbl.Text = "Password";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(210, 218);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(290, 218);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 23);
            closeBtn.TabIndex = 5;
            closeBtn.Text = "Luk";
            closeBtn.UseVisualStyleBackColor = true;
            // 
            // StartView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 450);
            Controls.Add(closeBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordLbl);
            Controls.Add(usernameLbl);
            Controls.Add(passwordText);
            Controls.Add(usernameText);
            Name = "StartView";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameText;
        private TextBox passwordText;
        private Label usernameLbl;
        private Label passwordLbl;
        private Button loginBtn;
        private Button closeBtn;
    }
}
