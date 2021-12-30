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
        

        

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string MovieTheater { get => movieTheater; set => movieTheater = value; }
    



        //Parameterized Constructor
        public Movies(string id, string name, string startTime, string movieTheater)
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
                // Check if start date is null
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
                // Check if destination place is null
                if (string.IsNullOrEmpty(movieTheater))
                {
                    throw new Exception("Movie theater cannot be null");
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
     
        
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", this.Id, this.Name, this.StartTime, this.MovieTheater);
        }
    }
}
