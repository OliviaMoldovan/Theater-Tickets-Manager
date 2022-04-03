using System.ComponentModel.DataAnnotations;


namespace DataAccess
{
    public class TicketEntity
    {
        [Key]
        public int TicketId { get; set; }

        public int SeatRow { get; set; }

        public int SeatNr { get; set; }

        public int ShowId { get; set; }

      //  public ShowEntity Show { get; set; }
    }
}
