using JapTask1BackendCorrection.DTO.Ticket;
using JapTask1BackendCorrection.Entities;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Services.TicketService
{
    public interface ITicketService
    {
        Task<ServiceResponse<bool>> BuyTickets(BuyTicketDTO buyTicketDTO, int UserId);
    }
}
