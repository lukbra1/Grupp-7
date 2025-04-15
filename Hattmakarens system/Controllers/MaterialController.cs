using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hattmakarens_system.Controllers
{
    public class MaterialController
    {

        private readonly AppDbContext _context;

        public MaterialController(AppDbContext context)
        {
            this._context = context;
        }

        public List<Material> getMaterial() {
            
        return _context.Material.ToList();
        }
    }
}
