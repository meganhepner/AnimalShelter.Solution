using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; } //change

    public AnimalShelterContext(DbContextOptions options) : base(options) { }
  }
}