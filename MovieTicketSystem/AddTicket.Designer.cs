
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
            this.SuspendLayout();
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(24, 28);
            this.prevPageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(41, 32);
            this.prevPageButton.TabIndex = 0;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // addTicketButton
            // 
            this.addTicketButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.addTicketButton.Location = new System.Drawing.Point(298, 262);
            this.addTicketButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(86, 34);
            this.addTicketButton.TabIndex = 1;
            this.addTicketButton.Text = "Add Ticket";
            this.addTicketButton.UseVisualStyleBackColor = false;
            this.addTicketButton.Click += new System.EventHandler(this.addTicketButton_Click);
            // 
            // ticketIdLabel
            // 
            this.ticketIdLabel.AutoSize = true;
            this.ticketIdLabel.Location = new System.Drawing.Point(187, 103);
            this.ticketIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ticketIdLabel.Name = "ticketIdLabel";
            this.ticketIdLabel.Size = new System.Drawing.Size(54, 13);
            this.ticketIdLabel.TabIndex = 2;
            this.ticketIdLabel.Text = "Ticket ID:";
            // 
            // movieIdLabel
            // 
            this.movieIdLabel.AutoSize = true;
            this.movieIdLabel.Location = new System.Drawing.Point(187, 139);
            this.movieIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieIdLabel.Name = "movieIdLabel";
            this.movieIdLabel.Size = new System.Drawing.Size(53, 13);
            this.movieIdLabel.TabIndex = 3;
            this.movieIdLabel.Text = "Movie ID:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(187, 173);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(73, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Ticket Status:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(187, 211);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(67, 13);
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
            this.statusComboBox.Location = new System.Drawing.Point(298, 171);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(86, 21);
            this.statusComboBox.TabIndex = 12;
            // 
            // ticketIdText
            // 
            this.ticketIdText.Location = new System.Drawing.Point(298, 101);
            this.ticketIdText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ticketIdText.Name = "ticketIdText";
            this.ticketIdText.Size = new System.Drawing.Size(86, 20);
            this.ticketIdText.TabIndex = 7;
            this.ticketIdText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // movieIdText
            // 
            this.movieIdText.Location = new System.Drawing.Point(298, 135);
            this.movieIdText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.movieIdText.Name = "movieIdText";
            this.movieIdText.Size = new System.Drawing.Size(86, 20);
            this.movieIdText.TabIndex = 8;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(298, 209);
            this.priceText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(86, 20);
            this.priceText.TabIndex = 9;
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Ticket";
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
    }
}