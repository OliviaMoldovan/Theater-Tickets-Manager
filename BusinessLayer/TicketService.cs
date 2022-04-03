using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository repository;

        public TicketService(ITicketRepository repository)
        {
            this.repository = repository;
        }
        public void AddTicketModel(TicketModel ticket)
        {
            repository.Add(new TicketEntity { TicketId = ticket.TicketId, SeatRow = ticket.SeatRow, SeatNr = ticket.SeatNr, ShowId = ticket.ShowId });
        }

        public void UpdateTicketModel(TicketModel ticket)
        {
            repository.Update(new TicketEntity { TicketId = ticket.TicketId, SeatRow = ticket.SeatRow, SeatNr = ticket.SeatNr, ShowId = ticket.ShowId });
        }

        public void DeleteTicketModel(TicketModel ticket)
        {
            repository.Delete(new TicketEntity { TicketId = ticket.TicketId, SeatRow = ticket.SeatRow, SeatNr = ticket.SeatNr, ShowId = ticket.ShowId });
        }

        public List<TicketModel> GetAllTickets()
        {
            List<TicketModel> result = new List<TicketModel>();
            foreach (var x in repository.GetAll())
            {
                result.Add(new TicketModel { TicketId = x.TicketId, SeatRow = x.SeatRow, SeatNr = x.SeatNr, ShowId = x.ShowId });
            }
            return result;
        }

    }
}
