
namespace MovieTicketSystem
{
    partial class AddMovie
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
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.Label();
            this.movieTheater = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.startTimeText = new System.Windows.Forms.TextBox();
            this.movieTheaterText = new System.Windows.Forms.TextBox();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.movieCapacityLabel = new System.Windows.Forms.Label();
            this.movieStatusLabel = new System.Windows.Forms.Label();
            this.capacityText = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id.Location = new System.Drawing.Point(263, 63);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(24, 13);
            this.id.TabIndex = 0;
            this.id.Text = "ID:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.Location = new System.Drawing.Point(263, 109);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(43, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Name:";
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startTime.Location = new System.Drawing.Point(263, 155);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(69, 13);
            this.startTime.TabIndex = 2;
            this.startTime.Text = "Start Time:";
            // 
            // movieTheater
            // 
            this.movieTheater.AutoSize = true;
            this.movieTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movieTheater.Location = new System.Drawing.Point(263, 203);
            this.movieTheater.Name = "movieTheater";
            this.movieTheater.Size = new System.Drawing.Size(93, 13);
            this.movieTheater.TabIndex = 3;
            this.movieTheater.Text = "Movie Theater:";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(385, 63);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 4;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(385, 106);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 5;
            // 
            // startTimeText
            // 
            this.startTimeText.Location = new System.Drawing.Point(385, 152);
            this.startTimeText.Name = "startTimeText";
            this.startTimeText.Size = new System.Drawing.Size(100, 20);
            this.startTimeText.TabIndex = 6;
            // 
            // movieTheaterText
            // 
            this.movieTheaterText.Location = new System.Drawing.Point(385, 200);
            this.movieTheaterText.Name = "movieTheaterText";
            this.movieTheaterText.Size = new System.Drawing.Size(100, 20);
            this.movieTheaterText.TabIndex = 7;
            // 
            // addMovieButton
            // 
            this.addMovieButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.addMovieButton.Location = new System.Drawing.Point(402, 344);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(83, 37);
            this.addMovieButton.TabIndex = 8;
            this.addMovieButton.Text = "Add Movie";
            this.addMovieButton.UseVisualStyleBackColor = false;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // previousPageButton
            // 
            this.previousPageButton.Location = new System.Drawing.Point(25, 26);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(40, 36);
            this.previousPageButton.TabIndex = 9;
            this.previousPageButton.Text = "<";
            this.previousPageButton.UseVisualStyleBackColor = true;
            this.previousPageButton.Click += new System.EventHandler(this.previousPageButton_Click);
            // 
            // movieCapacityLabel
            // 
            this.movieCapacityLabel.AutoSize = true;
            this.movieCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movieCapacityLabel.Location = new System.Drawing.Point(263, 252);
            this.movieCapacityLabel.Name = "movieCapacityLabel";
            this.movieCapacityLabel.Size = new System.Drawing.Size(98, 13);
            this.movieCapacityLabel.TabIndex = 10;
            this.movieCapacityLabel.Text = "Movie Capacity:";
            // 
            // movieStatusLabel
            // 
            this.movieStatusLabel.AutoSize = true;
            this.movieStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movieStatusLabel.Location = new System.Drawing.Point(263, 304);
            this.movieStatusLabel.Name = "movieStatusLabel";
            this.movieStatusLabel.Size = new System.Drawing.Size(85, 13);
            this.movieStatusLabel.TabIndex = 11;
            this.movieStatusLabel.Text = "Movie Status:";
            // 
            // capacityText
            // 
            this.capacityText.Location = new System.Drawing.Point(385, 252);
            this.capacityText.Name = "capacityText";
            this.capacityText.Size = new System.Drawing.Size(100, 20);
            this.capacityText.TabIndex = 12;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Available",
            "Non-available"});
            this.statusComboBox.Location = new System.Drawing.Point(384, 302);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(101, 21);
            this.statusComboBox.TabIndex = 15;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.capacityText);
            this.Controls.Add(this.movieStatusLabel);
            this.Controls.Add(this.movieCapacityLabel);
            this.Controls.Add(this.previousPageButton);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.movieTheaterText);
            this.Controls.Add(this.startTimeText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.movieTheater);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Name = "AddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label movieTheater;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox startTimeText;
        private System.Windows.Forms.TextBox movieTheaterText;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.Label movieCapacityLabel;
        private System.Windows.Forms.Label movieStatusLabel;
        private System.Windows.Forms.TextBox capacityText;
        private System.Windows.Forms.ComboBox statusComboBox;
    }
}