using EFModels.DBConfig;
using HotChocolate.Execution.Processing;
using Microsoft.EntityFrameworkCore;
using Repository.AluguelRepository;
using Service.AluguelService;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<GerenciadorLivrariaDb>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptions => sqlOptions.MigrationsAssembly(typeof(Program).Assembly.FullName)));
builder.Services.AddOpenApi();

builder.Services.AddAuthorization();

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddInMemorySubscriptions();

builder.Services.AddControllers();

//repository
builder.Services.AddScoped<AluguelRepository>();

//services
builder.Services.AddScoped<AluguelService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.MapOpenApi();
  app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();
