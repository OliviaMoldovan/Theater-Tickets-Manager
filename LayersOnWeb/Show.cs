using System;
using System.Collections.Generic;

namespace LayersOnWeb
{
    public class Show
    {
        public int ShowId { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        public string Distribution { get; set; }

        public DateTime Date { get; set; }

        public int NrTickets { get; set; }

        List<Ticket> ticketEntities { get; set; }

    }
}
