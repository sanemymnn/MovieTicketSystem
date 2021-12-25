using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketSystem
{
    public partial class AddMovie : Form
    {
        List<Movies> movies = new List<Movies>();
        public AddMovie()
        {
            InitializeComponent();
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            if (idText.Text.Equals("") || nameText.Text.Equals("") || startTimeText.Text.Equals("") || movieTheaterText.Text.Equals("") )
            {
                MessageBox.Show("Please fill out all fields");
            }

            else
            {
                Movies movie = new Movies(idText.Text, nameText.Text, startTimeText.Text, movieTheaterText.Text);
                movies.Add(movie);

                var newTour = "\r" + movie.ToString();
                var path = "D:\\Movies.txt";

                if (File.ReadLines(path).Any(line => line.Contains(idText.Text)))
                {
                    MessageBox.Show("A movie with this id already exists");
                }

                else
                {
                    File.AppendAllText(path, newTour);
                }

                idText.Clear();
                nameText.Clear();
                startTimeText.Clear();
                movieTheaterText.Clear();
              
            }
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {
            AdminMenu fm3 = new AdminMenu();
            fm3.Show();
            this.Hide();
        }
    }
}
