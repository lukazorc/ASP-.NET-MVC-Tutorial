using System;
using System.Linq;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            //if (newRental.MoviesIds.Count == 0) // defensive approach, more suitable for public APIs
            //    return BadRequest("No Movie Ids have been given");

            var customer = _context.Customers.Single/*OrDefault// defensive/pessimistic method*/(
                c => c.Id == newRental.CustumerId);

            //if (customer == null) // defensive approach
            //    return BadRequest("CustomerId is not valid");

            var movies = _context.Movies.Where(
                 m => newRental.MoviesIds.Contains(m.Id)).ToList();

            //if (movies.Count != newRental.MoviesIds.Count) // defensive approach
            //    return BadRequest("One or more MoviesIds are invalid.");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0) // this is importat better check it, is not to defensive
                    return BadRequest("Movie is not available.");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
