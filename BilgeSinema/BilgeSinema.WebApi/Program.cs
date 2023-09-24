using BilgeSinema.Business.Managers;
using BilgeSinema.Business.Services;
using BilgeSinema.Data.Context;
using BilgeSinema.Data.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MovieContext>(options => options.UseInMemoryDatabase("BilgeSinemaDb"));

builder.Services.AddScoped(typeof(IRepository<>), typeof(InMemoryRepository<>));

builder.Services.AddScoped<IMovieService, MovieManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
