
namespace MovieTicketSystem
{
    partial class CustomerDisplayTicket
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
            this.ticketAmountText = new System.Windows.Forms.TextBox();
            this.DisplayTicketDataGridView = new System.Windows.Forms.DataGridView();
            this.prevPageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayTicketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketAmountText
            // 
            this.ticketAmountText.Location = new System.Drawing.Point(313, 96);
            this.ticketAmountText.Name = "ticketAmountText";
            this.ticketAmountText.Size = new System.Drawing.Size(148, 20);
            this.ticketAmountText.TabIndex = 0;
            this.ticketAmountText.TextChanged += new System.EventHandler(this.ticketAmountText_TextChanged);
            // 
            // DisplayTicketDataGridView
            // 
            this.DisplayTicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayTicketDataGridView.Location = new System.Drawing.Point(219, 185);
            this.DisplayTicketDataGridView.Name = "DisplayTicketDataGridView";
            this.DisplayTicketDataGridView.Size = new System.Drawing.Size(348, 181);
            this.DisplayTicketDataGridView.TabIndex = 1;
            this.DisplayTicketDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayTicketDataGridView_CellContentClick);
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(34, 35);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(24, 23);
            this.prevPageButton.TabIndex = 2;
            this.prevPageButton.Text = "<--";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // CustomerDisplayTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prevPageButton);
            this.Controls.Add(this.DisplayTicketDataGridView);
            this.Controls.Add(this.ticketAmountText);
            this.Name = "CustomerDisplayTicket";
            this.Text = "CustomerDisplayTicket";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayTicketDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox ticketAmountText;
        public System.Windows.Forms.DataGridView DisplayTicketDataGridView;
        private System.Windows.Forms.Button prevPageButton;
    }
}