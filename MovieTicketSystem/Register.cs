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
    public partial class registerPicture : Form
    {
        public registerPicture()
        {
            InitializeComponent();
        }



       // Shows previous page
       

        // Adss new account to ("Customer.txt") file

        private void registerButton_Click_1(object sender, EventArgs e)
        {
            //Check if any textbox is empty
            if (usernameText.Text.Equals("") || passwordText.Text.Equals("") || nameText.Text.Equals("") || surnameText.Text.Equals(""))
            {
                MessageBox.Show("Please fill out the fields.");
            }

            else
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[8];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                User customer = new Customer(finalString, usernameText.Text, passwordText.Text, nameText.Text, surnameText.Text);
                Customer.myList.Add((Customer)customer);
                var newUser = customer.ToString() + "\r";
                var path = "D:\\Customers.txt";

                if (File.ReadLines(path).Any(line => line.Contains(usernameText.Text)))
                {
                    MessageBox.Show("A user with this username already exists");
                }
                else
                {
                    File.AppendAllText(path, newUser);
                }

                usernameText.Clear();
                passwordText.Clear();
                nameText.Clear();
                surnameText.Clear();
                ageText.Clear();
            }

        }

        // Adss new account to ("Customer.txt") file
        private void prevPageButton_Click(object sender, EventArgs e)
        {
            Authentication aut = new Authentication();
            aut.Show();
            this.Hide();
        }
    }
}



