using JapTask1BackendCorrection.Data;
using JapTask1BackendCorrection.DTO.Reports;
using JapTask1BackendCorrection.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Services.ReportService
{
    public class ReportService : IReportService
    {
        private readonly DataContext _context;

        public ReportService(DataContext context)
        {
            _context = context;
        }


        /// <summary>
        ///     report for the most rated movies (a procedure)
        /// </summary>
        /// <returns> a result from the database </returns>
        public async Task<ServiceResponse<List<MostRatedMoviesReport>>> MostRatedMoviesReport()
        {
            return new()
            {
                Data = await _context.MostRatedMoviesReports.FromSqlRaw("EXEC [dbo].[getTop10MoviesWithMostRatings];")
                                                            .ToListAsync(),
                Success = true,
                Message = "Success"
            };
        }

        /// <summary>
        ///     report for the movies with most screenings in the given interval (a procedure gets executed)
        /// </summary>
        /// <param name="dateIntervalDTO"> the given interval for the procedure </param>
        /// <returns> query result from the database </returns>
        public async Task<ServiceResponse<List<MoviesWithMostScreeningsReport>>> MoviesWithMostScreeningsReport(DateIntervalDTO dateIntervalDTO)
        {
            return new()
            {
                Data = await _context.MoviesWithMostScreeningsReports
                     .FromSqlRaw("EXEC [dbo].[getTop10MoviesWithMostScreenings] {0}, {1};", dateIntervalDTO.StartDate, dateIntervalDTO.EndDate)
                     .ToListAsync(),

                Success = true,
                Message = "Success"
            };
        }

        /// <summary>
        ///     report for the movies with most sold tickets (a procedure)
        /// </summary>
        /// <returns> returns a query result from the dabase when the procedure is executed </returns>
        public async Task<ServiceResponse<List<MoviesWithMostSoldTicketsReport>>> MoviesWithMostSoldTicketsReport()
        {
            return new()
            {
                Data = await _context.MoviesWithMostSoldTicketsReports.FromSqlRaw("EXEC [dbo].[getMoviesWithMostSoldTicketsNoRating]")
                                                                      .ToListAsync(),
                Success = true,
                Message = "Success"
            };
        }
    }
}
