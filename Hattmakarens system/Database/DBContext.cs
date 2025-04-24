using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hattmakarens_system.ModelsNy;

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
                .HasForeignKey(o => o.KundId)
                .OnDelete(DeleteBehavior.SetNull);

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
                new Material { MaterialId = 1, Namn = "Fjädrar",Enhet = "st", Farg = "Blå", Beskrivning = "Fjädrar kan användas för att lägga till dekoration eller ge en hatt en speciell stil. Fjädrarna kan komma från fåglar som strutsar, påfåglar eller höns." }
            );
            modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 2, Namn = "Tygblommor",Enhet = "st", Farg = "Svart", Beskrivning = "Tygblommor kan användas för att ge en hatt en feminin och romantisk stil." }
            );
            modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 3, Namn = "Pärlor",Enhet = "st", Farg = "Vit", Beskrivning = "Pärlor kan användas för att lägga till en elegant och sofistikerad touch till en hatt." }
            );
            modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 4, Namn = "Lejonman",Enhet = "g", Farg = "Sunsetred", Beskrivning = "Tråd producerad av lejonman utav högsta kvalité direkt från Arkenzoo." }
            );
            modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 5, Namn = "Spets", Enhet = "st", Farg = "Blå", Beskrivning = "Spetsar kan användas för att lägga till en vintage känsla till en hatt." }

            ); modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 6, Namn = "Lackerat papper", Enhet = "Kvdm", Farg = "Lila", Beskrivning = "Lackerat papper kan användas för att skapa en högteknologisk eller futuristisk stil till en hatt." }

            ); modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 7, Namn = "Lurextråd", Enhet = "dm", Farg = "Svart", Beskrivning = "Lurextråd kan användas för att lägga till en glittrig och festlig touch till en hatt." }

            ); modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 8, Namn = "Fuskpäls", Enhet = "Kvdm", Farg = "Svart/Vit-mönstrad", Beskrivning = ": Fuskpäls kan användas för att ge en hatt en mjuk och fluffig yta, eller för att skapa en djurisk känsla." }

            ); modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 17, Namn = "Bomull", Enhet = "Kvdm", Farg = "Vit", Beskrivning = "Bomull är ett mjukt, lätt och andningsbart material som är enkelt att arbeta med. Det används ofta för att tillverka tyghattar, som till exempel kepsar eller basebollmössor." }

            ); modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 18, Namn = "Linne", Enhet = "Kvdm", Farg = "Kräm vit", Beskrivning = "Linne är ett lätt och luftigt material som passar bra för sommarhattar, eftersom det är andningsbart och absorberar fukt." }

            ); modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 19, Namn = "Ull", Enhet = "Kvdm", Farg = "Svart/Vit-mönstrad", Beskrivning = "Ull är ett varmt och isolerande material som passar bra för höst- och vinterhattar, som till exempel mössor och hattar med öronlappar." }

            ); modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 20, Namn = "Silke", Enhet = "Kvdm", Farg = "Silver", Beskrivning = "Silke är ett mjukt och glansigt material som passar bra för eleganta hattar, som till exempel brudhattar eller aftonhattar." }

            ); modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 21, Namn = "Satin", Enhet = "Kvdm", Farg = "Beige", Beskrivning = "Satin är ett mjukt och glansigt material som passar bra för dekorativa detaljer på hattar, som till exempel band eller blommor." }

            ); modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 22, Namn = "Tweed", Enhet = "Kvdm", Farg = "Grön", Beskrivning = "Tweed är ett tjockt och varmt material som passar bra för höst- och vinterhattar." }

            ); modelBuilder.Entity<Material>().HasData(
                new Material { MaterialId = 23, Namn = "Polyester", Enhet = "Kvdm", Farg = "Vit", Beskrivning = ": Polyester är ett tåligt och lätt material som passar bra för sportiga hattar, som till exempel kepsar eller solhattar." }

            );

            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, Skapad = new DateTime(2025, 4, 14), Status = StatusEnum.EjPaborjad, Express = false, TotalPris = 1000, KundId = 1 }
            );

            modelBuilder.Entity<LagerOrderrad>().HasData(
                new LagerOrderrad { OrderRadId = 1, OrderId = 1, UserId = 1, Tillverkad = false, StatusOrderrad = StatusOrderradEnum.EjPaborjad, ModellId = 1}
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
                      OrderID = 1,
                      Adress = "Gatan 1",
                      Avsändare = "Otto AB",
                      Mottagare ="Bob",
                      Beskrivning = "Hatt"

                  }
);

        }
    }
}





