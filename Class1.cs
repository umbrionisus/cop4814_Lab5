// This is a comment for step 7.

// This is a comment for step 10A line 3.

// This is a comment for step 10 Line 5.

// This is a comment for step 11 Line 7.

// This is a comment for step 11 Line 9.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This is a conflict.

namespace FlightLibrary
{
    public class Flight
    {
        public int FlightNumber { get; set; }
        public string DateandTime { get; set; }
        public string OrigAirport { get; set; }
        public string DestAirport { get; set; }
        public double Fare { get; set; }
        public string Seats { get; set; }

        public Flight ( int FlightNumber, string DateandTime, string OrigAirport, string DestAirport, double Fare, string Seats )
        {
            this.FlightNumber = FlightNumber;
            this.DateandTime = DateandTime;
            this.OrigAirport = OrigAirport;
            this.DestAirport = DestAirport;
            this.Fare = Fare;
            this.Seats = Seats;
        }
    }
}
