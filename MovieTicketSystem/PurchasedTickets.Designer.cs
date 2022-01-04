
namespace MovieTicketSystem
{
    partial class PurchasedTickets
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.PurchasedTicketsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasedTicketsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prevPageButton
            // 
            this.prevPageButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.prevPageButton.Location = new System.Drawing.Point(36, 30);
            this.prevPageButton.Margin = new System.Windows.Forms.Padding(2);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(38, 35);
            this.prevPageButton.TabIndex = 0;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = false;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(366, 159);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(104, 13);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search by Movie ID:";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(478, 155);
            this.searchText.Margin = new System.Windows.Forms.Padding(2);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(106, 20);
            this.searchText.TabIndex = 2;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // PurchasedTicketsDataGridView
            // 
            this.PurchasedTicketsDataGridView.AllowUserToAddRows = false;
            this.PurchasedTicketsDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.PurchasedTicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchasedTicketsDataGridView.Location = new System.Drawing.Point(218, 220);
            this.PurchasedTicketsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.PurchasedTicketsDataGridView.Name = "PurchasedTicketsDataGridView";
            this.PurchasedTicketsDataGridView.RowHeadersWidth = 51;
            this.PurchasedTicketsDataGridView.RowTemplate.Height = 24;
            this.PurchasedTicketsDataGridView.Size = new System.Drawing.Size(494, 163);
            this.PurchasedTicketsDataGridView.TabIndex = 3;
            // 
            // PurchasedTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 522);
            this.Controls.Add(this.PurchasedTicketsDataGridView);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.prevPageButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PurchasedTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchased Tickets";
            this.Load += new System.EventHandler(this.PurchasedTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchasedTicketsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prevPageButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.DataGridView PurchasedTicketsDataGridView;
    }
}