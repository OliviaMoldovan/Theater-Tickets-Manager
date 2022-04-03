using BusinessLayer;
using DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LayersOnWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService ticketService;
        public TicketsController(ITicketService ticketService)
        {
            this.ticketService = ticketService;
        }


        [HttpGet("ViewSoldTicktes")]
        [Authorize(Roles = "Cashier")]
        public IEnumerable<Ticket> Get()
        {
            var result = new List<Ticket>();
            foreach (var t in ticketService.GetAllTickets())
            {
                result.Add(new Ticket { TicketId = t.TicketId, SeatRow = t.SeatRow, SeatNr = t.SeatNr, ShowId = t.ShowId });
            }
            return result;
        }


        [HttpPost("Sell")]
        [Authorize(Roles = "Cashier")]
        //[Auth]
        public void Post(Ticket ticket)
        {
            ticketService.AddTicketModel(new TicketModel { TicketId = ticket.TicketId, SeatRow = ticket.SeatNr, SeatNr = ticket.SeatRow, ShowId = ticket.ShowId });
        }

        [HttpPut("Edit")]
        [Authorize(Roles = "Cashier")] 
        //[Auth]
        public void Put(Ticket ticket)
        {
            ticketService.UpdateTicketModel(new TicketModel { TicketId = ticket.TicketId, SeatRow = ticket.SeatRow, SeatNr = ticket.SeatNr, ShowId = ticket.ShowId });
        }

        [HttpDelete("CancelReservation")]
        [Authorize(Roles = "Cashier")]
        //[Auth]
        public void Delete(Ticket ticket)
        {
            ticketService.DeleteTicketModel(new TicketModel { TicketId = ticket.TicketId, SeatRow = ticket.SeatRow, SeatNr = ticket.SeatNr, ShowId = ticket.ShowId });
        }
    }
}
