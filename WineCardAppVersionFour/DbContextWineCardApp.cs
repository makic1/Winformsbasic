using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WineCardAppVersionFour.Entities;

namespace WineCardAppVersionFour
{
    public class DbContextWineCardApp : DbContext
    {
        public DbContextWineCardApp()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configuaration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuaration.GetConnectionString("default"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Wine>().Property(w => w.Price).HasPrecision(10, 2); // definiert das der Preis 2 komma stellen hat


            modelBuilder.Entity<Account>()
                .HasData
                (new Account
                {
                    AccountId = 1,
                    Username = "admin",
                    HashPassword = BCrypt.Net.BCrypt.HashPassword("admin")
                });
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Wine> Wines { get; set; }
        public DbSet<Winery> Wineries { get; set; }
        public DbSet<WineRegion> WineRegions { get; set; }
        public DbSet<WineCountry> WinesCountries { get; set; }
        public DbSet<WineType> WineTypes { get; set; }
        public DbSet<GrapeVariety> GrapeVarieties { get; set; }
        public DbSet<Vintage> Vintages { get; set; }
        public DbSet<WineCard> WineCards { get; set; }
    }
}
