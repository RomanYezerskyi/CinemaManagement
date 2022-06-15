using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.BL.Models;

namespace CinemaManagement.BL.Interfaces
{
    public interface ISessionService : ICrud<SessionModel>
    {
        //Task<IEnumerable<SessionModel>> GetAllAsync();

        //Task<SessionModel> GetByIdAsync(int id);
        //Task<bool> AddAsync(SessionModel model);

        //Task<bool> UpdateAsync(SessionModel model);

        //Task<bool> DeleteByIdAsync(int modelId);
    }
}
