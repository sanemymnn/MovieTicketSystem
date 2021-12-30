
namespace MovieTicketSystem
{
    partial class AdminDisplayMovie
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
            this.MovieDataGridView = new System.Windows.Forms.DataGridView();
            this.prevPageButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieDataGridView
            // 
            this.MovieDataGridView.AllowUserToAddRows = false;
            this.MovieDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MovieDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.MovieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieDataGridView.ColumnHeadersVisible = false;
            this.MovieDataGridView.Location = new System.Drawing.Point(27, 158);
            this.MovieDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieDataGridView.Name = "MovieDataGridView";
            this.MovieDataGridView.RowHeadersWidth = 51;
            this.MovieDataGridView.RowTemplate.Height = 24;
            this.MovieDataGridView.Size = new System.Drawing.Size(1177, 150);
            this.MovieDataGridView.TabIndex = 3;
            this.MovieDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieDataGridView_CellContentClick);
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(27, 30);
            this.prevPageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(65, 25);
            this.prevPageButton.TabIndex = 1;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(491, 82);
            this.searchText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(116, 22);
            this.searchText.TabIndex = 2;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(160, 86);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(76, 17);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Search by:";
            // 
            // searchComboBox
            // 
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Start Time",
            "Place"});
            this.searchComboBox.Location = new System.Drawing.Point(309, 82);
            this.searchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(151, 24);
            this.searchComboBox.TabIndex = 8;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(736, 80);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(102, 17);
            this.filterLabel.TabIndex = 5;
            this.filterLabel.Text = "Filter by Status";
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Available",
            "Non-available",
            "All"});
            this.filterComboBox.Location = new System.Drawing.Point(844, 80);
            this.filterComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(151, 24);
            this.filterComboBox.TabIndex = 5;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // AdminDisplayMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 438);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.prevPageButton);
            this.Controls.Add(this.MovieDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminDisplayMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display/Search/Filter Movies";
            this.Load += new System.EventHandler(this.adminDisplayMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MovieDataGridView;
        private System.Windows.Forms.Button prevPageButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
    }
}