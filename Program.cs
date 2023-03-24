using DotnetCourse.Interfaces;
using DotnetCourse.Migrations;
using DotnetCourse.Queries;
using DotnetCourse.Services;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
var connectionString = builder.Configuration["ConnectionStrings:DBConnection"];

Console.WriteLine("ConnectionString is: " + connectionString);

// Register your DbContext
builder.Services.AddDbContext<CourseDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Product
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductQueries, ProductQueries>();

// Review
builder.Services.AddScoped<IReviewQueries, ReviewQueries>();

// Reservation
builder.Services.AddScoped<IReservationQueries, ReservationQueries>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

