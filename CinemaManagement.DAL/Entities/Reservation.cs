using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAL.Entities
{
    public class Reservation
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }
        public int SessionId { get; set; }
        public Session Session { get; set; }
        public string UserId { get; set; }
        //public User User { get; set; }
        public bool Confirmed { get; set; }
        public ICollection<BookedSeat> BookedSeats { get; set; }
    }
}
