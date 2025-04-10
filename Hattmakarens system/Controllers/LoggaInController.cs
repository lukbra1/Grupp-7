using Hattmakarens_system.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool Login(string username, string password)
        {
            // Hitta användaren baserat på e-post
            var user = _context.User.FirstOrDefault(u => u.Epost == username);

            if (user != null)
            {
                // Jämför lösenordet med det lagrade
                return password == user.LosenordHash;  // Jämför lösenord i klartext
            }

            return false; // Om användaren inte finns eller lösenordet är fel
        }


    }
}

