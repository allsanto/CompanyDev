using Data.Context;
using Data.Repository.Repositories;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<MySqlContext>(options =>
{
    IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();

    var connectionString = configuration.GetConnectionString("DB");
    options.UseMySql(connectionString,
              new MySqlServerVersion(new Version(5, 7)));
});

builder.Services.AddScoped<GerenteService>();
builder.Services.AddScoped<GerenteRepository>();
builder.Services.AddScoped<EquipeRepository>();
builder.Services.AddScoped<EquipeRepository>();
builder.Services.AddScoped<DiretorRepository>();
builder.Services.AddScoped<DiretorRepository>();
builder.Services.AddScoped<FuncionarioRepository>();
builder.Services.AddScoped<FuncionarioRepository>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy =>
{
    policy.AllowAnyOrigin();
    policy.AllowAnyMethod();
    policy.AllowAnyHeader();
    policy.WithExposedHeaders("WWW-Authenticate", "Content-Disposition");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRouting();

app.MapControllers();

app.Run();
