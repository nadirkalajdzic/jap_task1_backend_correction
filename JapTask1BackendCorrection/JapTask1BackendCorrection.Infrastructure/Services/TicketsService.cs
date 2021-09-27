using JapTask1BackendCorrection.Infrastructure.Data;
using JapTask1BackendCorrection.Core.Entities;
using JapTask1BackendCorrection.Core.Interfaces.TicketService;
using JapTask1BackendCorrection.Core.Response;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using JapTask1BackendCorrection.Core.Requests.Ticket;

namespace JapTask1BackendCorrection.Infrastructure.Services.TicketService
{
    public class TicketService : ITicketService
    {
        private readonly DataContext _context;
       
        public TicketService(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        ///     firstly some conditions need to be met:
        ///         1. the number of tickets must be at least 1, elsewise an exception is thrown
        ///         2. the given screening must exist in the database, elsewise an exception is thrown
        ///         3. the given screening cannot be in the past because you need to buy tickets for a screening that will happen in the future, elsewise an exception is thrown
        ///         4. the given screening must have available tickets for selling, elsewise an exception is thrown
        ///         5. the user cannot buy 20 tickets for a screening that has now 10 available tickets, elsewise an exception is thrown
        ///     
        ///     if the conditions are met, the tickets get bought
        /// </summary>
        /// <param name="screeningId"> id of the screening for which the tickets will be bought </param>
        /// <param name="numberOfTickets"> how many tickets will be bought </param>
        /// <param name="userId"> id of the user who is buying the tickets </param>
        /// <returns></returns>
        public async Task<ServiceResponse<bool>> BuyTickets(BuyTicketRequest request, int userId)
        {   
            var screening = await _context.Screenings.FirstOrDefaultAsync(x => x.Id == request.ScreeningId);

            if (screening == null)
                return new() { Message = "Screening does not exist!" };
            else if (screening.ScreeningDate <= DateTime.Now)
                return new() { Message = "Screening is in the past!" };
            else if (screening.AvailableTickets == screening.SoldTickets)
                return new() { Message = "Sould out!" };
            else if (screening.SoldTickets + request.NumberOfTickets > screening.AvailableTickets)
                return new() { Message = "Cannot buy that many tickets. There are not that many tickets available!" };
            else
            {
                screening.SoldTickets += request.NumberOfTickets;
                await _context.SaveChangesAsync();

                await _context.BoughtTickets
                    .AddAsync(new BoughtTicket
                        {
                            ScreeningId = request.ScreeningId,
                            UserId = userId,
                            BoughtTickets = request.NumberOfTickets
                    });
                await _context.SaveChangesAsync();

                return new() { Success = true, Data = true, Message = "Successfully bought tickets!" };
            }
        }
    }
}
