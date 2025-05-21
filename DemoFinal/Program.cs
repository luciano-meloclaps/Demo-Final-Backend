using Application.Services;
using Microsoft.EntityFrameworkCore;
using Infraestructure;
using Microsoft.Data.Sqlite;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connectionString = builder.Configuration["ConnectionStrings:DemoFinalDBConnectionString"]!;

var connection = new SqliteConnection(connectionString);
connection.Open();

using (var command = connection.CreateCommand())
{
    command.CommandText = "PRAGMA journal_mode = DELETE;";
    command.ExecuteNonQuery();
}
/*
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlite(
builder.Configuration["ConnectionStrings: DBConnectionString"], b => b.MigrationsAssembly("DemoFinal")));
*/

builder.Services.AddDbContext<ApplicationContext>(dbContextOptions => dbContextOptions.UseSqlite(connection, options =>
options.MigrationsAssembly("DemoFinal")));

builder.Services.AddSingleton<ProductService>();
builder.Services.AddSingleton<UserService>();
var app = builder.Build();
//Inyeccion 

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
