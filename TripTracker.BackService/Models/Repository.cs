using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Repository
    {
        private List<Trip> MyTrips = new List<Trip>
        {
            new Trip
            {
                Id = 1,
                Name = "Trip to Mangalore",
                StartDate = new DateTime(2019, 10, 23),
                EndDate = new DateTime(2019, 10, 31)
            },
            new Trip
            {
                Id = 2,
                Name = "Trip to Vietnam",
                StartDate = new DateTime(2020, 03, 01),
                EndDate = new DateTime(2020, 03, 31)
            },
            new Trip
            {
                Id = 3,
                Name = "Trip to Ceychells",
                StartDate = new DateTime(2020, 07, 23),
                EndDate = new DateTime(2020, 10, 31)
            },
        };

        public List<Trip> Get() => MyTrips;

        public Trip GetById(int id) => MyTrips.First(trip => trip.Id.Equals(id));

        public void Add(Trip newTrip) => MyTrips.Add(newTrip);

        public void Update(Trip tripToUpdate) 
        {
            MyTrips.Remove(MyTrips.First(trip => tripToUpdate.Id.Equals(trip.Id)));
            Add(tripToUpdate);
        }

        public void Remove(int id)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id.Equals(id)));
        }
    }
}
