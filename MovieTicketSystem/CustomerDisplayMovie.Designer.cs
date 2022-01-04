
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
            this.prevPageButton.Location = new System.Drawing.Point(37, 34);
            this.prevPageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(44, 31);
            this.prevPageButton.TabIndex = 0;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // displayMovieDataGridView
            // 
            this.displayMovieDataGridView.AllowUserToAddRows = false;
            this.displayMovieDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.displayMovieDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.displayMovieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayMovieDataGridView.Location = new System.Drawing.Point(175, 237);
            this.displayMovieDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayMovieDataGridView.Name = "displayMovieDataGridView";
            this.displayMovieDataGridView.RowHeadersWidth = 51;
            this.displayMovieDataGridView.RowTemplate.Height = 24;
            this.displayMovieDataGridView.Size = new System.Drawing.Size(586, 176);
            this.displayMovieDataGridView.TabIndex = 1;
            this.displayMovieDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayMovieDataGridView_CellContentClick);
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Start Time",
            "Place"});
            this.searchComboBox.Location = new System.Drawing.Point(271, 158);
            this.searchComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(92, 21);
            this.searchComboBox.TabIndex = 3;
            this.searchComboBox.SelectedIndexChanged += new System.EventHandler(this.searchComboBox_SelectedIndexChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(211, 160);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(44, 13);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Search:";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(366, 158);
            this.searchText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(76, 20);
            this.searchText.TabIndex = 5;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(487, 161);
            this.filterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(80, 13);
            this.filterLabel.TabIndex = 6;
            this.filterLabel.Text = "Filter Status By:";
            // 
            // filterComboBox
            // 
            this.filterComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Available",
            "Non-available",
            "All"});
            this.filterComboBox.Location = new System.Drawing.Point(572, 158);
            this.filterComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(151, 21);
            this.filterComboBox.TabIndex = 5;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // CustomerDisplayMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 522);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.displayMovieDataGridView);
            this.Controls.Add(this.prevPageButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerDisplayMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display/Search/Filter Movies";
            this.Load += new System.EventHandler(this.DisplayMovie_Load);
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