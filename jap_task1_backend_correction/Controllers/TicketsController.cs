using jap_task1_backend_correction.DTO.Ticket;
using jap_task1_backend_correction.Services.TicketsService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace jap_task1_backend_correction.Controllers
{
    [Authorize]
    [Route("tickets")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketsService _ticketsService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TicketsController(ITicketsService ticketsService, IHttpContextAccessor httpContextAccessor)
        {
            _ticketsService = ticketsService;
            _httpContextAccessor = httpContextAccessor;
        }

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

        [HttpPost("buy_tickets")]
        public async Task<IActionResult> BuyTickets([FromBody] BuyTicketDTO buyTicketDTO)
        {
            var response = await _ticketsService.BuyTickets(buyTicketDTO, GetUserId());

            return response.Success ? Ok(response) : BadRequest(response);
      
        }
    }
}
