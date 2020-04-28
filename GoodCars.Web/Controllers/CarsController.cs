using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GoodCars.Web.Controllers
{
    [ApiController]
    public class CarsController : ControllerBase
    {

        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/api/cars")]
        public ActionResult GetCars()
        {
            return Ok("Cars!");
        }
    }
}
