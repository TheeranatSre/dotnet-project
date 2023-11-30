using Microsoft.EntityFrameworkCore;

namespace dotnet_project.Data
{
	public class DotnetProjectContext : CoreContext
	{
		public DotnetProjectContext(DbContextOptions<DotnetProjectContext> options, IConfiguration configuration) : base(options, configuration)
		{ }
	}
}
