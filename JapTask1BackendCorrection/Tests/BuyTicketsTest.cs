using JapTask1BackendCorrection.Core.Entities;
using JapTask1BackendCorrection.Core.Interfaces.TicketService;
using JapTask1BackendCorrection.Infrastructure.Data;
using JapTask1BackendCorrection.Infrastructure.Services.AuthService;
using JapTask1BackendCorrection.Infrastructure.Services.TicketService;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace NUnitTests
{
    [TestFixture]
    public class BuyTicketsTest
    {
        DataContext _context;
        ITicketService ticketsService;

        [SetUp]
        public async Task OneTimeSetupAsync()
        {
            // database setup
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "temp_moviesapp1")
                .Options;
            
            _context = new DataContext(options);

            // - add data
            _context.Screenings.Add(new Screening { Id = 1, Name = "Screening 1", MediaId = 1, AvailableTickets = 11, SoldTickets = 7, ScreeningDate = DateTime.Now.AddDays(30), Duration = 300 });
            _context.Screenings.Add(new Screening { Id = 2, Name = "Screening 2", MediaId = 1, AvailableTickets = 11, SoldTickets = 10, ScreeningDate = DateTime.Now.AddDays(-3), Duration = 300 });
            _context.Screenings.Add(new Screening { Id = 3, Name = "Screening 3", MediaId = 1, AvailableTickets = 11, SoldTickets = 11, ScreeningDate = DateTime.Now.AddMinutes(30), Duration = 300 });
            _context.Screenings.Add(new Screening { Id = 4, Name = "Screening 4", MediaId = 1, AvailableTickets = 11, SoldTickets = 10, ScreeningDate = DateTime.Now.AddMinutes(30), Duration = 300 });
            await _context.SaveChangesAsync();

            // --------------

            //add user setup (it doesnt matter that its the admin user)

            AuthService.CreatePasswordHash("admin", out byte[] passHash, out byte[] passSalt);
            _context.Users.Add(
                new User 
                { 
                  Id = 1, 
                  FirstName = "Admin", 
                  LastName = "Admin", 
                  Email = "admin@gmail.com", 
                  Salt = passSalt, 
                  Hash = passHash 
                }
            );
            await _context.SaveChangesAsync();

            // -------------------------------------------------------------------------

            ticketsService = new TicketService(_context);

        }

        [TearDown]
        public async Task TearDownAsync()
        {
            await _context.Database.EnsureDeletedAsync();
        }

        [Test]
        public async Task BuyTicketsTest_ValidInput_ReturnsTrue()
        {
            var response = await ticketsService.BuyTickets(1, 2, 1);
            
            // buying tickets for a valid screening, there is still available tickets and the screening is not in the past
            Assert.IsTrue(response.Data);
            Assert.AreEqual(response.Message, "Successfully bought tickets!");
        }

        [Test]
        public async Task BuyTicketsTest_ForScreeningInPast_ReturnsFalse()
        {
            // buying tickets for a invalid screening that already happened (screening was in the past)
            var response = await ticketsService.BuyTickets(2, 2, 1);
            Assert.AreEqual(response.Message, "Screening is in the past!");
        }

        [Test]
        public async Task BuyTicketsTest_ForASoldOutScreening_ReturnsFalse()
        {
            var response = await ticketsService.BuyTickets(3, 1, 1);
            Assert.AreEqual(response.Message, "Sould out!");
        }

        [Test]
        public async Task BuyTicketsTest_TryingToBuyTooManyTickets_ReturnsFalse()
        {
            // buying tickets for a screening that does not have that many tickets available
            // (available for screening 11, sold 10, trying to buy 2)
            var response = await ticketsService.BuyTickets(4, 2, 1);
            Assert.AreEqual(response.Message, "Cannot buy that many tickets. There are not that many tickets available!"); 
        }

    }
}