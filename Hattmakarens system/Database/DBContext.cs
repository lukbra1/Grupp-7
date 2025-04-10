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

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Frakt)
                .WithOne(f => f.Order)
                .HasForeignKey<Frakt>(f => f.OrderID);



            base.OnModelCreating(modelBuilder);

            // Users
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Namn = "Admin", Epost = "admin@example.com", LosenordHash = "hash1", Behorighet = true },
                new User { UserId = 2, Namn = "Medarbetare", Epost = "medarbetare@example.com", LosenordHash = "hash2", Behorighet = false }
            );

            // Kunder
            modelBuilder.Entity<Kund>().HasData(
                new Kund { KundId = 1, ForNamn = "Anna", EfterNamn = "Andersson", Telefon = "0701234567", Epost = "anna@example.com", Adress = "Gatan 1", Aktiv = true },
                new Kund { KundId = 2, ForNamn = "Erik", EfterNamn = "Eriksson", Telefon = "0707654321", Epost = "erik@example.com", Adress = "Vägen 2", Aktiv = true }
            );

            modelBuilder.Entity<Order>().HasData(
    new Order
    {
        OrderId = 1,
        Datum = new DateTime(2024, 12, 1),
        Status = StatusEnum.EjPaborjad,
        Express = false,
        TotalPris = 1000,
        KundId = 1
    },
    new Order
    {
        OrderId = 2,
        Datum = new DateTime(2025, 4, 10), // <-- ersätt DateTime.Now med dagens datum
        Status = StatusEnum.Paborjad,
        Express = true,
        TotalPris = 1500,
        KundId = 2
    }
);


            // Frakt
            modelBuilder.Entity<Frakt>().HasData(
                new Frakt { FraktId = 1, ExportKod = 100, Vikt = 2, Värde = 500, Moms = 25, PrisInkMoms = 625, SkapatDatum = new DateTime(2025, 4, 10), OrderID = 1 },
                new Frakt { FraktId = 2, ExportKod = 200, Vikt = 3, Värde = 700, Moms = 25, PrisInkMoms = 875, SkapatDatum = new DateTime(2025, 4, 10), OrderID = 2 }
            );


            // Hattmodell
            modelBuilder.Entity<Hattmodell>().HasData(
                new Hattmodell { HattModellId = 1, Namn = "Klassisk", Pris = 500, Beskrivning = "En klassisk hatt", Tillgangliga = true },
                new Hattmodell { HattModellId = 2, Namn = "Modern", Pris = 750, Beskrivning = "En modern hatt", Tillgangliga = true }
            );

            // Material
            modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 1, Namn = "Filt", Beskrivning = "Mjukt material" },
                new Material { MaterialId = 2, Namn = "Siden", Beskrivning = "Lyxigt material" }
            );

            // HattmodellMaterial
            modelBuilder.Entity<HattModellMaterial>().HasData(
                new HattModellMaterial { HattModellId = 1, MaterialId = 1, Mangd = 1.5m },
                new HattModellMaterial { HattModellId = 2, MaterialId = 2, Mangd = 2.0m }
            );

            // OrderRad
            modelBuilder.Entity<OrderRad>().HasData(
                new OrderRad
                {
                    OrderRadId = 1,
                    Typ = HattEnum.Lager,
                    Pris = 1000,
                    ReferensBild = null,
                    UserId = 1,
                    HattModellId = 1
                },
                new OrderRad
                {
                    OrderRadId = 2,
                    Typ = HattEnum.Special,
                    Pris = 1500,
                    ReferensBild = null,
                    UserId = 2,
                    HattModellId = 2
                }
            );

            // Anpassning
            modelBuilder.Entity<Anpassning>().HasData(
                new Anpassning { AnpassningId = 1, Typ = "Färg", Varde = "Röd", Anpassningkostnad = 100, OrderRadId = 1 },
                new Anpassning { AnpassningId = 2, Typ = "Storlek", Varde = "L", Anpassningkostnad = 150, OrderRadId = 2 }
            );

            // OrderMaterialStatus
            modelBuilder.Entity<OrderMaterialStatus>().HasData(
                new OrderMaterialStatus { OrderId = 1, MaterialId = 1, Bestallt = true },
                new OrderMaterialStatus { OrderId = 2, MaterialId = 2, Bestallt = false }
            );

            // SpecialHattDetaljer
            modelBuilder.Entity<SpecialHattDetaljer>().HasData(
                new SpecialHattDetaljer
                {
                    SpecialHattId = 1,
                    OrderRadId = 1,
                    Farg = "Blå",
                    Tyg = "Filt",
                    Text = "Initialer",
                    Dekoration = "Fjäder",
                    Storlek = "M",
                    Modell = "Klassisk",
                    Fjader = "Svart",
                    ExtraMaterial = "Snöre",
                    Kommentar = "Ingen"
                },
                new SpecialHattDetaljer
                {
                    SpecialHattId = 2,
                    OrderRadId = 2,
                    Farg = "Grön",
                    Tyg = "Siden",
                    Text = "Logo",
                    Dekoration = "Ros",
                    Storlek = "L",
                    Modell = "Modern",
                    Fjader = "Vit",
                    ExtraMaterial = "Spänne",
                    Kommentar = "Snabb leverans"
                }
            );

            // Tillverkningsschema
            modelBuilder.Entity<Tillverkningsschema>().HasData(
                new Tillverkningsschema { SchemaId = 1, OrderRadId = 1, UserId = 1, Startdatum = new DateTime(2025, 4, 10).AddDays(1), Status = "Ej startad" },
                new Tillverkningsschema { SchemaId = 2, OrderRadId = 2, UserId = 2, Startdatum = new DateTime(2025, 4, 10).AddDays(2), Status = "Startad" }
            );
        

    }

}

}
