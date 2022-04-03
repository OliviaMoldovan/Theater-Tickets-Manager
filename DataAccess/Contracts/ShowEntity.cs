using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ShowEntity
    {
        [Key]
        public int ShowId { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        public string Distribution { get; set; }

        public DateTime Date { get; set; }

        public int NrTickets { get; set; }

        List<TicketEntity> ticketEntities { get; set; }
    }
}
