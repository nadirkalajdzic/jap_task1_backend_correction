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
