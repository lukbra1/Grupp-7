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
        public Kund SkapaNyKund(string Fornamn, string Efternamn, string TelefonNr, string Epost, string Adress)
        {
            Kund kund = new Kund
            {
                Fornamn = Fornamn,
                Efternamn = Efternamn,
                TelefonNr = TelefonNr,
                Epost = Epost,
                Adress = Adress,
                //Ordrar = new List<Order>(),
                Aktiv = true
            };
            _context.Kunder.Add(kund);
            _context.SaveChanges();
            return kund;
        }
        public List<Kund> AllaAktivaKunder()
        {
            return _context.Kunder.Where(k => k.Aktiv).ToList();
        }
        public List<Kund> HamtaKunderMedNamn(string ForNamn)
        {
            List<Kund> kunder = _context.Kunder.Where(k => k.Fornamn == ForNamn).ToList();
            return kunder;
        }
        public Kund HamtaKundFranId(int KundId)
        {
            return this._context.Kunder.FirstOrDefault(k => k.KundId == KundId);
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

        public List<Kund> HämtaAllaKunder()
        {
            return _context.Kunder.ToList();
        }

        public void TaBortKund(int kundId)
        {
            var kund = _context.Kunder.Find(kundId);
            if (kund != null)
            {
                _context.Kunder.Remove(kund);
                _context.SaveChanges();
            }

        }
    }
}
