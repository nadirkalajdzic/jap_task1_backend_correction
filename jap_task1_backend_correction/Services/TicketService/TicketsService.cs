using JapTask1BackendCorrection.Data;
using JapTask1BackendCorrection.DTO.Ticket;
using JapTask1BackendCorrection.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Services.TicketService
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
        /// <param name="buyTicketDTO"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<bool>> BuyTickets(BuyTicketDTO buyTicketDTO, int userId)
        {
            var serviceResponse = new ServiceResponse<bool> { Data = false };

            if (buyTicketDTO.NumberOfTickets <= 0)
                throw new Exception("Number of tickets cannot be zero or negative!");
            
            var screening = await _context.Screenings.FirstOrDefaultAsync(x => x.Id == buyTicketDTO.ScreeningId);

            if (screening == null)
                throw new Exception("Screening does not exist!");
            else if (screening.ScreeningDate <= DateTime.Now)
                throw new Exception("Screening is in the past!");
            else if (screening.AvailableTickets == screening.SoldTickets)
                throw new Exception("Sould out!");
            else if (screening.SoldTickets + buyTicketDTO.NumberOfTickets > screening.AvailableTickets)
                throw new Exception("Cannot buy that many tickets. There are not that many tickets available!");
            else
            {
                screening.SoldTickets += buyTicketDTO.NumberOfTickets;
                await _context.SaveChangesAsync();

                await _context.BoughtTickets
                    .AddAsync(new BoughtTicket
                        {
                            ScreeningId = buyTicketDTO.ScreeningId,
                            UserId = userId,
                            BoughtTickets = buyTicketDTO.NumberOfTickets
                        });
                await _context.SaveChangesAsync();

                return new() { Success = true, Data = true, Message = "Successfully bought tickets!" };
            }
        }
    }
}
