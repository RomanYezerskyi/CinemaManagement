using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BL.Models
{
    public class SessionModel
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public FilmModel Film { get; set; }
        public int HallId { get; set; }
        public HallModel Hall { get; set; }
        public DateTime Date { get; set; }
    }
}
