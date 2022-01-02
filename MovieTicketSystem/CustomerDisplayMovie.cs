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
    public partial class CustomerDisplayMovie : Form
    {

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        BindingSource bs = new BindingSource();
        
        public CustomerDisplayMovie()
        {
            InitializeComponent();
        }

        // Shows previous page
        private void prevPageButton_Click(object sender, EventArgs e)
        {
            CustomerMenu frm7 = new CustomerMenu();
            frm7.Show();
            this.Hide();
        }

        // Displays all the movies from ("Movies.txt") file
        private void DisplayMovie_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Start Date", typeof(string));
            dt.Columns.Add("Movie Theater", typeof(string));
            dt.Columns.Add("Capacity", typeof(string));
            dt.Columns.Add("Movie Status", typeof(string));


            displayMovieDataGridView.DataSource = dt;

            string[] lines = File.ReadAllLines("D:\\Movies.txt");
            string[] values;

            for (int i = 1; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(' ');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                dt.Rows.Add(row);
            }

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Ticket Info";
            buttonColumn.Text = "See Ticket Info";
            buttonColumn.UseColumnTextForButtonValue = true;
            displayMovieDataGridView.Columns.Add(buttonColumn);
        }

   
    
        // Button events
        private void displayMovieDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Opens customer ticket form to show all ticket infos which belongs to chosen movie id
            if (e.ColumnIndex == 6)
            {
                int numberRow = Convert.ToInt32(e.RowIndex);
                var valueIndex = string.Format("{0}", displayMovieDataGridView.Rows[numberRow].Cells[0].Value);

                string[] allLines = File.ReadAllLines("D:\\Tickets.txt");
                string[] keepLines = Array.FindAll(allLines, line => line.Contains(valueIndex));
                string[] values;

                CustomerDisplayTicket frm10 = new CustomerDisplayTicket();
                frm10.DisplayTicketDataGridView.DataSource = dt2;
                int amount = keepLines.Length;
                string headline = "The ticket amount: " + amount;
                frm10.ticketAmountText.Text = headline;

                dt2.Columns.Add("Ticket ID", typeof(string));
                dt2.Columns.Add("Tour ID", typeof(string));
                dt2.Columns.Add("Ticket Status", typeof(string));
                dt2.Columns.Add("Ticket Price", typeof(string));

                for (int i = 0; i < keepLines.Length; i++)
                {
                    values = keepLines[i].ToString().Split(' ');

                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }

                    dt2.Rows.Add(row);
                }

                frm10.StartPosition = FormStartPosition.CenterScreen;
                frm10.Show();
                this.Hide();
            }
        }

        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            bs.DataSource = dt.DefaultView;
            bs.Filter = string.Format("[" + searchComboBox.Text + "] like '{0}%'", searchText.Text);
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bs.DataSource = dt.DefaultView;
            if (filterComboBox.Text == "All")
           
            {
                bs.Filter = "";

            }

            else if (filterComboBox.Text == "Available")
            {
                bs.Filter = string.Format("[Movie Status] LIKE 'Available'");

            }

            else if (filterComboBox.Text == "Non-available")
            {
                bs.Filter = string.Format("[Movie Status] LIKE 'Non-available'");

            }
        }
    }
    }

