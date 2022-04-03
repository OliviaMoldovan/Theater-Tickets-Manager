using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface ITicketService
    {
        List<TicketModel> GetAllTickets();

        void AddTicketModel(TicketModel ticket);

        void UpdateTicketModel(TicketModel ticket);

        void DeleteTicketModel(TicketModel ticket);


    }
}
