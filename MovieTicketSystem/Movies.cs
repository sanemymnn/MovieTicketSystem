using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketSystem
{
    class Movies
    {
        private string id;
        private string name;
        private string startTime;
        private string movieTheater;
        private string capacity;
        private string status;
        

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string MovieTheater { get => movieTheater; set => movieTheater = value; }
        public string Capacity { get => capacity; set => capacity = value; }
        public string Status { get => status; set => status = value; }




        //Parameterized Constructor
        public Movies(string id, string name, string startTime, string movieTheater, string capacity, string status)
        {
            Name = name;

            try
            {
                // Check if name is null
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("Name cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Id = id;

            try
            {
                // Check if id is null
                if (string.IsNullOrEmpty(id))
                {
                    throw new Exception("ID cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            StartTime = startTime;

            try
            {
                // Check if start time is null
                if (string.IsNullOrEmpty(startTime))
                {
                    throw new Exception("Start time cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

          

            MovieTheater = movieTheater;

            try
            {
                // Check if movie theater place is null
                if (string.IsNullOrEmpty(movieTheater))
                {
                    throw new Exception("Movie theater cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Capacity = capacity;

            try
            {
                // Check if capacity place is null
                if (string.IsNullOrEmpty(capacity))
                {
                    throw new Exception("Capacity cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Status = status;

            try
            {
                // Check if sttaus place is null
                if (string.IsNullOrEmpty(status))
                {
                    throw new Exception("Status cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

   
        public Movies() { }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Start Date: " + StartTime);
            Console.WriteLine("Movie Theater: " + MovieTheater);
            Console.WriteLine("Capacity: " + Capacity);
            Console.WriteLine("Movie status: " + Status);


        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5}", this.Id, this.Name, this.StartTime, this.MovieTheater, this.Capacity, this.Status);
        }
    }
}
