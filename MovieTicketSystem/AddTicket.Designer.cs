
namespace MovieTicketSystem
{
    partial class AddTicket
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
            this.prevPageButton = new System.Windows.Forms.Button();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.ticketIdLabel = new System.Windows.Forms.Label();
            this.movieIdLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.ticketIdText = new System.Windows.Forms.TextBox();
            this.movieIdText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.ticketPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ticketPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(32, 35);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(75, 23);
            this.prevPageButton.TabIndex = 0;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // addTicketButton
            // 
            this.addTicketButton.Location = new System.Drawing.Point(219, 352);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(142, 23);
            this.addTicketButton.TabIndex = 1;
            this.addTicketButton.Text = "Add Ticket";
            this.addTicketButton.UseVisualStyleBackColor = true;
            this.addTicketButton.Click += new System.EventHandler(this.addTicketButton_Click);
            // 
            // ticketIdLabel
            // 
            this.ticketIdLabel.AutoSize = true;
            this.ticketIdLabel.Location = new System.Drawing.Point(113, 127);
            this.ticketIdLabel.Name = "ticketIdLabel";
            this.ticketIdLabel.Size = new System.Drawing.Size(67, 17);
            this.ticketIdLabel.TabIndex = 2;
            this.ticketIdLabel.Text = "Ticket ID:";
            // 
            // movieIdLabel
            // 
            this.movieIdLabel.AutoSize = true;
            this.movieIdLabel.Location = new System.Drawing.Point(113, 171);
            this.movieIdLabel.Name = "movieIdLabel";
            this.movieIdLabel.Size = new System.Drawing.Size(66, 17);
            this.movieIdLabel.TabIndex = 3;
            this.movieIdLabel.Text = "Movie ID:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(113, 213);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(94, 17);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Ticket Status:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(113, 260);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(86, 17);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Ticket Price:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Available",
            "Non-Available"});
            this.statusComboBox.Location = new System.Drawing.Point(261, 210);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(110, 24);
            this.statusComboBox.TabIndex = 12;
            // 
            // ticketIdText
            // 
            this.ticketIdText.Location = new System.Drawing.Point(261, 124);
            this.ticketIdText.Name = "ticketIdText";
            this.ticketIdText.Size = new System.Drawing.Size(100, 22);
            this.ticketIdText.TabIndex = 7;
            this.ticketIdText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // movieIdText
            // 
            this.movieIdText.Location = new System.Drawing.Point(261, 166);
            this.movieIdText.Name = "movieIdText";
            this.movieIdText.Size = new System.Drawing.Size(100, 22);
            this.movieIdText.TabIndex = 8;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(261, 257);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(100, 22);
            this.priceText.TabIndex = 9;
            // 
            // ticketPicture
            // 
            this.ticketPicture.Location = new System.Drawing.Point(449, 71);
            this.ticketPicture.Name = "ticketPicture";
            this.ticketPicture.Size = new System.Drawing.Size(265, 315);
            this.ticketPicture.TabIndex = 10;
            this.ticketPicture.TabStop = false;
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ticketPicture);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.movieIdText);
            this.Controls.Add(this.ticketIdText);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.movieIdLabel);
            this.Controls.Add(this.ticketIdLabel);
            this.Controls.Add(this.addTicketButton);
            this.Controls.Add(this.prevPageButton);
            this.Name = "AddTicket";
            this.Text = "Add Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ticketPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prevPageButton;
        private System.Windows.Forms.Button addTicketButton;
        private System.Windows.Forms.Label ticketIdLabel;
        private System.Windows.Forms.Label movieIdLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox ticketIdText;
        private System.Windows.Forms.TextBox movieIdText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.PictureBox ticketPicture;
    }
}