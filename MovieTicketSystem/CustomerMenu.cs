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
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void PurchasedTicketsButton_Click(object sender, EventArgs e)
        {
            PurchasedTicket frm8 = new PurchasedTicket();
            frm8.Show();
            this.Hide();
        }

        private void DisplayMovieTicketButton_Click(object sender, EventArgs e)
        {
            CustomerDisplayTour frm9 = new CustomerDisplayTour();
            frm9.Show();
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
