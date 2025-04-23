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

        public List<Material> getMaterial()
        {

            return _context.Material.ToList();
        }

        public List<Material> HamtaMaterialMedNamn(string namn)
        {
            return _context.Material
                .Where(m => m.Namn.Contains(namn))
                .ToList();
        }

        public Material HamtaMaterialMedId(int id)
        {
            return _context.Material.FirstOrDefault(m => m.MaterialId == id);
        }

        public void LäggTillMaterialTillOrderRad(int orderRadId, int materialId, int antal)
        {
            var koppling = new MaterialOrderrad
            {
                OrderRadId = orderRadId,
                MaterialId = materialId,
                AntalMaterial = antal,
                Bestallt = false
            };

            _context.MaterialOrderrader.Add(koppling);
            _context.SaveChanges();
        }



        public Material SkapaNyttMaterial(string Namn, string Enhet, string Farg, string Beskrivning)
        {
            try
            {
                Material material = new Material
                {
                    Namn = Namn,
                    Enhet = Enhet,
                    Farg = Farg,
                    Beskrivning = Beskrivning,
                };

                _context.Material.Add(material);
                _context.SaveChanges();

                return material;
            }
            catch (Exception ex)
            {
                // Visa felmeddelande, logga om du vill
                MessageBox.Show("Ett fel inträffade vid registrering av materialet" + ex.Message);
                return null;
            }

        }
    }
}
