using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketSystem
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            AddMovie fm2 = new AddMovie();
            fm2.Show();
            this.Hide();
        }

        private void AddTicketButton_Click(object sender, EventArgs e)
        {
            AddTicket fm6 = new AddTicket();
            fm6.Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Authentication aut = new Authentication();
            aut.Show();
            this.Hide();

        }
    }
}
