using Microsoft.EntityFrameworkCore;
using Middle.Models;
using Srv.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MiniCourseDbContext>(optionsAction: options => options.UseSqlite(connectionString: "Datasource=./Data/MiniCourseDb.db"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGet("/posts/all", async (MiniCourseDbContext dbContext) =>
{
    List<Post> allposts = await dbContext.Posts.ToListAsync();
    return allposts;

});


app.Run();

