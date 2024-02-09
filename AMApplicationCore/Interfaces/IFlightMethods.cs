using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMApplicationCore.Interfaces
{
    public interface IFlightMethods
    {
        IList<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);
    }
}
