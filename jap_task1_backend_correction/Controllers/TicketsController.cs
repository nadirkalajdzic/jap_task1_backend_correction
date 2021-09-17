using JapTask1BackendCorrection.DTO.Ticket;
using JapTask1BackendCorrection.Services.TicketService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Controllers
{
    [Authorize]
    [Route("api/tickets")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _ticketsService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TicketsController(ITicketService ticketsService, IHttpContextAccessor httpContextAccessor)
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
