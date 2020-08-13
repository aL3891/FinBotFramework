using Microsoft.EntityFrameworkCore;

namespace FinBotNet
{
    public class BotContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=fbf;User Id=sa;Password=Testtest123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StockPrice>().HasKey(c => new { c.Date, c.StockId });
        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Agent> Agent { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<StockPrice> StockPrice { get; set; }
        public DbSet<Order> Order { get; set; }



    }
}
