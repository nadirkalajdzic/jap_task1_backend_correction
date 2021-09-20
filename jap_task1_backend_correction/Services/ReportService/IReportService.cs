using JapTask1BackendCorrection.DTO.Reports;
using JapTask1BackendCorrection.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Services.ReportService
{
    public interface IReportService
    {
        Task<ServiceResponse<List<MostRatedMoviesReport>>> MostRatedMoviesReport();
        Task<ServiceResponse<List<MoviesWithMostScreeningsReport>>> MoviesWithMostScreeningsReport(DateTime fromDate, DateTime toDate);
        Task<ServiceResponse<List<MoviesWithMostSoldTicketsReport>>> MoviesWithMostSoldTicketsReport();
    }
}
