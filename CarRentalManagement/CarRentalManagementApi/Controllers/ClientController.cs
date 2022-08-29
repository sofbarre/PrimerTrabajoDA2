using Domain.Logics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalManagementApi.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private ClientLogic clientLogic= new ClientLogic();

        [HttpGet]
        public IActionResult GetClients([FromQuery] string name , [FromQuery] string country)
        {

            return Ok(clientLogic.GetClientsByNameAndCountry(name, country));
        }
    }
}
