using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }

        public DateTime FlightDate { get; set; }

        public int EstimatedDuration { get; set; }

        public DateTime EffectiveArrival { get; set; }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public Plane plane { get; set; }

        public IList<Passenger> passengers { get; set; }
    }
}
