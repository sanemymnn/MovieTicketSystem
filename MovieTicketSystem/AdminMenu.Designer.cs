
namespace MovieTicketSystem
{
    partial class AdminMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.addMovieButton = new System.Windows.Forms.Button();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DispSearchFilterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMovieButton
            // 
            this.addMovieButton.ForeColor = System.Drawing.Color.Chocolate;
            this.addMovieButton.Location = new System.Drawing.Point(210, 186);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addMovieButton.Size = new System.Drawing.Size(109, 41);
            this.addMovieButton.TabIndex = 0;
            this.addMovieButton.Text = "Add Movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // addTicketButton
            // 
            this.addTicketButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.addTicketButton.Location = new System.Drawing.Point(471, 186);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(107, 41);
            this.addTicketButton.TabIndex = 1;
            this.addTicketButton.Text = "Add Ticket";
            this.addTicketButton.UseVisualStyleBackColor = true;
            this.addTicketButton.Click += new System.EventHandler(this.AddTicketButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(701, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log out ->";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DispSearchFilterButton
            // 
            this.DispSearchFilterButton.Location = new System.Drawing.Point(357, 288);
            this.DispSearchFilterButton.Name = "DispSearchFilterButton";
            this.DispSearchFilterButton.Size = new System.Drawing.Size(100, 50);
            this.DispSearchFilterButton.TabIndex = 3;
            this.DispSearchFilterButton.Text = "Display movies and tickets";
            this.DispSearchFilterButton.UseVisualStyleBackColor = true;
            this.DispSearchFilterButton.Click += new System.EventHandler(this.DispSearchFilterButton_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DispSearchFilterButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addTicketButton);
            this.Controls.Add(this.addMovieButton);
            this.Name = "AdminMenu";
            this.Text = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Button addTicketButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DispSearchFilterButton;
    }
}

