using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DAL.Entities;

namespace CinemaManagement.BL.Models
{
    public class ReservationModel
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int SessionId { get; set; }

        public SessionModel Session { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public bool Confirmed { get; set; }
        public ICollection<BookedSeatModel> BookedSeats { get; set; }
    }
}
