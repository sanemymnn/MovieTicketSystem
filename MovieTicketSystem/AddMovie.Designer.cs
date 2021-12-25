
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
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id.Location = new System.Drawing.Point(127, 84);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(24, 13);
            this.id.TabIndex = 0;
            this.id.Text = "ID:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.Location = new System.Drawing.Point(127, 130);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(43, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Name:";
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startTime.Location = new System.Drawing.Point(127, 176);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(69, 13);
            this.startTime.TabIndex = 2;
            this.startTime.Text = "Start Time:";
            // 
            // movieTheater
            // 
            this.movieTheater.AutoSize = true;
            this.movieTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movieTheater.Location = new System.Drawing.Point(127, 224);
            this.movieTheater.Name = "movieTheater";
            this.movieTheater.Size = new System.Drawing.Size(93, 13);
            this.movieTheater.TabIndex = 3;
            this.movieTheater.Text = "Movie Theater:";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(249, 84);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 4;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(249, 127);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 5;
            // 
            // startTimeText
            // 
            this.startTimeText.Location = new System.Drawing.Point(249, 173);
            this.startTimeText.Name = "startTimeText";
            this.startTimeText.Size = new System.Drawing.Size(100, 20);
            this.startTimeText.TabIndex = 6;
            // 
            // movieTheaterText
            // 
            this.movieTheaterText.Location = new System.Drawing.Point(249, 221);
            this.movieTheaterText.Name = "movieTheaterText";
            this.movieTheaterText.Size = new System.Drawing.Size(100, 20);
            this.movieTheaterText.TabIndex = 7;
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(274, 278);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(75, 23);
            this.addMovieButton.TabIndex = 8;
            this.addMovieButton.Text = "Add Movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // previousPageButton
            // 
            this.previousPageButton.Location = new System.Drawing.Point(25, 26);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(34, 23);
            this.previousPageButton.TabIndex = 9;
            this.previousPageButton.Text = "<--";
            this.previousPageButton.UseVisualStyleBackColor = true;
            this.previousPageButton.Click += new System.EventHandler(this.previousPageButton_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "AddMovie";
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
    }
}