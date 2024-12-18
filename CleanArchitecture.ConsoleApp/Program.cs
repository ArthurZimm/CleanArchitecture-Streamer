using CleanArchitecture.Data;
using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;

StreamerDbContext context = new();
//await QueryFilter("Netflix");
await AddNewDirectorWithVideo();

async Task AddNewDirectorWithVideo()
{
	var director = new Director()
	{
		Name = "Christopher",
		Surname = "Nolan",
		VideoId = 1
	};
	await context!.AddAsync(director);
	await context.SaveChangesAsync();
}
async Task AddNewActorWithVideo()
{
	var actor = new Actor
	{
		Name = "Robert Downey Jr",
		Surname = "Stark"
	};
	await context!.AddAsync(actor);
	await context.SaveChangesAsync();

	var video = new VideoActor
	{
		ActorId = actor.Id,
		VideoId = 1
	};
	await context.AddAsync(video);
	await context.SaveChangesAsync();
}

async Task AddNewStreamerWithVideoId()
{

	var batman = new Video
	{
		Name = "batman",
		StreamerId = 1002
	};
	await context!.AddAsync(batman);
	await context.SaveChangesAsync();
	
}

void QueryStreaming()
{
	var streamers = context!.Streamers!.ToList();
	foreach (var streamer in streamers)
	{
		Console.WriteLine($"Streamer: {streamer.Id}-{streamer.Name}");
	}
}

async Task QueryFilter(string name)
{
	var streamers = await context!.Streamers!.Where(s => s!.Name!.Equals(name)).ToListAsync();
	foreach (var streamer in streamers)
	{
		Console.WriteLine($"{streamer.Id} - {streamer.Name}");
	}
	var streamerPartialResults = await context!.Streamers!.Where(x => x!.Name!.Contains(name)).ToListAsync();
	foreach (var streamer in streamerPartialResults)
	{
		Console.WriteLine($"{streamer.Id} - {streamer.Name}");

	};
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