using System.Collections.Generic;

namespace CinemaManagement.BL.Models
{
    public class SeatModel
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int RowNum { get; set; }
        public int SeatNum { get; set; }
        public int HallId { get; set; }
        public HallModel Hall { get; set; }
        public ICollection<BookedSeatModel> BookedSeats { get; set; }
    }
}

