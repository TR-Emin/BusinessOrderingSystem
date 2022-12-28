using BOS.Admin.Api.BusinessUnit;
using BOS.Admin.Api.DataAccess;
using BOS.Admin.Api.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<BOSContext>(options =>
{
    var connectionStringBuilder = new ConnectionStringBuilder(builder.Configuration);
    options.UseNpgsql(connectionStringBuilder.GetConnectionString());
});




builder.Services.AddTransient<ITestBusinessUnit, TestBusinessUnit>();
builder.Services.AddTransient<ITestDataAccess, TestDataAccess>();






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
