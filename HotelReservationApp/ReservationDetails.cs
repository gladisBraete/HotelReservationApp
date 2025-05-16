using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladis_Holtelz
{
    internal class ReservationDetails
    {
        public int Id { get; set; }
        public int ReservationID { get; set; }
        public Room CurrentRoom { get; set; }
    }
}
