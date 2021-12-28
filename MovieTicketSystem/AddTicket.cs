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
    public partial class AddTicket : Form
    {

        // Ticket list
        List<Tickets> tickets = new List<Tickets>();

        public AddTicket()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Shows previous page
        private void prevPageButton_Click(object sender, EventArgs e)
        {
            AdminMenu fm3 = new AdminMenu();
            fm3.Show();
            this.Hide();
        }

        // Adds a new ticket to the ("Tickets.txt") file
        private void addTicketButton_Click(object sender, EventArgs e)
        {
            // Check if any textbox is empty
            if (ticketIdText.Text.Equals("") || movieIdText.Text.Equals("") || statusComboBox.SelectedIndex == -1 || priceText.Text.Equals(""))
            {
                MessageBox.Show("Please fill out all fields");
            }

            else
            {
                Tickets ticket = new Tickets(ticketIdText.Text, movieIdText.Text, statusComboBox.Text, priceText.Text);
                tickets.Add(ticket);

                var newTicket = "\r" + ticket.ToString();
                var path = "D:\\Tickets.txt";

                if (File.ReadLines(path).Any(line => line.Contains(ticketIdText.Text)))
                {
                    MessageBox.Show("A ticket with this id already exists");
                }

                else
                {
                    File.AppendAllText(path, newTicket);
                }

                ticketIdText.Clear();
                movieIdText.Clear();
                priceText.Clear();
                statusComboBox.SelectedIndex = -1;
            }
        }
    }
}
    

