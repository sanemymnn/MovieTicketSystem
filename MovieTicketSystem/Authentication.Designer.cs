
namespace MovieTicketSystem
{
    partial class Authentication
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
            this.adminLogin = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.LinkLabel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminLogin
            // 
            this.adminLogin.BackColor = System.Drawing.SystemColors.Info;
            this.adminLogin.Location = new System.Drawing.Point(589, 219);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(75, 23);
            this.adminLogin.TabIndex = 0;
            this.adminLogin.Text = "Admin Login";
            this.adminLogin.UseVisualStyleBackColor = false;
            this.adminLogin.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.Info;
            this.login.Location = new System.Drawing.Point(589, 248);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 1;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(402, 207);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(152, 20);
            this.usernameText.TabIndex = 2;
            this.usernameText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(402, 272);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(152, 20);
            this.passwordText.TabIndex = 3;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(325, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(326, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // Register
            // 
            this.Register.ActiveLinkColor = System.Drawing.Color.Tomato;
            this.Register.AutoSize = true;
            this.Register.LinkColor = System.Drawing.Color.Purple;
            this.Register.Location = new System.Drawing.Point(448, 348);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(46, 13);
            this.Register.TabIndex = 6;
            this.Register.TabStop = true;
            this.Register.Text = "Register";
            this.Register.VisitedLinkColor = System.Drawing.Color.Purple;
            this.Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_LinkClicked);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(867, 31);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(27, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 522);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.login);
            this.Controls.Add(this.adminLogin);
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminLogin;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Register;
        private System.Windows.Forms.Button ExitButton;
    }
}