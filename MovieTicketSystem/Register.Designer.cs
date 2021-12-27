
namespace MovieTicketSystem
{
    partial class registerPicture
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.sunameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.ageText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.prevPageButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(190, 89);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(190, 139);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(189, 254);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // sunameLabel
            // 
            this.sunameLabel.AutoSize = true;
            this.sunameLabel.Location = new System.Drawing.Point(189, 197);
            this.sunameLabel.Name = "sunameLabel";
            this.sunameLabel.Size = new System.Drawing.Size(65, 17);
            this.sunameLabel.TabIndex = 3;
            this.sunameLabel.Text = "Surname";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(190, 304);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(33, 17);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Age";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(321, 368);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(81, 30);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click_1);
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(312, 89);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(100, 22);
            this.usernameText.TabIndex = 6;
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(312, 304);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(100, 22);
            this.ageText.TabIndex = 8;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(312, 254);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(100, 22);
            this.passwordText.TabIndex = 9;
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(312, 199);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(100, 22);
            this.surnameText.TabIndex = 10;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(312, 139);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 22);
            this.nameText.TabIndex = 11;
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(28, 27);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(68, 24);
            this.prevPageButton.TabIndex = 12;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(534, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(232, 397);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // registerPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.prevPageButton);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.sunameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "registerPicture";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label sunameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button prevPageButton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}