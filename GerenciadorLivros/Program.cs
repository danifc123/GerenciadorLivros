using EFModels.DBConfig;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<GerenciadorLivrariaDb>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptions => sqlOptions.MigrationsAssembly(typeof(Program).Assembly.FullName)));
builder.Services.AddOpenApi();

builder.Services.AddAuthorization();

builder.Services.AddGraphQLServer() 
    .AddQueryType<Query>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();
