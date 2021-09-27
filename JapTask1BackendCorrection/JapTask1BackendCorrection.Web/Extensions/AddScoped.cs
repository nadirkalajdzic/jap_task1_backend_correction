using JapTask1BackendCorrection.Core.Interfaces.AuthService;
using JapTask1BackendCorrection.Core.Interfaces.MediaService;
using JapTask1BackendCorrection.Core.Interfaces.RatingService;
using JapTask1BackendCorrection.Core.Interfaces.ReportService;
using JapTask1BackendCorrection.Core.Interfaces.TicketService;
using JapTask1BackendCorrection.Infrastructure.Services.AuthService;
using JapTask1BackendCorrection.Infrastructure.Services.MediaService;
using JapTask1BackendCorrection.Infrastructure.Services.RatingService;
using JapTask1BackendCorrection.Infrastructure.Services.ReportService;
using JapTask1BackendCorrection.Infrastructure.Services.TicketService;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace JapTask1BackendCorrection.Web.Extensions
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
