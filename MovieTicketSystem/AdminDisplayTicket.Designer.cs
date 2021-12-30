
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
            this.prevPageButton.Location = new System.Drawing.Point(51, 35);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(51, 36);
            this.prevPageButton.TabIndex = 0;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // TicketDataGridView
            // 
            this.TicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDataGridView.Location = new System.Drawing.Point(105, 170);
            this.TicketDataGridView.Name = "TicketDataGridView";
            this.TicketDataGridView.RowHeadersWidth = 51;
            this.TicketDataGridView.RowTemplate.Height = 24;
            this.TicketDataGridView.Size = new System.Drawing.Size(552, 202);
            this.TicketDataGridView.TabIndex = 1;
            this.TicketDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketDataGridView_CellContentClick);
            // 
            // ticketInfoText
            // 
            this.ticketInfoText.Location = new System.Drawing.Point(424, 107);
            this.ticketInfoText.Name = "ticketInfoText";
            this.ticketInfoText.Size = new System.Drawing.Size(148, 22);
            this.ticketInfoText.TabIndex = 2;
            // 
            // AdminDisplayTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ticketInfoText);
            this.Controls.Add(this.TicketDataGridView);
            this.Controls.Add(this.prevPageButton);
            this.Name = "AdminDisplayTicket";
            this.Text = "AdminDisplayTicket";
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