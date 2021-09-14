using jap_task1_backend_correction.DTO.Ticket;
using jap_task1_backend_correction.Models;
using System.Threading.Tasks;

namespace jap_task1_backend_correction.Services.TicketsService
{
    public interface ITicketsService
    {
        Task<ServiceResponse<bool>> BuyTickets(BuyTicketDTO buyTicketDTO, int UserId);
    }
}
