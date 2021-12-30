﻿using System;
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
    public partial class CustomerDisplayTicket : Form
    {
        public CustomerDisplayTicket()
        {
            InitializeComponent();
        }
        public void DisplayTicket_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Buy Ticket";
            buttonColumn.Text = "Buy";
            buttonColumn.UseColumnTextForButtonValue = true;
            DisplayTicketDataGridView.Columns.Add(buttonColumn);
        }
        private void prevPageButton_Click(object sender, EventArgs e)
        {
            CustomerDisplayMovie frmm = new CustomerDisplayMovie();
            frmm.Show();
            this.Hide();
        }

       public void DisplayTicketDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Do you want to purchase this ticket? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var valueIndex = string.Format("{0}", DisplayTicketDataGridView.Rows[indexRow].Cells[0].Value);
                    var idIndex = string.Format("{0}", DisplayTicketDataGridView.Rows[indexRow].Cells[1].Value);

                    string[] ticketList = File.ReadAllLines("D:\\Tickets.txt");
                    var tempFile = Path.GetTempFileName();
                    var linesToKeep = File.ReadLines("D:\\Tickets.txt").Where(l => !l.Contains(valueIndex));
                    var line = File.ReadLines("D:\\Tickets.txt").Where(l => l.Contains(valueIndex));

                    File.WriteAllLines(tempFile, linesToKeep);
                    File.AppendAllLines("D:\\BoughtTickets.txt", line.ToList());
                    File.Delete("D:\\Tickets.txt");
                    File.Move(tempFile, "D:\\Tickets.txt");
                    ticketAmountText.Clear();
                    var keptlines = File.ReadLines("D:\\Tickets.txt").Where(l => !l.Contains(valueIndex) && l.Contains(idIndex));
                    int amount = keptlines.Count();
                    string headline = "The ticket amount: " + amount;
                    ticketAmountText.Text = headline;
                    int rowIndex = DisplayTicketDataGridView.CurrentCell.RowIndex;
                    DisplayTicketDataGridView.Rows.RemoveAt(rowIndex);
                }
            }
        }

        public void ticketAmountText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
