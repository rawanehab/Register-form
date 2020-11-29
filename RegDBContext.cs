using Microsoft.EntityFrameworkCore;

public class RegDBContext : DbContext
{
    public DbSet<RegTable> Users { get; set; }
    public RegDBContext(DbContextOptions<RegDBContext> options) 
        : base(options)
    { }
}