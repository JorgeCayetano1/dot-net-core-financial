using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NetCoreFinancialWeb.Data;


var builder = WebApplication.CreateBuilder(args);
// var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";


builder.Services.AddDbContext<NetCoreFinancialWebContext>(options =>


    options.UseSqlServer(builder.Configuration.GetConnectionString("NetCoreFinancialWebContext") ?? throw new InvalidOperationException("Connection string 'NetCoreFinancialWebContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//services cors
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("http://localhost:8080", "http://192.168.1.74:8080");
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
