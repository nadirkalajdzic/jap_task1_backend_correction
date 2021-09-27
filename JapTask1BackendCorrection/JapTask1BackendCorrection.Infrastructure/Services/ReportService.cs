using JapTask1BackendCorrection.Infrastructure.Data;
using JapTask1BackendCorrection.Core.Entities;
using JapTask1BackendCorrection.Core.Interfaces.ReportService;
using JapTask1BackendCorrection.Core.Response;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Infrastructure.Services.ReportService
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
        /// <param name="fromDate"> from date </param>
        /// <param name="toDate"> to date </param>
        /// <returns> query result from the database </returns>
        public async Task<ServiceResponse<List<MoviesWithMostScreeningsReport>>> MoviesWithMostScreeningsReport(DateTime fromDate, DateTime toDate)
        {
            return new()
            {
                Data = await _context.MoviesWithMostScreeningsReports
                     .FromSqlRaw("EXEC [dbo].[getTop10MoviesWithMostScreenings] {0}, {1};", fromDate, toDate)
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
