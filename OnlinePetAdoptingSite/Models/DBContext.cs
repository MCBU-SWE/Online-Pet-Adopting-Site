using Entities.Models;
using Microsoft.EntityFrameworkCore;


namespace PetSoLive.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Veritabanındaki tablolara karşılık gelen DbSet'leri ekleyin
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Veterinarian> Veterinarians { get; set; }

    }
}