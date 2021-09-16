using jap_task1_backend_correction.Data;
using jap_task1_backend_correction.DTO.Reports;
using jap_task1_backend_correction.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace jap_task1_backend_correction.Services.ReportsService
{
    public class ReportsService : IReportsService
    {
        private readonly DataContext _context;

        public ReportsService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<MostRatedMoviesReport>>> MostRatedMoviesReport()
        {
            var serviceResponse = new ServiceResponse<List<MostRatedMoviesReport>>();

            try
            {
                serviceResponse.Data = await _context.MostRatedMoviesReports.FromSqlRaw("EXEC [dbo].[getTop10MoviesWithMostRatings];")
                                                                            .ToListAsync();
            } catch(Exception)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Internal server error";
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<MoviesWithMostScreeningsReport>>> MoviesWithMostScreeningsReport(DateIntervalDTO dateIntervalDTO)
        {
            var serviceResponse = new ServiceResponse<List<MoviesWithMostScreeningsReport>>();

            try
            {
                serviceResponse.Data = await _context.MoviesWithMostScreeningsReports
                     .FromSqlRaw("EXEC [dbo].[getTop10MoviesWithMostScreenings] {0}, {1};", dateIntervalDTO.StartDate, dateIntervalDTO.EndDate)
                     .ToListAsync();
            } catch(Exception)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Internal server error";
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<MoviesWithMostSoldTicketsReport>>> MoviesWithMostSoldTicketsReport()
        {
            var serviceResponse = new ServiceResponse<List<MoviesWithMostSoldTicketsReport>>();

            try
            {
                serviceResponse.Data = await _context.MoviesWithMostSoldTicketsReports.FromSqlRaw("EXEC [dbo].[getMoviesWithMostSoldTicketsNoRating]")
                                                                                      .ToListAsync();
            } catch(Exception)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Internal server error";
            }

            return serviceResponse;
        }
    }
}
