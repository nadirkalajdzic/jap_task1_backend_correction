using JapTask1BackendCorrection.Core.Entities;
using JapTask1BackendCorrection.Core.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Core.Interfaces.ReportService
{
    public interface IReportService
    {
        Task<ServiceResponse<List<MostRatedMoviesReport>>> MostRatedMoviesReport();
        Task<ServiceResponse<List<MoviesWithMostScreeningsReport>>> MoviesWithMostScreeningsReport(DateTime fromDate, DateTime toDate);
        Task<ServiceResponse<List<MoviesWithMostSoldTicketsReport>>> MoviesWithMostSoldTicketsReport();
    }
}
