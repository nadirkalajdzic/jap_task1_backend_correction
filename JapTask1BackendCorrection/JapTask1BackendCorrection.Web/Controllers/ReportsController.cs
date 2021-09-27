using JapTask1BackendCorrection.Core.Entities;
using JapTask1BackendCorrection.Core.Interfaces.ReportService;
using JapTask1BackendCorrection.Core.Requests.Reports;
using JapTask1BackendCorrection.Core.Response;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JapTask1BackendCorrection.Controllers
{
    [Route("api/reports")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportService _reportsService;

        public ReportsController(IReportService reportsService)
        {
            _reportsService = reportsService;
        }

        [HttpGet("most_rated_movies")]
        public async Task<ActionResult<ServiceResponse<List<MostRatedMoviesReport>>>> GetMostRatedMoviesReport()
        {
            return Ok(await _reportsService.MostRatedMoviesReport());
        }

        [HttpPost("movies_with_most_screenings")]
        public async Task<ActionResult<ServiceResponse<List<MostRatedMoviesReport>>>> MoviesWithMostScreeningsReport([FromBody] DateIntervalRequest dateIntervalRequest)
        {
            return Ok(await _reportsService.MoviesWithMostScreeningsReport(dateIntervalRequest.StartDate, dateIntervalRequest.EndDate));
        }

        [HttpGet("movies_with_most_sold_tickets")]
        public async Task<ActionResult<ServiceResponse<List<MoviesWithMostSoldTicketsReport>>>> MoviesWithMostSoldTicketsReport()
        {
            return Ok(await _reportsService.MoviesWithMostSoldTicketsReport());
        }

    }
}
