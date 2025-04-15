using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.Controllers
{
    public class Material_OrderradController
    {
        private readonly AppDbContext _context;

        public Material_OrderradController(AppDbContext context)
        {
            this._context = context;
        }

        public MaterialOrderrad NyMaterialOrderrad(Material material,OrderRad orderrad, int antalMaterial)
        {
            
                MaterialOrderrad MaterialOrderrad = new MaterialOrderrad
                {
                    Material = material,
                    OrderRad = orderrad,
                    AntalMaterial = antalMaterial,
                    Bestallt = false,
                };

                return MaterialOrderrad;
            
        }
        
    }
}
