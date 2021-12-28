using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketSystem
{
    class Tickets
    {
        private string ticketID;
        private string movieID;
        private string status;
        private string price;

        //Setters and Getters
        public string TicketID { get => ticketID; set => ticketID = value; }
        public string MovieID { get => movieID; set => movieID = value; }
        public string Status { get => status; set => status = value; }
        public string Price { get => price; set => price = value; }

        //Parameterized Constructor
        public Tickets(string ticketID, string movieID, string status, string price)
        {
            TicketID = ticketID;
            try
            {
                // Check if ticket id is null
                if (string.IsNullOrEmpty(ticketID))
                {
                    throw new Exception("Ticket ID cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            MovieID = movieID;
            try
            {
                // Check if movie id is null
                if (string.IsNullOrEmpty(movieID))
                {
                    throw new Exception("Movie ID cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Status = status;
            try
            {
                // Check if status is null
                if (string.IsNullOrEmpty(status))
                {
                    throw new Exception("Status cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Price = price;
            try
            {
                // Check if price is null
                if (string.IsNullOrEmpty(price))
                {
                    throw new Exception("Price cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //Non-Parameterized Constructor
        public Tickets() { }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", this.TicketID, this.MovieID, this.Status, this.Price);
        }
    }
}

