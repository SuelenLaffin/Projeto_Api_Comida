using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    internal class FoodContext : DbContext
    {
        public DbSet<Doce> Doces { get; set; }
        public DbSet<Salgado> Salgados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
          optionBuilder.UseNpgsql("Host=localhost; Port=5436; Database=postgres; UserId=postgres; Password=123456");
        }
    }
}
