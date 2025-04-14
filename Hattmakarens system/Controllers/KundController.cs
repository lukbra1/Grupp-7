using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;

namespace Hattmakarens_system.Controllers
{
    internal class KundController
    {
        private readonly AppDbContext _context;

        public KundController(AppDbContext context)
        {
            this._context = context;
        }
        public Kund SkapaNyKund(string Fornamn, string Efternamn, string TelefonNr, string Adress)
        {
            Kund kund = new Kund
            {
                Fornamn = Fornamn,
                Efternamn = Efternamn,
                TelefonNr = TelefonNr,
                Adress = Adress,
                //Ordrar = new List<Order>(),
                Aktiv = true
            };
            _context.SaveChanges();
            return kund;
        }
        public List<Kund> AllaAktivaKunder()
        {
            return new List<Kund>(); //_context.Kunder.Where(k => k.Aktiv).ToList();
        }
        public List<Kund> HamtaKunderMedNamn(string ForNamn)
        {
            return new List<Kund>(); 
        }
        public Kund HamtaKundFranFornamn(string ForNamn)
        {
            return new Kund(); //this._context.Kunder.FirstOrDefault(k => k.ForNamn == ForNamn);
        }
        public void RaderaKund(Kund kund)
        {
            //_context.Kunder.Remove(kund);
        }
        public bool ExisterarEpost(string Epost)
        {
            return false; // _context.Kunder.Count(k => k.Epost == Epost);
        }
    }
}
