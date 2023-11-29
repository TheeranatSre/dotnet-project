
using Microsoft.AspNetCore.Mvc;

namespace dotnet_project.Controllers
{
    public class HealthCheckController : Controller
    {
        [HttpGet("/healthcheck")]
        public String HealCheck()
        {
            return "hello dotnet";
        }
    }
}

