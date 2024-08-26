using Api.Data;
using Microsoft.EntityFrameworkCore;

// create builder
var builder = WebApplication.CreateBuilder(args);

// configure database
// NOTE: do this configuration BEFORE "builder.Build()"!
var DB_CONNECTION_STRING = builder.Configuration.GetConnectionString("DB_CONNECTION_STRING");
builder.Services.AddDbContext<DatabaseContext>(options => options.UseNpgsql(DB_CONNECTION_STRING));

// create app
var app = builder.Build();

// routes
app.MapGet("/", () => "_index");

app.MapGet("/users", async (DatabaseContext database) =>
{
    // retrieve the users from the database!
    // (nice of the route to give us the database to use)
    return await database.Users.ToListAsync();
});

// run the app
app.Run();
