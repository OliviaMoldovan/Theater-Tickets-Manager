using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TicketRepository : ITicketRepository
    {
        private readonly TheatreDbContext theatreDbContext;
        public TicketRepository(TheatreDbContext theatreDbContext)
        {
            this.theatreDbContext = theatreDbContext;
        }
        public void Add(TicketEntity ticket)
        {
            theatreDbContext.Add(ticket);
            theatreDbContext.SaveChanges();
        }

        public void Update(TicketEntity ticket)
        {
            theatreDbContext.Update(ticket);
            theatreDbContext.SaveChanges();
        }

        public void Delete(TicketEntity ticket)
        {
            if (ticket != null)
            {
                theatreDbContext.Remove(ticket);
                theatreDbContext.SaveChanges();
            }
        }


        public List<TicketEntity> GetAll()
        {
            return theatreDbContext.TicketEntities.ToList();
        }
    }
}
