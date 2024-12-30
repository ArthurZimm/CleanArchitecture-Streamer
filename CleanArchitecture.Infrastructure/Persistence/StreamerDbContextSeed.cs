using CleanArchitecture.Domain;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class StreamerDbContextSeed
    {
        public static async Task SeedAsync(StreamerDbContext context, ILogger<StreamerDbContextSeed>logger)
        {
            if(!context.Streamers!.Any())
            {
                context.Streamers!.AddRange(GetPreConfiguredStreamer());
                await context.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(StreamerDbContext).Name);
            }
        }

        private static IEnumerable<Streamer> GetPreConfiguredStreamer()
        {
            return new List<Streamer>
            {
                new Streamer
                {
                    CreatedBy = "Arthur", Name = "Maxi HBP", Url = "https://www.hbo.com"
                },
                new Streamer
                {
                    CreatedBy = "Arthur", Name = "Amazon", Url = "https://www.amazon.com"
                }
        };
        }
    }
}