using gestorOficina.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using gestorOficina.Data.Context;
using Microsoft.EntityFrameworkCore;
using gestorOficina.Modelo.Classes;
using gestorOficina.Service;
using gestorOficina.Data.Repositorio;
using gestorOficina.Modelo.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<OficinaContext>(Options => Options.UseNpgsql(builder.Configuration.GetConnectionString("Conn")));

// Serviços próprios
builder.Services.AddScoped<IRepositorio<Estado>, RepositorioEstado>();
builder.Services.AddScoped<IServico<Estado>, Servico<Estado>>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
