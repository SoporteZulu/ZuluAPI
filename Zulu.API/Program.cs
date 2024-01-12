using Microsoft.EntityFrameworkCore;
using Zulu.API.Models;
using Serilog;
using Microsoft.Extensions.Configuration;


Log.Logger = new LoggerConfiguration()
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddControllers();



builder.Services.AddDbContext<ZuluContext>(options => options.UseSqlServer(connectionString));


//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Host.UseSerilog(); 


var app = builder.Build();

//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseSerilogRequestLogging();
//app.UseAuthorization();

app.MapControllers();

app.Run();
