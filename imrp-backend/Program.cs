using imrp.application.Interfaces;
using imrp.application.Interfaces.UseCases.User;
using imrp.application.Services;
using imrp.application.Use_cases.User;
using imrp.domain.Interfaces;
using imrp.persistence.Database;
using imrp.persistence.Mappers;
using imrp.persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<IrmpDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ImrpDbContext")));

// Logs
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/logs.txt", rollingInterval: RollingInterval.Day)
    .MinimumLevel.Debug()
    .CreateLogger();

builder.Host.UseSerilog();


// Mappers
builder.Services.AddAutoMapper(typeof(UserProfile));
builder.Services.AddScoped(typeof(IMapperService<,>), typeof(MapperService<,>));

// Add services to the container.
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddSingleton<ILoggerService, LoggerService>();
builder.Services.AddScoped(typeof(IMapperService<,>), typeof(MapperService<,>));
builder.Services.AddScoped<UserServices>();

// Add UseCases
builder.Services.AddScoped<IAddUserUseCase, AddUserUseCase>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
