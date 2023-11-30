using dotnet_project.Models.HealthCheck;
using Microsoft.EntityFrameworkCore;

namespace dotnet_project.Data
{
    public class CoreContext: DbContext
    {
		public IConfiguration Configuration { get; }

        public CoreContext(DbContextOptions<DotnetProjectContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string schema = "dotnet_project";
            modelBuilder.HasDefaultSchema(schema);
            modelBuilder.Entity<HealthcheckEntity>().ToTable("healthcheck");
        }

        public DbSet<HealthcheckEntity> Healthcheck { get; set; }
    }
}

