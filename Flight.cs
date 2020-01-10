using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneBook
{
    class Flight

    {
        public Flight(string fID,string dCity, string lCity, string tCity, DateTime dTime, DateTime lTime,string pType,int cap, int nRows, bool mProvided)
        {
            flightID = fID;
            departingCity = dCity;
            landingCity = lCity;
            transitCity = tCity;
            departingTime = dTime;
            planeType = pType;
            landingTime = lTime;
            mealProvided = mProvided;
            capacity = cap;
            numberOfRows = nRows;
        }
        public bool[][] availableSeat = new bool[100][];    // array to check whether the seat will be available (true) or not (false)
        string flightID;
        string departingCity;
        string landingCity;
        string transitCity;
        string planeType;
        DateTime departingTime;
        DateTime landingTime;
        bool mealProvided;
        int capacity;
        int numberOfRows;
        
        public string getFlightID() { return flightID; }
        public string getDeptartingCity() { return departingCity; }
        public string getLandingCity() { return landingCity; }
        public string getTransitCity() { return transitCity; }
        public DateTime getDepartingTime() { return departingTime; }
        public DateTime getLandingTime() { return landingTime; }
        public bool getMealProvided() { return mealProvided; }
        public int getCapacity() { return capacity; }
        public int getNumberOfRows() { return numberOfRows; }


       


    }
}
