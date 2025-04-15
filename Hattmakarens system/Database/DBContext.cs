using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hattmakarens_system.ModelsNy;

//namespace Hattmakarens_system.Database
//{

//    public class AppDbContext : DbContext
//    {
//        public DbSet<User> User { get; set; }
//        public DbSet<Kund> Kunder { get; set; }
//        public DbSet<Hattmodell> Hattmodeller { get; set; }
//        public DbSet<Material> Material { get; set; }
//        public DbSet<HattModellMaterial> HattModellMaterial { get; set; }
//        public DbSet<Order> Ordrar { get; set; }
//        public DbSet<OrderRad> Orderrader { get; set; }
//        public DbSet<SpecialHattDetaljer> SpecialHattar { get; set; }
//        public DbSet<Anpassning> Anpassningar { get; set; }
//        public DbSet<Frakt> Frakter { get; set; }
//        public DbSet<OrderMaterialStatus> Materialstatusar { get; set; }
//        public DbSet<Tillverkningsschema> Tillverkningsscheman { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=HattmakarensScrum7;Trusted_Connection=True;");
//        }

//        // Inuti AppDbContext.cs
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);

//            // Nycklar
//            modelBuilder.Entity<OrderMaterialStatus>().HasKey(oms => new { oms.OrderId, oms.MaterialId });
//            modelBuilder.Entity<HattModellMaterial>().HasKey(hmm => new { hmm.HattModellId, hmm.MaterialId });

//            // Relationer
//            modelBuilder.Entity<SpecialHattDetaljer>()
//                .HasOne(sh => sh.OrderRad)
//                .WithOne()
//                .HasForeignKey<SpecialHattDetaljer>(sh => sh.OrderRadId);

//            modelBuilder.Entity<Anpassning>()
//                .HasOne(a => a.OrderRad)
//                .WithMany()
//                .HasForeignKey(a => a.OrderRadId);

//            modelBuilder.Entity<Frakt>()
//                .HasOne(f => f.Order)
//                .WithOne()
//                .HasForeignKey<Frakt>(f => f.OrderID)
//                .OnDelete(DeleteBehavior.Restrict);

//            modelBuilder.Entity<Tillverkningsschema>()
//                .HasOne(t => t.User)
//                .WithMany()
//                .HasForeignKey(t => t.UserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            modelBuilder.Entity<Order>()
//                .HasOne(o => o.Frakt)
//                .WithOne(f => f.Order)
//                .HasForeignKey<Frakt>(f => f.OrderID);

//            modelBuilder.Entity<OrderRad>()
//                .HasOne(or => or.Order)
//                .WithMany(o => o.OrderRader)
//                .HasForeignKey(or => or.OrderId)
//                .OnDelete(DeleteBehavior.Restrict);

//            // SEED-DATA I RÄTT ORDNING:

//            // 1. Users
//            modelBuilder.Entity<User>().HasData(
//                new User { UserId = 1, Namn = "Admin", Epost = "admin@example.com", LosenordHash = "hash1", Behorighet = true },
//                new User { UserId = 2, Namn = "Medarbetare", Epost = "medarbetare@example.com", LosenordHash = "hash2", Behorighet = false }
//            );

//            // 2. Kunder
//            modelBuilder.Entity<Kund>().HasData(
//                new Kund { KundId = 1, ForNamn = "Anna", EfterNamn = "Andersson", Telefon = "0701234567", Epost = "anna@example.com", Adress = "Gatan 1", Aktiv = true },
//                new Kund { KundId = 2, ForNamn = "Erik", EfterNamn = "Eriksson", Telefon = "0707654321", Epost = "erik@example.com", Adress = "Vägen 2", Aktiv = true }
//            );

////            modelBuilder.Entity<Order>().HasData(
////    new Order
////    {
////        OrderId = 1,
////        Datum = new DateTime(2024, 12, 1),
////        Status = StatusEnum.EjPaborjad,
////        Express = false,
////        TotalPris = 1000,
////        KundId = 1
////    },
////    new Order
////    {
////        OrderId = 2,
////        Datum = new DateTime(2025, 4, 10),
////        Status = StatusEnum.Paborjad,
////        Express = true,
////        TotalPris = 1500,
////        KundId = 2
////    }
////);





//            // Hattmodell

//            // 3. Hattmodell

//            modelBuilder.Entity<Hattmodell>().HasData(
//                new Hattmodell { HattModellId = 1, Namn = "Klassisk", Pris = 500, Beskrivning = "En klassisk hatt", Tillgangliga = true },
//                new Hattmodell { HattModellId = 2, Namn = "Modern", Pris = 750, Beskrivning = "En modern hatt", Tillgangliga = true },
//                new Hattmodell { HattModellId = 3, Namn = "Studentmössa", Pris = 800, Beskrivning = "En studentmössa", Tillgangliga = true },
//                new Hattmodell { HattModellId = 4, Namn = "Doktormössa", Pris = 400, Beskrivning = "En doktormössa", Tillgangliga = true },
//                new Hattmodell { HattModellId = 5, Namn = "Oktoberhatt", Pris = 1000, Beskrivning = "En oktoberhatt", Tillgangliga = true },
//                new Hattmodell { HattModellId = 6, Namn = "Fez hatt", Pris = 300, Beskrivning = "En fez hatt", Tillgangliga = true },
//                new Hattmodell { HattModellId = 7, Namn = "Sherlock hatt", Pris = 1200, Beskrivning = "En Sherlock hatt", Tillgangliga = true }
//            );

//            // 4. Material
//            modelBuilder.Entity<Material>().HasData(
//                new Material { MaterialId = 1, Namn = "Filt", Beskrivning = "Mjukt material" },
//                new Material { MaterialId = 2, Namn = "Siden", Beskrivning = "Lyxigt material" }
//            );

//            // 5. HattmodellMaterial
//            modelBuilder.Entity<HattModellMaterial>().HasData(
//                new HattModellMaterial { HattModellId = 1, MaterialId = 1, Mangd = 1.5m },
//                new HattModellMaterial { HattModellId = 2, MaterialId = 2, Mangd = 2.0m }
//            );

//            // 6. Orders
//            modelBuilder.Entity<Order>().HasData(
//                new Order { OrderId = 1, Datum = new DateTime(2024, 12, 1), Status = StatusEnum.EjPaborjad, Express = false, TotalPris = 1000, KundId = 1 },
//                new Order { OrderId = 2, Datum = new DateTime(2025, 4, 10), Status = StatusEnum.Paborjad, Express = true, TotalPris = 1500, KundId = 2 }
//            );

//            // 7. Frakter
//            modelBuilder.Entity<Frakt>().HasData(
//                new Frakt { FraktId = 1, ExportKod = 100, Vikt = 2, Värde = 500, Moms = 25, PrisInkMoms = 625, SkapatDatum = new DateTime(2025, 4, 10), OrderID = 1 },
//                new Frakt { FraktId = 2, ExportKod = 200, Vikt = 3, Värde = 700, Moms = 25, PrisInkMoms = 875, SkapatDatum = new DateTime(2025, 4, 10), OrderID = 2 }
//            );

//            // 8. Orderrader
//            modelBuilder.Entity<OrderRad>().HasData(
//                new OrderRad { OrderRadId = 1, Typ = HattEnum.Lager, Pris = 1000, ReferensBild = null, UserId = 1, HattModellId = 1, OrderId = 2 },
//                new OrderRad { OrderRadId = 2, Typ = HattEnum.Special, Pris = 1500, ReferensBild = null, UserId = 2, HattModellId = 2, OrderId = 1 }
//            );

//            // 9. Anpassning
//            modelBuilder.Entity<Anpassning>().HasData(
//                new Anpassning { AnpassningId = 1, Typ = "Färg", Varde = "Röd", Anpassningkostnad = 100, OrderRadId = 1 },
//                new Anpassning { AnpassningId = 2, Typ = "Storlek", Varde = "L", Anpassningkostnad = 150, OrderRadId = 2 }
//            );

//            // 10. SpecialHattDetaljer
//            modelBuilder.Entity<SpecialHattDetaljer>().HasData(
//                new SpecialHattDetaljer
//                {
//                    SpecialHattId = 1,
//                    OrderRadId = 1,
//                    Farg = "Blå",
//                    Tyg = "Filt",
//                    Text = "Initialer",
//                    Dekoration = "Fjäder",
//                    Storlek = "M",
//                    Modell = "Klassisk",
//                    Fjader = "Svart",
//                    ExtraMaterial = "Snöre",
//                    Kommentar = "Ingen"
//                },
//                new SpecialHattDetaljer
//                {
//                    SpecialHattId = 2,
//                    OrderRadId = 2,
//                    Farg = "Grön",
//                    Tyg = "Siden",
//                    Text = "Logo",
//                    Dekoration = "Ros",
//                    Storlek = "L",
//                    Modell = "Modern",
//                    Fjader = "Vit",
//                    ExtraMaterial = "Spänne",
//                    Kommentar = "Snabb leverans"
//                }
//            );

//            // 11. Tillverkningsschema
//            modelBuilder.Entity<Tillverkningsschema>().HasData(
//                new Tillverkningsschema { SchemaId = 1, OrderRadId = 1, UserId = 1, Startdatum = new DateTime(2025, 4, 10).AddDays(1), Status = "Ej startad" },
//                new Tillverkningsschema { SchemaId = 2, OrderRadId = 2, UserId = 2, Startdatum = new DateTime(2025, 4, 10).AddDays(2), Status = "Startad" }
//            );

//            // 12. OrderMaterialStatus
//            modelBuilder.Entity<OrderMaterialStatus>().HasData(
//                new OrderMaterialStatus { OrderId = 1, MaterialId = 1, Bestallt = true },
//                new OrderMaterialStatus { OrderId = 2, MaterialId = 2, Bestallt = false }
//            );
//        }


//    }

//}

namespace Hattmakarens_system.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Kund> Kunder { get; set; }
        public DbSet<Order> Ordrar { get; set; }
        public DbSet<OrderRad> Orderrader { get; set; }
        public DbSet<LagerOrderrad> LagerOrderrader { get; set; }
        public DbSet<SpecialOrderrad> SpecialOrderrader { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<Modell> Modeller { get; set; }
        public DbSet<MaterialOrderrad> MaterialOrderrader { get; set; }
        public DbSet<Material_Modell> MaterialModeller { get; set; }
        public DbSet<FraktSedel> Fraktsedlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=HattmakarensAffärsDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Inheritance
            modelBuilder.Entity<OrderRad>()
                .HasDiscriminator<string>("OrderTyp")
                .HasValue<LagerOrderrad>("Lager")
                .HasValue<SpecialOrderrad>("Special");

            // Many-to-Many: Material <-> OrderRad
            modelBuilder.Entity<MaterialOrderrad>()
                .HasKey(mo => new { mo.MaterialId, mo.OrderRadId });

            modelBuilder.Entity<MaterialOrderrad>()
                .HasOne(mo => mo.Material)
                .WithMany()
                .HasForeignKey(mo => mo.MaterialId);

            modelBuilder.Entity<MaterialOrderrad>()
                .HasOne(mo => mo.OrderRad)
                .WithMany()
                .HasForeignKey(mo => mo.OrderRadId);

            // Many-to-Many: Material <-> Modell
            modelBuilder.Entity<Material_Modell>()
                .HasKey(mm => new { mm.MaterialId, mm.ModellId });

            modelBuilder.Entity<Material_Modell>()
                .HasOne(mm => mm.Material)
                .WithMany()
                .HasForeignKey(mm => mm.MaterialId);

            modelBuilder.Entity<Material_Modell>()
                .HasOne(mm => mm.Modell)
                .WithMany()
                .HasForeignKey(mm => mm.ModellId);

            // One-to-Many: Kund -> Order
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Kund)
                .WithMany()
                .HasForeignKey(o => o.KundId);

            // One-to-Many: Order -> OrderRad
            modelBuilder.Entity<OrderRad>()
                .HasOne(or => or.Order)
                .WithMany(o => o.OrderRader)
                .HasForeignKey(or => or.OrderId);

            // One-to-One: Order -> FraktSedel
            modelBuilder.Entity<FraktSedel>()
                .HasOne(fs => fs.Order)
                .WithOne(o => o.FraktSedel)
                .HasForeignKey<FraktSedel>(fs => fs.OrderID);

            // SEED DATA
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Namn = "Admin", Epost = "admin@example.com", Losenord = "admin123", Behorighet = true }
            );

            modelBuilder.Entity<Kund>().HasData(
                new Kund { KundId = 1, Fornamn = "Anna", Efternamn = "Andersson", TelefonNr = "0701234567", Epost = "anna@example.com", Adress = "Gatan 1", Aktiv = true }
            );

            modelBuilder.Entity<Modell>().HasData(
                new Modell { ModellId = 1, Namn = "Studentmössa", Beskrivning = "En klassisk hatt", Tillganglig = true, Pris = 500 },
                new Modell { ModellId = 2, Namn = "Doktormössa", Beskrivning = "En doktormössa", Tillganglig = true, Pris = 400 },
                new Modell { ModellId = 3, Namn = "Oktoberhatt", Beskrivning = "En oktoberhatt", Tillganglig = true, Pris = 1000 },
                new Modell { ModellId = 4, Namn = "Fez hatt", Beskrivning = "En fez hatt", Tillganglig = true, Pris = 300 },
                new Modell { ModellId = 5, Namn = "Sherlock hatt", Beskrivning = "En Sherlock hatt", Tillganglig = true, Pris = 1200 }
            );

            modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 1, Namn = "Snuttefilt", PrisPerEnhet = 100, Enhet = "Kvm", Farg = "Blå", Beskrivning = "Mjukt material." }
            );
            modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 2, Namn = "Läder", PrisPerEnhet = 325, Enhet = "Kvm", Farg = "Svart", Beskrivning = "Färgat Kalv Läder." }
            );
            modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 3, Namn = "Struds Fjäder", PrisPerEnhet = 45, Enhet = "st", Farg = "Vit", Beskrivning = "Fjädrar från den Australiensiska strudsen som endast födar på  japanska böngroddar." }
            );
            modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 4, Namn = "Lejonman", PrisPerEnhet = 15, Enhet = "g", Farg = "Sunsetred", Beskrivning = "Tråd producerad av lejonman utav högsta kvalité direkt från Arkenzoo." }
            );
            modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 5, Namn = "Saphir", PrisPerEnhet = 9000, Enhet = "karat", Farg = "Blå", Beskrivning = "Saphirer från mallorcas östra bergras." }
            ); modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 6, Namn = "Zebrapläd", PrisPerEnhet = 750, Enhet = "m", Farg = "Svart/Vit-mönstrad", Beskrivning = "Pläd ifrån vildfångad zebra i östra Zimbabwe." }
            );
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, Skapad = new DateTime(2025, 4, 14), Status = StatusEnum.EjPaborjad, Express = false, TotalPris = 1000, KundId = 1 }
            );

            modelBuilder.Entity<LagerOrderrad>().HasData(
                new LagerOrderrad { OrderRadId = 1, OrderId = 1, UserId = 1, Tillverkad = false, StatusOrderrad = StatusOrderradEnum.EjPaborjad, ModellId = 1 }
            );

            modelBuilder.Entity<MaterialOrderrad>().HasData(
                new MaterialOrderrad { MaterialId = 1, OrderRadId = 1 }
            );

            modelBuilder.Entity<Material_Modell>().HasData(
                new Material_Modell { MaterialId = 1, ModellId = 1 }
            );
            modelBuilder.Entity<FraktSedel>().HasData(
                  new FraktSedel
                  {
                      FraktSedelId = 1,
                      ExportKod = 100,
                      Vikt = 2,
                      Värde = 800,
                      Moms = 25,
                      PrisInkMoms = 1000,
                      SkapatDatum = new DateTime(2025, 4, 14),
                      OrderID = 1
                  }
);

        }
    }
}





