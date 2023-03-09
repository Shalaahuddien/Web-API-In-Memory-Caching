using ApiCachingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCachingApp.Data;

public class ApiDbContext : DbContext
{

    public DbSet<Driver> Drivers {get; set;}

    public ApiDbContext(DbContextOptions<ApiDbContext> options)
        : base(options)
    {
        
    }
}