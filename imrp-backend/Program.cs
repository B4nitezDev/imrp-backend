using imrp_backend.Middlewares;
using imrp.domain.Interfaces;
using imrp.persistence.Database;
using imrp.persistence.DependencyInjection;
using imrp.persistence.Jwt;
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

// Add services to the container.
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddJwtAuthentication(builder.Configuration);
builder.Services.AddTransient<JwtTokenService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<AuthMiddleware>();

app.MapControllers();

app.Run();
