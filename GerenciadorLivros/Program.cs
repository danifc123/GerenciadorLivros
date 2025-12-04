using EFModels.DBConfig;
using Microsoft.EntityFrameworkCore;
using Repository.AluguelRepository;
using Repository.Alunos;
using Repository.Livros;
using Repository.ProfessorRepository;
using Repository.UsuarioRepository;
using Scalar.AspNetCore;
using Service.AluguelService;
using Service.AlunoService;
using Service.LivroService;
using Service.ProfessorService;
using Service.UsuarioService;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
builder.Services.AddScoped<AlunoRepository>();
builder.Services.AddScoped<LivroRepository>();
builder.Services.AddScoped<ProfessorRepository>();
builder.Services.AddScoped<UsuarioRepository>();

//services
builder.Services.AddScoped<AluguelService>();
builder.Services.AddScoped<AlunoService>();
builder.Services.AddScoped<LivroService>();
builder.Services.AddScoped<ProfessorService>();
builder.Services.AddScoped<UsuarioService>();

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
