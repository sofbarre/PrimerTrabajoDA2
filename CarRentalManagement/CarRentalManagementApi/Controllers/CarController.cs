using Domain.Logics;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CarRentalManagementApi.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private CarLogic carLogic = new CarLogic();


        [HttpGet]
        public IActionResult GetAllCars()
        {
            return new OkObjectResult(carLogic.Cars);
        }

        [HttpGet("{manufacturer}")]
        public IActionResult GetCarByManufacturer([FromRoute] string manufacturer)
        {
            var car = carLogic.Cars.FirstOrDefault(c => c.Manufacturer == manufacturer);
            if(car == null)
            {
                return NotFound();
            }
            else
            {
                return new OkObjectResult(car);
            }
        }

        [HttpPost]
        public IActionResult AddCar([FromBody] Car car)
        {
            carLogic.AddCar(car);
            return Ok(car);
        }
    }
}
