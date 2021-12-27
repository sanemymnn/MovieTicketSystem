
namespace MovieTicketSystem
{
    partial class CustomerDisplayMovie
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
            this.displayMovieDataGridView = new System.Windows.Forms.DataGridView();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayMovieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(36, 35);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(59, 38);
            this.prevPageButton.TabIndex = 0;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // displayMovieDataGridView
            // 
            this.displayMovieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayMovieDataGridView.Location = new System.Drawing.Point(63, 222);
            this.displayMovieDataGridView.Name = "displayMovieDataGridView";
            this.displayMovieDataGridView.RowHeadersWidth = 51;
            this.displayMovieDataGridView.RowTemplate.Height = 24;
            this.displayMovieDataGridView.Size = new System.Drawing.Size(589, 150);
            this.displayMovieDataGridView.TabIndex = 1;
            this.displayMovieDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayMovieDataGridView_CellContentClick);
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(217, 118);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(121, 24);
            this.searchComboBox.TabIndex = 3;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(137, 121);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(57, 17);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Search:";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(344, 118);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(100, 22);
            this.searchText.TabIndex = 5;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(505, 122);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(107, 17);
            this.filterLabel.TabIndex = 6;
            this.filterLabel.Text = "Filter Status By:";
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(618, 118);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(121, 24);
            this.filterComboBox.TabIndex = 7;
            // 
            // CustomerDisplayMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.displayMovieDataGridView);
            this.Controls.Add(this.prevPageButton);
            this.Name = "CustomerDisplayMovie";
            this.Text = "CustomerDisplayMovie";
            ((System.ComponentModel.ISupportInitialize)(this.displayMovieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prevPageButton;
        private System.Windows.Forms.DataGridView displayMovieDataGridView;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
    }
}