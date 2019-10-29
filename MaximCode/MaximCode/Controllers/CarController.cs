using MaximCode.Data;
using MaximCode.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MaximCode.Controllers
{
    [RoutePrefix("api/car")]
    public class CarController : ApiController
    {
   
            CarRepository repo = new CarRepository();
        [Route("Add")]
        public IHttpActionResult GetAddCars()
        {
            repo.Add();
            return Ok();
        }
 

        [Route("Alphabet")]
        public IEnumerable<Car> GetAlphabetizedCars()
        {
            return repo.getAll().OrderBy(x => x.Make);
        }

        [Route("Latest")]
        public IEnumerable<Car> GetNewestVehicles()
        {
            string year = repo.getAll().Distinct<Car>().Max(x => x.Year);
            return repo.GetDifferentCondition(x => x.Year == year);
        }

        [Route("OrderedbyPrice")]
        public IEnumerable<Car> GetByPriceOrdered()
        {
            return repo.getAll().OrderBy(x => x.Price);
        }

        [Route("BestValue")]
        public IEnumerable<Car> GetByBestValue()
        {
            double rating = repo.getAll().Distinct<Car>().Max(x => x.TCCRating);
            return repo.GetDifferentCondition(x => x.TCCRating == rating);
        }

        [Route("FuelConsumption")]
        public double GetFuelConsumption(int id, double miles)
        {
            double mpg = repo.GetDifferentCondition(x => x.Id == id).FirstOrDefault().HwyMPG;
            return miles / mpg;
        }

        [Route("Random")]
        public Car GetRandom()
        {
            int listcount = repo.getAll().Count();
            Random rnd = new Random();
            int randomId = rnd.Next(1, listcount+1);
            return repo.GetDifferentCondition(x =>x.Id==randomId).FirstOrDefault();
        }

        [Route("AvgMpg")]
        public double GetAvgMpg(string year)
        {
            return repo.GetDifferentCondition(x => x.Year == year).Select(x => x.HwyMPG).Average();
        }

    }
}
