using JapTask1BackendCorrection.DTO.Reports;
using JapTask1BackendCorrection.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Services.ReportService
{
    public interface IReportService
    {
        Task<ServiceResponse<List<MostRatedMoviesReport>>> MostRatedMoviesReport();
        Task<ServiceResponse<List<MoviesWithMostScreeningsReport>>> MoviesWithMostScreeningsReport(DateIntervalDTO dateIntervalDTO);
        Task<ServiceResponse<List<MoviesWithMostSoldTicketsReport>>> MoviesWithMostSoldTicketsReport();
    }
}
