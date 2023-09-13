Dictionary<string, List<string>> gamesMap = new()
{
    { "player1", new List<string>() { "Street Fighter II", "Minecraft" } },
    { "player2", new List<string>() { "Forza Horizon 5", "Final Fantasy XIV", "FIFA 23" } },
};

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication().AddJwtBearer();
builder.Services.AddAuthorization();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/playergames", () => gamesMap)
    .RequireAuthorization();

app.Run();