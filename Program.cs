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

//builder.Services.AddOpenApi();

var app = builder.Build();



app.MapControllers();

app.Run();