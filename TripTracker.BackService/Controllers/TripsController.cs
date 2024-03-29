﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripTracker.BackService.Models;

namespace TripTracker.BackService.Controllers
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        private Repository _repository;

        public TripsController(Repository repository)
        {
            _repository = repository;
        }

        // GET api/Trips
        [HttpGet]
        public IEnumerable<Trip> Get()
        {
            return _repository.Get();
        }
        
        // GET api/Trips/5
        [HttpGet("{id}")]
        public Trip GetById(int id)
        {
            return _repository.GetById(id);
        }

        // POST api/Trips
        [HttpPost]
        public void Post([FromBody]Trip newTrip)
        {
            _repository.Add(newTrip);
        }

        // PUT api/Trips/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Trip tripToUpdate)
        {
            _repository.Update(tripToUpdate);
        }

        // DELETE api/Trips/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Remove(id);
        }
    }
}
