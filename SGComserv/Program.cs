using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SGComserv.DbContextApp;

var builder = WebApplication.CreateBuilder(args);

// Adiciona as configurações ao provedor de configuração
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Exemplo: configurando o Entity Framework Core
builder.Services.AddDbContext<SGComServDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1", new OpenApiInfo {
        Title = "SGComserv",
        Description = "API SGComserv",
        Version = "v1",
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
