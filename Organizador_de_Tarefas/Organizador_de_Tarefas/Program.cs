using Microsoft.EntityFrameworkCore;
using Organizador_de_Tarefas.Context;

var builder = WebApplication.CreateBuilder(args);

// Adicionar Uma conex�o com o banco

builder.Services.AddDbContext<TarefaContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoTarefa")));


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
