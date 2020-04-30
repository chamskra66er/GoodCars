using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GoodCars.Services;
using GoodCars.Data.Models;
using GoodCars.Web.Models;

namespace GoodCars.Web.Controllers
{
    [ApiController]
    public class CarsController : ControllerBase
    {

        private readonly ILogger<CarsController> _logger;

        private readonly ICar _carService;

        public CarsController(ILogger<CarsController> logger, ICar carService)
        {
            _logger = logger;
            _carService = carService;
        }

        [HttpGet("/api/cars")]
        public ActionResult GetCars()
        {
            var model = _carService.GetAll();
            return Ok(model);
        }
        [HttpPost("/api/cars")]
        public ActionResult CreateCar([FromBody] NewCarRequest carRequest)
        {
            var model = new Car
            { 
                Title = carRequest.Title,
                Name = carRequest.Name,
                Power = carRequest.Power,
                Price = carRequest.Price,
                DateMade = carRequest.DateMade,
                Mileage = carRequest.Mileage
            };
            _carService.AddCar(model);
            return Ok($"Car created: {model.Name}");
        }

    }
}
