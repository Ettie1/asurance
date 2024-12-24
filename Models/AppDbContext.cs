using Microsoft.EntityFrameworkCore;

namespace asurance.Models;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}

    public DbSet<Member> Members {get; set;}

}