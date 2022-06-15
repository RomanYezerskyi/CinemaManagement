using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAL.Entities
{
    public class Achievement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Discount { get; set; }
        public bool Enable { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
