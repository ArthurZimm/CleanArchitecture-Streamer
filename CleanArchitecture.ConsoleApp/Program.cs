using CleanArchitecture.Data;
using CleanArchitecture.Domain;

StreamerDbContext context = new();


void QueryStreaming()
{
	var streamers = context!.Streamers!.ToList();
	foreach (var streamer in streamers)
	{
		Console.WriteLine($"Streamer: {streamer.Id}-{streamer.Name}");
	}
}

async Task AddNewRecords()
{
	Streamer streamer = new()
	{
		Name = "disney",
		Url = "https://www.disney.com"
	};

	context!.Streamers!.Add(streamer);
	await context.SaveChangesAsync();

	var movies = new List<Video>
	{
		new() { Name = "Casa de papel", StreamerId = streamer.Id },
		new() { Name = "Homem Aranha", StreamerId = streamer.Id },
		new() { Name = "Vingadores", StreamerId = streamer.Id },
		new() { Name = "Homem de ferro", StreamerId = streamer.Id }
	};
	await context.AddRangeAsync(movies);
	await context.SaveChangesAsync();
}