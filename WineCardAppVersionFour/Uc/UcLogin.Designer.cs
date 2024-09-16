namespace WineCardAppVersionFour.Uc
{
    partial class UcLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelLogin = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 20F);
            labelLogin.Location = new Point(27, 16);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(173, 46);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Anmelden";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(27, 95);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(104, 20);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Benutzername";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(27, 128);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(66, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Passwort";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(150, 92);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(125, 27);
            textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(150, 125);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(125, 27);
            textBoxPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(181, 170);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Anmelden";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // UcLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelLogin);
            Name = "UcLogin";
            Size = new Size(1319, 651);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
    }
}
