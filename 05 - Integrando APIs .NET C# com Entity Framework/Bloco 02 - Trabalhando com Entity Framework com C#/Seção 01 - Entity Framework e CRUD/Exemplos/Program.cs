using Exemplos.Context;
using Microsoft.EntityFrameworkCore;

// Commands
/*
    dotnet tool install --global dotnet-ef - Instalação global do Entity Framework
    dotnet add package Microsoft.EntityFrameworkCore.Design - Instalação para o projeto
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer - Instalação para o projeto
    dotnet-ef migrations add ContactTableCreation - Criação de uma migration com um nome personalizado
    dotnet-ef database update - Aplica as migrations criadas
*/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ContactBookContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
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
