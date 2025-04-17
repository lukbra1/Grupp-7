using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.Controllers
{
    internal class MedarbetarController
    {
        private readonly AppDbContext _context;
        public MedarbetarController(AppDbContext context) 
        {
            this._context = context;
        }

        public User SkapaNyUser(string Namn, string Epost, string Lösenord, bool Behörig)
        {
            User user = new User
            {
                Namn = Namn,
                Epost = Epost,
                Losenord = Lösenord,
                Behorighet = Behörig
            };
            _context.User.Add(user);
            _context.SaveChanges();
            return user;
        }
        public List<User> AllaAktivaMedarbetare()
        {
            return new List<User>();
        }
        public List<User> HamtaMedarbetareMedNamn(string Namn)
        {
            List<User> Users = _context.User.Where(k => k.Namn == Namn).ToList();
            return Users;
        }
      
        public void RaderaMedarbetare(User user)
        {
            _context.User.Remove(user);
        }
    }
}
