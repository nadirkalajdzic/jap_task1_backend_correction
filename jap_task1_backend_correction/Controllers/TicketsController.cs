using jap_task1_backend_correction.DTO.Ticket;
using jap_task1_backend_correction.Services.TicketsService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace jap_task1_backend_correction.Controllers
{
    [Authorize]
    [Route("tickets")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketsService _ticketsService;

        public TicketsController(ITicketsService ticketsService)
        {
            _ticketsService = ticketsService;
        }

        [HttpPost("buy_tickets")]
        public async Task<IActionResult> BuyTickets([FromBody] BuyTicketDTO buyTicketDTO)
        {
            var response = await _ticketsService.BuyTickets(buyTicketDTO);

            return response.Success ? Ok(response) : BadRequest(response);
      
        }
    }
}
