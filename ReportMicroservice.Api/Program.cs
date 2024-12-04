using Microsoft.EntityFrameworkCore;
using ReportMicroservice.Api.Services;
using ReportMicroservice.Domain.Interfaces;
using ReportMicroservice.Domain.InterfacesServices;
using ReportMicroservice.Infrastructure.Context;
using ReportMicroservice.Infrastructure.Repositories;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IOpTransporteTerrestreService, OpTransporteTerrestreService>();
builder.Services.AddScoped<IOpTransporteTerrestreRepository, OpTransporteTerrestreRepository>();



// Configuración de la base de datos en memoria (TestDbContext)
builder.Services.AddDbContext<TestDbContext>(options =>
    options.UseInMemoryDatabase("STI"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
