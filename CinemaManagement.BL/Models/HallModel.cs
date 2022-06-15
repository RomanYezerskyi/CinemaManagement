using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinemaManagement.BL.Models
{
    public class HallModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<SeatModel> Seats { get; set; }
        public ICollection<SessionModel> SessionModels { get; set; }
    }
}
