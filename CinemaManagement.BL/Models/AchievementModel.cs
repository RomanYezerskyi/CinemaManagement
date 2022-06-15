using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CinemaManagement.BL.Models
{
    public class AchievementModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }
        public IFormFile ImagesData { get; set; }
        public int Discount { get; set; }
        public bool Enable { get; set; }
        public string UserId { get; set; }
        //public User User { get; set; }
    }
}
