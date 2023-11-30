
using dotnet_project.Models.HealthCheck;
using dotnet_project.Repository.HealthCheck;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_project.Controllers
{
    public class HealthCheckController : Controller
    {

        private readonly IHealthCheckRepository _healthCheckRepository;

        public HealthCheckController(IHealthCheckRepository healthCheckRepository)
        {
            _healthCheckRepository = healthCheckRepository;
        }

        [HttpGet("/healthcheck")]
        public HealthCheckResponse HealCheck()
        {
            var response = new HealthCheckResponse();
            response.status = _healthCheckRepository.getMessageHealthCheck();
            response.version = Environment.GetEnvironmentVariable("API_VERSION");
            return response;
        }
    }
}

