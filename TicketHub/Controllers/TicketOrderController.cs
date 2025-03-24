using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TicketHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketOrderController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;

        public TicketOrderController(ILogger<TicketOrderController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from tickets controller");
        }

        [HttpPost]
        public IActionResult Post(TicketOrder ticketOrder)
        {
            //using model state
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }


            return Ok("POSTING from tickets controller: " + ticketOrder.Name);
        }


    }
}
