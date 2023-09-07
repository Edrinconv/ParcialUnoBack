using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using ParcialUno.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ParcialCorteUnoContext>(options => options.UseSqlServer("Server=DESKTOP-A8KULQ5\\SQLEXPRESS;Database=ParcialCorteUno; Trusted_Connection=true;MultipleActiveResultSets=true"));
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
