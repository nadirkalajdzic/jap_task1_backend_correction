using JapTask1BackendCorrection.Data;
using JapTask1BackendCorrection.Entities;
using JapTask1BackendCorrection.Services.AuthService;
using JapTask1BackendCorrection.Services.RatingService;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NUnitTests
{
    [TestFixture]
    public class AddRatingTests
    {
        DataContext _context;
        IRatingService _ratingsService;

        [SetUp]
        public async Task SetupAsync()
        {
            // database setup
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "temp_moviesapp4")
                .Options;

            _context = new DataContext(options);

            // - add data

            AuthService.CreatePasswordHash("admin", out byte[] passHashAdmin, out byte[] passSaltAdmin);
            _context.Users.Add(
                new User
                {
                    Id = 1,
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "admin@gmail.com",
                    Salt = passSaltAdmin,
                    Hash = passHashAdmin
                }
            );

            AuthService.CreatePasswordHash("user", out byte[] passHashUser, out byte[] passSaltUser);
            _context.Users.Add(
                new User
                {
                    Id = 2,
                    FirstName = "User",
                    LastName = "User",
                    Email = "user@gmail.com",
                    Salt = passSaltUser,
                    Hash = passHashUser
                }
            );

            _context.Medias.Add(new Media
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                ImageUrl = "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop",
                Type = 0,
                ReleaseDate = new DateTime(1994, 9, 22),
                Ratings = new List<Rating>
                {
                    new Rating { Id = 1, Value = 4.6F, MediaId = 1, UserId = 1 },
                    new Rating { Id = 2, Value = 4F, MediaId = 1, UserId = 1 }
                }
            });
            _context.Medias.Add(new Media
            {
                Id = 2,
                Title = "The Godfather",
                Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                ImageUrl = "https://www.reelviews.net/resources/img/posters/thumbs/godfather_poster.jpg",
                Type = 0,
                ReleaseDate = new DateTime(1972, 3, 24),
                Ratings = new List<Rating>
                {
                    new Rating { Id = 3, Value = 2.6F, MediaId = 2, UserId = 1 }
                }
            });
            _context.Medias.Add(new Media
            {
                Id = 3,
                Title = "The Godfather: Part II",
                Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                ImageUrl = "https://shotonwhat.com/images/0071562-med.jpg",
                Type = 0,
                ReleaseDate = new DateTime(1974, 12, 20),
                Ratings = new List<Rating>
                {
                    new Rating { Id = 4, Value = 3.6F, MediaId = 3, UserId = 1 }
                }
            });

            await _context.SaveChangesAsync();

            // --------------

            _ratingsService = new RatingService(_context);            

        }

        [TearDown]
        public async Task TearDownAsync()
        {
            await _context.Database.EnsureDeletedAsync();
        }

        [Test]
        public async Task AddRatingTest_InputValidRatingAdd_ReturnTrue()
        {
            var response = await _ratingsService.AddRating(4.1F, 1, 2);

            //Is the rating added?
            Assert.IsTrue(response.Success);
            Assert.AreEqual("Successfully added rating", response.Message);

            var ratingAfter = (await _context.Ratings.Where(x => x.MediaId == 1).ToListAsync()).Average(x => x.Value);
            
            Assert.AreEqual(4.3F, ratingAfter, .1);
        }

        [Test]
        public async Task AddRatingTest_InputInValidRatingAdd_ReturnFalse()
        {
            var response1 = await _ratingsService.AddRating(4.1F, 2, 2);
            ServiceResponse<bool> response2 = new();

            //Is the rating added?
            //first one needs to be added
            Assert.IsTrue(response1.Success);
            Assert.AreEqual(response1.Message, "Successfully added rating");

            //second time it shouldn't. one user cannot rate the same film/show twice!
            try
            {
                response2 = await _ratingsService.AddRating(4.1F, 2, 2);
            } catch(Exception e)
            {
                Assert.AreEqual(e.Message, "You already rated this item!");
            }

            var ratingAfter = (await _context.Ratings.Where(x => x.MediaId == 1).ToListAsync()).Average(x => x.Value);

            Assert.AreEqual(4.3F, ratingAfter, .1);
        }
    }
}
