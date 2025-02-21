using Microsoft.EntityFrameworkCore;
using CatalogoAPI.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string sqlServerConnection = builder.Configuration.GetConnectionString("DefaultConnection"); // String que faz a conexão da API com o banco de dados SQL Server Adicionado no appsettings.json

// Adiciona o contexto do banco de dados ao contêiner de serviços da aplicação
builder.Services.AddDbContext<AppDbContext>(option =>
    // Configura o contexto para usar o SQL Server como provedor de banco de dados
    option.UseSqlServer(sqlServerConnection));

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
