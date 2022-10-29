using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ServerTask.Data;
using ServerTask.Helper;

var builder = WebApplication.CreateBuilder(args);

var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");
var defaultConnectionString = builder.Configuration.GetConnectionString(ConnectionHelper.BuildConnectionString(databaseUrl));

builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseNpgsql(defaultConnectionString);
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
var scope = app.Services.CreateScope();
await DataHelper.ManageDataAsync(scope.ServiceProvider);

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
