using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAL.Entities
{
    public class Seat
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int RowNum { get; set; }
        public int SeatNum { get; set; }
        public int HallId { get; set; }
        public Hall Hall { get; set; }
        public ICollection<BookedSeat> BookedSeats { get; set; }
    }
}
