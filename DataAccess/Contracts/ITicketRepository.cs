using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface ITicketRepository
    {
        List<TicketEntity> GetAll();
        void Add(TicketEntity ticket);

        void Update(TicketEntity ticket);

        void Delete(TicketEntity ticket);

    }
}
 