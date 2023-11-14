using Microsoft.EntityFrameworkCore;
using OficinaAPI.Dados.Classes;
using OficinaAPI.Dados.Context;
using OficinaAPI.Dados.Interface;
using OficinaAPI.Modelo.Classes;
using OficinaAPI.Servico.Classes;
using OficinaAPI.Servico.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<OficinaContext>(Options => Options.UseNpgsql(builder.Configuration.GetConnectionString("Conn")));
builder.Services.AddScoped<IRepositorio<Estado>, RepositorioEstado>();
builder.Services.AddScoped<IServico<Estado>, Servico<Estado>>();
builder.Services.AddScoped<IRepositorio<Cidade>, RepositorioCidade>();
builder.Services.AddScoped<IServico<Cidade>, Servico<Cidade>>();
builder.Services.AddScoped<IRepositorio<Bairro>, RepositorioBairro>();
builder.Services.AddScoped<IServico<Bairro>, Servico<Bairro>>();


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
