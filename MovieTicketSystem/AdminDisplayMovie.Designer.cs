
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
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieDataGridView
            // 
            this.MovieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieDataGridView.Location = new System.Drawing.Point(0, 129);
            this.MovieDataGridView.Name = "MovieDataGridView";
            this.MovieDataGridView.RowHeadersWidth = 51;
            this.MovieDataGridView.RowTemplate.Height = 24;
            this.MovieDataGridView.Size = new System.Drawing.Size(800, 150);
            this.MovieDataGridView.TabIndex = 0;
            this.MovieDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieDataGridView_CellContentClick);
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(27, 37);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(65, 31);
            this.prevPageButton.TabIndex = 1;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(288, 75);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(100, 22);
            this.searchText.TabIndex = 2;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(89, 83);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(57, 17);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Search:";
            // 
            // searchComboBox
            // 
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(161, 76);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(121, 24);
            this.searchComboBox.TabIndex = 4;
            // 
            // AdminDisplayMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.prevPageButton);
            this.Controls.Add(this.MovieDataGridView);
            this.Name = "AdminDisplayMovie";
            this.Text = "AdminDisplayMovie";
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
    }
}