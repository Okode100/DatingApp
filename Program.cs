using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlite(
        builder.Configuration.GetConnectionString("DefaultConnection")
    );
});
builder.Services.AddCors();
//builder.Services.AddOpenApi();

var app = builder.Build();

//Configuration of the Middleware HTTP request 
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins ("http://localhost:4200", "https://localhost:4200"));

app.MapControllers();

app.Run();