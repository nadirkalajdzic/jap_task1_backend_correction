using JapTask1BackendCorrection.Data.Seeders;
using JapTask1BackendCorrection.Entities;
using JapTask1BackendCorrection.Services.AuthService;
using Microsoft.EntityFrameworkCore;
using System;

namespace JapTask1BackendCorrection.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<BoughtTicket> BoughtTickets { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<MostRatedMoviesReport> MostRatedMoviesReports { get; set; }
        public DbSet<MoviesWithMostScreeningsReport> MoviesWithMostScreeningsReports { get; set; }
        public DbSet<MoviesWithMostSoldTicketsReport> MoviesWithMostSoldTicketsReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Category static data
            modelBuilder.Entity<Category>().HasData(CategorySeed.Categories);
            #endregion

            #region Actor static data
            modelBuilder.Entity<Actor>().HasData(ActorSeed.Actors);
            #endregion

            #region Movies and Series static data
            modelBuilder.Entity<Media>().HasData(MediaSeed.Medias);
            #endregion

            #region Admin user
            AuthService.CreatePasswordHash("admin", out byte[] passHash, out byte[] passSalt);
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Admin", LastName="Admin", Email="admin@gmail.com",  Salt = passSalt, Hash= passHash}  
            );
            #endregion

            #region Ratings
            modelBuilder.Entity<Rating>().HasData(RatingSeed.Ratings);
            #endregion

            #region Screenings, duration is in minutes
            modelBuilder.Entity<Screening>().HasData(ScreeningSeed.Screenings);
            #endregion

            modelBuilder.Entity<MostRatedMoviesReport>().HasNoKey();

            modelBuilder.Entity<MoviesWithMostScreeningsReport>().HasNoKey();

            modelBuilder.Entity<MoviesWithMostSoldTicketsReport>().HasNoKey();
        }
    }
}
