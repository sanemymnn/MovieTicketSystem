
namespace MovieTicketSystem
{
    partial class CustomerMenu
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
            this.PurchasedTicketsButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.DisplayMovieTicketButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PurchasedTicketsButton
            // 
            this.PurchasedTicketsButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PurchasedTicketsButton.Location = new System.Drawing.Point(524, 210);
            this.PurchasedTicketsButton.Name = "PurchasedTicketsButton";
            this.PurchasedTicketsButton.Size = new System.Drawing.Size(143, 78);
            this.PurchasedTicketsButton.TabIndex = 0;
            this.PurchasedTicketsButton.Text = "Purchased Tickets";
            this.PurchasedTicketsButton.UseVisualStyleBackColor = false;
            this.PurchasedTicketsButton.Click += new System.EventHandler(this.PurchasedTicketsButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.SystemColors.Window;
            this.LogoutButton.Location = new System.Drawing.Point(807, 435);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(86, 42);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DisplayMovieTicketButton
            // 
            this.DisplayMovieTicketButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DisplayMovieTicketButton.Location = new System.Drawing.Point(289, 210);
            this.DisplayMovieTicketButton.Name = "DisplayMovieTicketButton";
            this.DisplayMovieTicketButton.Size = new System.Drawing.Size(143, 78);
            this.DisplayMovieTicketButton.TabIndex = 2;
            this.DisplayMovieTicketButton.Text = "Display movies and buy tickets";
            this.DisplayMovieTicketButton.UseVisualStyleBackColor = false;
            this.DisplayMovieTicketButton.Click += new System.EventHandler(this.DisplayMovieTicketButton_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 522);
            this.Controls.Add(this.DisplayMovieTicketButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.PurchasedTicketsButton);
            this.Name = "CustomerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PurchasedTicketsButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button DisplayMovieTicketButton;
    }
}