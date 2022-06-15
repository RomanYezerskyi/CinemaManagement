using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAL.Entities
{
    public class BookedSeat
    {
        public int Id { get; set; }
        public int SeatId { get; set; }
        public Seat Seat { get; set; }
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }
    }
}