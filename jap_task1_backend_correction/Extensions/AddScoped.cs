using JapTask1BackendCorrection.Services.AuthService;
using JapTask1BackendCorrection.Services.MediaService;
using JapTask1BackendCorrection.Services.RatingService;
using JapTask1BackendCorrection.Services.ReportService;
using JapTask1BackendCorrection.Services.TicketService;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace JapTask1BackendCorrection.Extensions
{
    public class AddScoped
    {
        public static void AddScopedConfig(ref IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IMediaService, MediaService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IRatingService, RatingService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<ITicketService, TicketService>();
        }
    }
}
