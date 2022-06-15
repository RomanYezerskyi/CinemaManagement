using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BL.Models
{
    public class BookedSeatModel
    {
        public int Id { get; set; }
        public int SeatId { get; set; }
        public SeatModel Seat { get; set; }
        public int ReservationId { get; set; }
        public ReservationModel Reservation { get; set; }
    }
}
