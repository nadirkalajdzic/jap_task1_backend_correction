using jap_task1_backend_correction.DTO.Reports;
using jap_task1_backend_correction.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace jap_task1_backend_correction.Services.ReportsService
{
    public interface IReportsService
    {
        Task<ServiceResponse<List<MostRatedMoviesReport>>> MostRatedMoviesReport();
        Task<ServiceResponse<List<MoviesWithMostScreeningsReport>>> MoviesWithMostScreeningsReport(DateIntervalDTO dateIntervalDTO);
        Task<ServiceResponse<List<MoviesWithMostSoldTicketsReport>>> MoviesWithMostSoldTicketsReport();
    }
}
