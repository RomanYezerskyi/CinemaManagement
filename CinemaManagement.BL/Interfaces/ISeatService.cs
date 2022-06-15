using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.BL.Models;

namespace CinemaManagement.BL.Interfaces
{
    public interface ISeatService : ICrud<SeatModel>
    {
        Task<bool> AddRangeAsync(IEnumerable<SeatModel> model);
    }
}
