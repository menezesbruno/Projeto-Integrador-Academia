
using Academia.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Academia.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<Treino> Treino { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Treino>().ToTable("Treino");
            modelBuilder.Entity<FormaPagamento>().ToTable("FormaPagameto");
            modelBuilder.Entity<Personal>().ToTable("Personal");
        }

    }
}