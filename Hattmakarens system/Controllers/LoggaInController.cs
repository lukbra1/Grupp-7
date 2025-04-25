using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;

namespace Hattmakarens_system.Controllers
{
    internal class LoggaInController
    {
        private readonly AppDbContext _context;

        public LoggaInController(AppDbContext context)
        {
            _context = context;
        }

        public User HämtaUser(string username, string password)
        {
            return _context.User.FirstOrDefault(u => u.Epost == username && u.Losenord == password);
        }
    }
}

