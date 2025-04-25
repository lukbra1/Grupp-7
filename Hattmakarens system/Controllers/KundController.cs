using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;

namespace Hattmakarens_system.Controllers
{
    internal class KundController
    {
        private readonly AppDbContext _context;

        public KundController(AppDbContext context)
        {
            _context = context;
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

        public List<Kund> HamtaKunderMedNamn(string sokNamn)
        {
            List<Kund> kunder = _context.Kunder.Where(k => k.Aktiv && (k.Fornamn.Contains(sokNamn) || k.Efternamn.Contains(sokNamn))).ToList();
            return kunder;
        }

        public Kund HamtaKundFranId(int KundId)
        {
            return _context.Kunder.FirstOrDefault(k => k.KundId == KundId);
        }

        public List<Kund> HämtaAllaKunder()
        {
            return _context.Kunder.ToList();
        }

        public bool TaBortKund(int kundId)
        {
            var kund = _context.Kunder.Find(kundId);
            if (kund != null)
            {
                kund.Aktiv = false;
                _context.Kunder.Update(kund);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
