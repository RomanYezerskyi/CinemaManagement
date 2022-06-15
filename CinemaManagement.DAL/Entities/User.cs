using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CinemaManagement.DAL.Entities
{
    public class User : IdentityUser
    {
        public string LastName { get; set; }
        public string ProfileImage { get; set; }
        public ICollection<Achievement> Achievements { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
