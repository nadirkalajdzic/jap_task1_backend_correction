using JapTask1BackendCorrection.Core.Requests.Ticket;
using JapTask1BackendCorrection.Core.Response;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Core.Interfaces.TicketService
{
    public interface ITicketService
    {
        Task<ServiceResponse<bool>> BuyTickets(BuyTicketRequest request, int userId);
    }
}
