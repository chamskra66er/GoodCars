using GoodCars.Data.Models;
using GoodCars.Services;
using GoodCars.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCars.Web.Controllers
{
    [ApiController]
    public class CarownerController:ControllerBase
    {
        private readonly ICar _carService;
        public CarownerController(ICar carService)
        {
            _carService = carService;
        }
        [HttpGet("/api/owners")]
        public IActionResult GetOwners()
        {
            var model = _carService.GetAllOwners();
            return Ok(model);
        }
        [HttpPost("/api/owners")]
        public ActionResult CreateOwner([FromBody] NewCarOwner ownerRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model state not valid");
            }
            var model = new CarOwner
            {
                CarId = ownerRequest.CarId,
                Period = ownerRequest.Period,
                Owner = ownerRequest.Owner,
                OwnerContent = ownerRequest.OwnerContent,                
            };
            _carService.AddCarOwner(model);
            return Ok($"Car owner created: {model.Owner}");
        }
    }
}
