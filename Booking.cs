using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneBook
{
    class Booking
    {
        public Booking(Flight f, Traveler t, bool rTicket)
        {
            flight = f;
            traveler = t;
            returnTicket = rTicket;
        }
        bool returnTicket;
        Flight flight;
        Traveler traveler;

    }
}
