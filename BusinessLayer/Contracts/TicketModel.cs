using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TicketModel
    {
        public int TicketId { get; set; }

        public int SeatRow { get; set; }

        public int SeatNr { get; set; }

        public int ShowId { get; set; }

        //public ShowModel Show { get; set; }
    }
}
