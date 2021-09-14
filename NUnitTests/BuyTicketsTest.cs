using jap_task1_backend_correction.Data;
using jap_task1_backend_correction.DTO.Ticket;
using jap_task1_backend_correction.Models;
using jap_task1_backend_correction.Services.AuthService;
using jap_task1_backend_correction.Services.TicketsService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace NUnitTests
{
    [TestFixture]
    public class BuyTicketsTest
    {
        DataContext _context;
        ITicketsService ticketsService;

        [SetUp]
        public async Task OneTimeSetupAsync()
        {
            // database setup
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "temp_moviesapp1")
                .Options;
            
            _context = new DataContext(options);

            // - add data
            _context.Screenings.Add(new Screening { Id = 1, Name = "Screening 1", VideoId = 1, AvailableTickets = 11, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30), Duration = 300 });
            _context.Screenings.Add(new Screening { Id = 2, Name = "Screening 2", VideoId = 1, AvailableTickets = 11, SoldTickets = 10, ScreeningDate = DateTime.Now.AddDays(-3), Duration = 300 });
            _context.Screenings.Add(new Screening { Id = 3, Name = "Screening 3", VideoId = 1, AvailableTickets = 11, SoldTickets = 11, ScreeningDate = DateTime.Now.AddMinutes(30), Duration = 300 });
            _context.Screenings.Add(new Screening { Id = 4, Name = "Screening 4", VideoId = 1, AvailableTickets = 11, SoldTickets = 10, ScreeningDate = DateTime.Now.AddMinutes(30), Duration = 300 });
            await _context.SaveChangesAsync();

            // --------------

            //add user setup (it doesnt matter that its the admin user)

            AuthService.CreatePasswordHash("admin", out byte[] passHash, out byte[] passSalt);
            _context.Users.Add(
                new User 
                { 
                  Id = 1, 
                  Name = "Admin", 
                  Surname = "Admin", 
                  Email = "admin@gmail.com", 
                  Salt = passSalt, 
                  Hash = passHash 
                }
            );
            await _context.SaveChangesAsync();

            // -------------------------------------------------------------------------

            ticketsService = new TicketsService(_context);

        }

        [TearDown]
        public async Task TearDownAsync()
        {
            await _context.Database.EnsureDeletedAsync();
        }

        [Test]
        public async Task BuyTicketsTest_ValidInput_ReturnsTrue()
        {
            var buyTicketDTO = new BuyTicketDTO { ScreeningId = 1, NumberOfTickets = 2 };

            var response = await ticketsService.BuyTickets(buyTicketDTO, 1);
            
            // buying tickets for a valid screening, there is still available tickets and the screening is not in the past
            Assert.IsTrue(response.Data);
            Assert.AreEqual(response.Message, "Successfully bought tickets!");
        }

        [Test]
        public async Task BuyTicketsTest_ForScreeningInPast_ReturnsFalse()
        {
            var buyTicketDTO = new BuyTicketDTO { ScreeningId = 2, NumberOfTickets = 2 };

            var response = await ticketsService.BuyTickets(buyTicketDTO, 1);

            // buying tickets for a invalid screening that already happened (screening was in the past)
            Assert.IsFalse(response.Data);
            Assert.AreEqual(response.Message, "Screening is in the past!");
        }

        [Test]
        public async Task BuyTicketsTest_ForASoldOutScreening_ReturnsFalse()
        {
            var buyTicketDTO = new BuyTicketDTO { ScreeningId = 3, NumberOfTickets = 1 };

            var response = await ticketsService.BuyTickets(buyTicketDTO, 1);

            // buying tickets for a invalid screening that is sould out (no more available tickets)
            Assert.IsFalse(response.Data);
            Assert.AreEqual(response.Message, "Sould out!");
        }

        [Test]
        public async Task BuyTicketsTest_TryingToBuyTooManyTickets_ReturnsFalse()
        {
            var buyTicketDTO = new BuyTicketDTO { ScreeningId = 4, NumberOfTickets = 2 };

            var response = await ticketsService.BuyTickets(buyTicketDTO, 1);

            // buying tickets for a screening that does not have that many tickets available (available for screening 11, sold 10, trying to buy 2)
            Assert.IsFalse(response.Data);
            Assert.AreEqual(response.Message, "Cannot buy that many tickets. There are not that many tickets available!");
        }

    }
}