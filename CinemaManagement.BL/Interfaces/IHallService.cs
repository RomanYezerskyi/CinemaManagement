using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.BL.Models;

namespace CinemaManagement.BL.Interfaces
{
    public interface IHallService : ICrud<HallModel>
    {
        //Task<IEnumerable<HallModel>> GetAllAsync();

        //Task<HallModel> GetByIdAsync(int id);
        //Task<bool> AddAsync(HallModel model);

        //Task<bool> UpdateAsync(HallModel model);

        //Task<bool> DeleteByIdAsync(int modelId);
    }
}
