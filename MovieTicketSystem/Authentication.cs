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
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            // Create one single instance for the admin
            Admin admin = Admin.GetInstance();
            admin.Username = "admin";
            admin.Password = "12345";

            if (usernameText.Text == admin.Username && passwordText.Text == admin.Password)
            {
                AdminMenu frm3 = new AdminMenu();
                frm3.Show();
                this.Hide();
            }
            else if (usernameText.Text.Equals("") || passwordText.Text.Equals(""))
            {
                MessageBox.Show("Please fill out all fields");
            }

            else
            {
                MessageBox.Show("Invalid info");
            }
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void usernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            passwordText.PasswordChar = '*';
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerPicture fm4 = new registerPicture();
            fm4.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool loginsuccess = false;
            string[] logins = File.ReadAllLines(@"D:\Customers.txt");

            for (int i = 0; i < logins.Length; i++)
            {
                string[] Credential = logins[i].Split(' ');

                if (usernameText.Text == Credential[1] && passwordText.Text == Credential[2])
                {
                    CustomerMenu frm7 = new CustomerMenu();
                    frm7.Show();
                    this.Hide();
                    loginsuccess = true;
                    break;
                }
            }
            // login failed
            if (!loginsuccess)
            {
                MessageBox.Show("Wrong username or password");

            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
