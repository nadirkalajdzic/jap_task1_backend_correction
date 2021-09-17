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

        public async Task<ServiceResponse<bool>> BuyTickets(BuyTicketDTO buyTicketDTO, int UserId)
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
                            UserId = UserId,
                            BoughtTickets = buyTicketDTO.NumberOfTickets
                        });
                await _context.SaveChangesAsync();

                return new() { Success = true, Data = true, Message = "Successfully bought tickets!" };
            }
        }
    }
}
