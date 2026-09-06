using System;
using API.Entitiess;
using  Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace  API.Data;


public class AppDbContext(DbContextOptions Options) : DbContext(Options)
{
    public DbSet<AppUser> Users { get; set; }
    
}

