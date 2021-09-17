using JapTask1BackendCorrection.DTO.Reports;
using JapTask1BackendCorrection.Entities;
using JapTask1BackendCorrection.Services.ReportService;
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
        public async Task<ActionResult<ServiceResponse<List<MostRatedMoviesReport>>>> MoviesWithMostScreeningsReport([FromBody] DateIntervalDTO dateIntervalDTO)
        {
            return Ok(await _reportsService.MoviesWithMostScreeningsReport(dateIntervalDTO));
        }

        [HttpGet("movies_with_most_sold_tickets")]
        public async Task<ActionResult<ServiceResponse<List<MoviesWithMostSoldTicketsReport>>>> MoviesWithMostSoldTicketsReport()
        {
            return Ok(await _reportsService.MoviesWithMostSoldTicketsReport());
        }

    }
}
