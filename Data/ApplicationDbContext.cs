using Microsoft.EntityFrameworkCore;
using SelfCheckoutMachine.Models;

namespace SelfCheckoutMachine.Data
{
    public class ApplicationDbContext : DbContext
    {
        private static readonly List<Currency> currenciesInit = new List<Currency>
        {
            new Currency{ Id = 1, Unit = 5, Amount = 0 },
            new Currency{ Id = 2, Unit = 10, Amount = 0 },
            new Currency{ Id = 3, Unit = 20, Amount = 0 },
            new Currency{ Id = 4, Unit = 50, Amount = 0 },
            new Currency{ Id = 5, Unit = 100, Amount = 0 },
            new Currency{ Id = 6, Unit = 200, Amount = 0 },
            new Currency{ Id = 7, Unit = 500, Amount = 0 },
            new Currency{ Id = 8, Unit = 1000, Amount = 0 },
            new Currency{ Id = 9, Unit = 2000, Amount = 0 },
            new Currency{ Id = 10, Unit = 5000, Amount = 0 },
            new Currency{ Id = 11, Unit = 10000, Amount = 0 },
            new Currency{ Id = 12, Unit = 20000, Amount = 0 },
        };

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Currency> Currencies { get; set; }

        // Seed database with every type of currency
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(currenciesInit);
        }
    }
}
