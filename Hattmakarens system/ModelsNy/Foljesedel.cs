using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hattmakarens_system.ModelsNy
{
    public class Foljesedel
    {
        public string Meddelande {  get; set; }
        public int FoljesedelId { get; set; }
        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
