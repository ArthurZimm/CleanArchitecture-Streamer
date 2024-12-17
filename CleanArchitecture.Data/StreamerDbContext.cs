using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Data
{
	public class StreamerDbContext : DbContext
	{
        public StreamerDbContext(DbContextOptions<StreamerDbContext> options) : base(options)
        {
            
        }
        public StreamerDbContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-D19QQ33;Persist Security Info=True;User ID=arthur;Password=arthur;Encrypt=False")
				.LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name},LogLevel.Information)
				.EnableSensitiveDataLogging()
				.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
		}
		public DbSet<Streamer>? Streamers { get; set; }
		public DbSet<Video>? Videos{ get; set; }
    }
}
