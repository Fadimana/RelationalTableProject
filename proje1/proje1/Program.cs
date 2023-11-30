using BusinessLayer.cs.Interface;
using BusinessLayer.cs.Services;
using DataLayer.cs.Context;
using DataLayer.cs.Contrete;
using DataLayer.cs.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBlogRepository, BlogRepository>();
builder.Services.AddScoped<IBlogServices, BlogServices>();
builder.Services.AddScoped<IPostServices, PostServices>();
builder.Services.AddScoped<IPostRepository, PostRepository>();  
// Add services to the container.
builder.Services.AddDbContext<DBContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
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
