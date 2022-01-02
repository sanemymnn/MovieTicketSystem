
namespace MovieTicketSystem
{
    partial class AdminDisplayTicket
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
            this.TicketDataGridView = new System.Windows.Forms.DataGridView();
            this.ticketInfoText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(76, 40);
            this.prevPageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(29, 23);
            this.prevPageButton.TabIndex = 0;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // TicketDataGridView
            // 
            this.TicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDataGridView.Location = new System.Drawing.Point(76, 153);
            this.TicketDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TicketDataGridView.Name = "TicketDataGridView";
            this.TicketDataGridView.RowHeadersWidth = 51;
            this.TicketDataGridView.RowTemplate.Height = 24;
            this.TicketDataGridView.Size = new System.Drawing.Size(645, 164);
            this.TicketDataGridView.TabIndex = 2;
            this.TicketDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketDataGridView_CellContentClick);
            // 
            // ticketInfoText
            // 
            this.ticketInfoText.Location = new System.Drawing.Point(318, 87);
            this.ticketInfoText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ticketInfoText.Name = "ticketInfoText";
            this.ticketInfoText.Size = new System.Drawing.Size(112, 20);
            this.ticketInfoText.TabIndex = 2;
            // 
            // AdminDisplayTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 435);
            this.Controls.Add(this.ticketInfoText);
            this.Controls.Add(this.TicketDataGridView);
            this.Controls.Add(this.prevPageButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminDisplayTicket";
            this.Text = "Ticket Info";
            this.Load += new System.EventHandler(this.TicketInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prevPageButton;
        public System.Windows.Forms.DataGridView TicketDataGridView;
        public System.Windows.Forms.TextBox ticketInfoText;
    }
}