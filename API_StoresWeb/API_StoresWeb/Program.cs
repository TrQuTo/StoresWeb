using API_StoresWeb.Data;
using API_StoresWeb.Repositories;
using API_StoresWeb.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUsers, UsersRepos>();
//builder.Services.AddDbContext<UsersAPIDbContact>(options => options.UseInMemoryDatabase("StoresWebDb"));
builder.Services.AddDbContext<StoresWebAPIDbContact>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("StoresWebAPIConnectionString")));

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
