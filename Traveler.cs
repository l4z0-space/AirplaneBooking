using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneBook
{
    class Traveler
    {
        public Traveler(string fName,string lName)
        {
            firstName = fName;
            lastName = lName;
        }
        string firstName;
        string lastName;
        
        public string getFullName()
        {
            return firstName + " " + lastName;
        }

    }
}
