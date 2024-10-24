using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var oracleDbConnectionString = builder.Configuration.GetValue<string>("ORACLE_DB_CONNECTION_STRING");
builder.Services.AddDbContext<AppDbContext>(options => options.UseOracle(oracleDbConnectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", () =>
    {
        return "Hello!";
    })
    .WithName("GetWeatherForecast")
    .WithOpenApi();

app.Run();