using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketSystem
{
    class Admin : User
    {
        private Admin() { }

        // the one and only instance
        private static Admin singleInstance = null;

        public static Admin GetInstance()
        {
            if (singleInstance == null)
            {
                singleInstance = new Admin();
            }

            return singleInstance;
        }
    }
}
