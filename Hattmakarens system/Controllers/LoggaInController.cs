using Hattmakarens_system.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hattmakarens_system.ModelsNy;

namespace Hattmakarens_system.Controllers
{
    internal class LoggaInController
    {

        private readonly AppDbContext _context;

        // Injektor för databasåtkomst
        public LoggaInController(AppDbContext context)
        {
            _context = context;
        }

        // Ny metod för att hämta användaren
        public User GetUser(string username, string password)
        {
            // Hitta användaren baserat på e-post och lösenord
            var user = _context.User.FirstOrDefault(u => u.Epost == username && u.Losenord == password);
            return user;  // Returnerar användaren eller null om inget matchar
        }

        public bool Login(string username, string password)
        {
            // Hitta användaren baserat på e-post
            var user = _context.User.FirstOrDefault(u => u.Epost == username);

            if (user != null)
            {
                // Jämför lösenordet med det lagrade
                return password == user.Losenord;  // Jämför lösenord i klartext
            }

            return false; // Om användaren inte finns eller lösenordet är fel
        }

        public User GetLoggedInUser(string username, string password)
        {
            var user = _context.User.FirstOrDefault(u => u.Epost == username && u.Losenord == password);
            return user; // Returnerar null om inte hittad
        }


    }
}

