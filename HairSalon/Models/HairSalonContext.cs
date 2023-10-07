using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public DbSet<Restaurant> Clients { get; set; }
    public DbSet<Cuisine> Stylists {get; set; }

    public HairSalonContext(DbContextOptions options) : base(options) { }
  }
}