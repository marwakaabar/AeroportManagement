using AMApplicationCore.Domain;
using AMApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AMApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public IList<Flight> flights = new List<Flight>();
        public IList<DateTime> GetFlightDates(string destination)
        {
            //hedhi besh nestoki fiha data mtaei 
            IList<DateTime> dateFlights = new List<DateTime>();
            #region methode for 
           /* for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].Destination == destination)
                {
                    dateFlights.Add(flights[i].FlightDate);
                }
                
            }
            return dateFlights;*/
            #endregion

            #region foreach

            foreach(Flight f in flights)
            {
                if (f.Destination == destination)
                {
                    dateFlights.Add(f.FlightDate);
                }

            }
            return dateFlights;
            #endregion
        }


        public void GetFlights(string filterType, string filterValue)
        {

            switch (filterType)
            {
                case "Destination":
                    foreach (Flight f in flights)
                    {
                        if (f.Destination.ToString() == filterValue)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "Departure":
                    foreach (Flight f in flights)
                    {
                        if (f.Departure.ToString() == filterValue)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (Flight f in flights)
                    {
                        if (f.FlightDate.ToString() == filterValue)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightId":
                    foreach (Flight f in flights)
                    {
                        if (f.FlightId.ToString() == filterValue)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EffectiveArrival":

                    foreach (Flight f in flights)
                    {
                        // if (flight.EffectiveArrival == DateTime.Parse(filterValue))
                        if (f.EffectiveArrival.ToString() == filterValue)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    try
                    {
                        foreach (Flight f in flights)
                        {
                            if (f.EstimatedDuration == int.Parse(filterValue))
                            {
                                Console.WriteLine(f);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("la valeur du filter n'est pas un int : ", ex.ToString());
                    }
                    break;
            }
        }

    }
}
