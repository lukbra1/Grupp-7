using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hattmakarens_system.Models;

namespace Hattmakarens_system.Database
{

    public class AppDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Kund> Kunder { get; set; }
        public DbSet<Hattmodell> Hattmodeller { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<HattModellMaterial> HattModellMaterial { get; set; }
        public DbSet<Order> Ordrar { get; set; }
        public DbSet<OrderRad> Orderrader { get; set; }
        public DbSet<SpecialHattDetaljer> SpecialHattar { get; set; }
        public DbSet<Anpassning> Anpassningar { get; set; }
        public DbSet<Frakt> Frakter { get; set; }
        public DbSet<OrderMaterialStatus> Materialstatusar { get; set; }
        public DbSet<Tillverkningsschema> Tillverkningsscheman { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=HattmakarensScrum7;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderMaterialStatus>()
                .HasKey(oms => new { oms.OrderId, oms.MaterialId });

            modelBuilder.Entity<HattModellMaterial>()
                .HasKey(hmm => new { hmm.HattModellId, hmm.MaterialId });

            modelBuilder.Entity<SpecialHattDetaljer>()
                .HasOne(sh => sh.OrderRad)
                .WithOne()
                .HasForeignKey<SpecialHattDetaljer>(sh => sh.OrderRadId);

            modelBuilder.Entity<Anpassning>()
                .HasOne(a => a.Order)
                .WithMany()
                .HasForeignKey(a => a.OrderRadId);

            modelBuilder.Entity<Frakt>()
                .HasOne(f => f.Order)
                .WithOne()
                .HasForeignKey<Frakt>(f => f.OrderID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Tillverkningsschema>()
        .HasOne(t => t.User)
        .WithMany()
        .HasForeignKey(t => t.UserId)
        .OnDelete(DeleteBehavior.Restrict);
        }

    }

}
