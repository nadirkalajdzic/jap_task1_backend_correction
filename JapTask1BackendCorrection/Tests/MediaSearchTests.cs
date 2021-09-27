using AutoMapper;
using JapTask1BackendCorrection.Core.Entities;
using JapTask1BackendCorrection.Core.Interfaces.MediaService;
using JapTask1BackendCorrection.Infrastructure.Data;
using JapTask1BackendCorrection.Infrastructure.Services.AuthService;
using JapTask1BackendCorrection.Infrastructure.Services.MediaService;
using JapTask1BackendCorrection.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NUnitTests
{
    [TestFixture]
    public class MediaSearchTests
    {
        DataContext _context;
        IMediaService _mediaService;
        IMapper _mapper;

        [SetUp]
        public async Task OneTimeSetupAsync()
        {
            // database setup
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "temp_moviesapp3")
                .Options;

            _context = new DataContext(options);

            // - add data

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

            IConfiguration configuration = new ConfigurationBuilder().Build();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            _mapper = mappingConfig.CreateMapper();

            _mediaService = new MediaService(_mapper, _context);

        }

        [TearDown]
        public async Task TearDownAsync()
        {
            await _context.Database.EnsureDeletedAsync();
        }

        [Test]
        public async Task MediaSearchTests_InputNormalFilmTitle_ReturnListOf1()
        {
            var list = (await _mediaService.GetFilteredMedias("The s")).Data;

            foreach (var i in list) Console.WriteLine(i.Title);

            //should only be one from the three given movies
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(list[0].Title, "The Shawshank Redemption");
        }

        [Test]
        public async Task MediaSearchTests_InputAfter1970_ReturnListOf1()
        {
            var list = (await _mediaService.GetFilteredMedias("after 1980")).Data;

            //should only be one from the three given movies
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        public async Task MediaSearchTests_InputAfter72EdgeCase_ReturnListOf2()
        {
            var list = (await _mediaService.GetFilteredMedias("after 1972")).Data;

            //movie with the release year 1972 should not be included
            Assert.AreEqual(2, list.Count);
        }

        [Test]
        public async Task MediaSearchTests_InputDescriptionWord_ReturnListOf1()
        {
            var list = (await _mediaService.GetFilteredMedias("Vito Corleone")).Data;

            //should only be one from the three given movies
            Assert.AreEqual(1, list.Count);
            Assert.IsTrue(list[0].Description.Contains("Vito Corleone"));
        }

        [Test]
        public async Task MediaSearchTests_InputExactRating_ReturnListOf1()
        {
            var list = (await _mediaService.GetFilteredMedias("4.3 stars")).Data;

            //should only be one from the three given movies
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        public async Task MediaSearchTests_InputRatingAtLeast_ReturnListOf1()
        {
            var list = (await _mediaService.GetFilteredMedias("at least 4 stars")).Data;

            //should only be one from the three given movies
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        public async Task MediaSearchTests_InputRatingAtLeastEdgeCase_ReturnListOf2()
        {
            var list = (await _mediaService.GetFilteredMedias("at least 3.6 stars")).Data;

            //should only be one from the three given movies
            Assert.AreEqual(2, list.Count);
        }

        [Test]
        public async Task MediaSearchTests_InputOlderThan_ReturnListOf2()
        {
            var list = (await _mediaService.GetFilteredMedias("older than " + (DateTime.Now.Year - 1993) + " years")).Data;

            Assert.AreEqual(2, list.Count);
        }

        [Test]
        public async Task MediaSearchTests_InputOlderThanEdgeCase_ReturnListOf1()
        {
            var list = (await _mediaService.GetFilteredMedias("older than " + (DateTime.Now.Year - 1994) + " years")).Data;

            //films with the year 1994 should not be included in the result
            Assert.AreEqual(2, list.Count);
        }
    }
}
