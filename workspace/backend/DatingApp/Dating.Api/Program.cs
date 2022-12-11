using Dating.Config;
using Dating.Core.MappingProfiles;
using Dating.Core.Services;
using Dating.Db.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// AutoMapper
builder.Services.AddAutoMapper(opt =>
{
    opt.AddProfile<UserProfile>();
});

// EF Core
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(ConnectionStrings.Default);
});

// Services
builder.Services.AddScoped<WeatherForecastService>();
builder.Services.AddScoped<IUsersService, UsersService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
