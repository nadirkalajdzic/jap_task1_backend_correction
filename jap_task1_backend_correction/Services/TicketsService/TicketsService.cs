using jap_task1_backend_correction.Data;
using jap_task1_backend_correction.DTO.Ticket;
using jap_task1_backend_correction.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace jap_task1_backend_correction.Services.TicketsService
{
    public class TicketsService : ITicketsService
    {
        private readonly DataContext _context;
       
        public TicketsService(DataContext context)
        {
            _context = context;
            
        }

        public async Task<ServiceResponse<bool>> BuyTickets(BuyTicketDTO buyTicketDTO, int UserId)
        {
            var serviceResponse = new ServiceResponse<bool>
            {
                Success = false,
                Data = false
            };

            if (buyTicketDTO.NumberOfTickets <= 0)
            {
                serviceResponse.Message = "Number of tickets cannot be zero or negative!";
                return serviceResponse;
            }
            
            try
            {
                var screening = await _context.Screenings.FirstOrDefaultAsync(x => x.Id == buyTicketDTO.ScreeningId);

                if (screening == null)
                    serviceResponse.Message = "Screening does not exist!";
                else if (screening.ScreeningDate <= DateTime.Now)
                    serviceResponse.Message = "Screening is in the past!";
                else if (screening.AvailableTickets == screening.SoldTickets)
                    serviceResponse.Message = "Sould out!";
                else if (screening.SoldTickets + buyTicketDTO.NumberOfTickets > screening.AvailableTickets)
                    serviceResponse.Message = "Cannot buy that many tickets. There are not that many tickets available!";
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

                    serviceResponse.Success = true;
                    serviceResponse.Data = true;
                    serviceResponse.Message = "Successfully bought tickets!";
                }

            } catch(Exception)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Internal server error";
            }

            return serviceResponse;
        }
    }
}
