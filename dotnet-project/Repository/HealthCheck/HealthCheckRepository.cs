using dotnet_project.Data;

namespace dotnet_project.Repository.HealthCheck
{
    public class HealthCheckRepository : IHealthCheckRepository
    {

        private readonly DotnetProjectContext _context;

        public HealthCheckRepository(DotnetProjectContext context) {
            _context = context;
        }

        public string getMessageHealthCheck()
        {
            var healthcheckEntity = _context.Healthcheck.SingleOrDefault(e => e.id == 1);
            return healthcheckEntity.message;
        }
    }
}