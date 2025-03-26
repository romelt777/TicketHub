using Azure.Storage.Queues;
using System.Text.Json;
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
            return Ok("Get Request Sucess from the tickets controller");
        }

        [HttpPost]
        public  async Task<IActionResult> Post(TicketOrder ticketOrder)
        {            
            //// 1. validate order
            //using model state
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            // 2 . post order to azure storage queue

            string queueName = "tickethubqueue";

            // Get connection string from secrets.json
            string? connectionString = _configuration["AzureStorageConnectionString"];

            if (string.IsNullOrEmpty(connectionString))
            {
                return BadRequest("An error was encountered: Empty Connection String");
            }

            QueueClient queueClient = new QueueClient(connectionString, queueName);

            // serialize an object to json
            string order = JsonSerializer.Serialize(ticketOrder);

            // send string message to queue
            await queueClient.SendMessageAsync(order);

            return Ok(ticketOrder.Name + ", your ticket order was sent to storage queue.");
        }
    }
}
