using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.BL.Interfaces
{
    public interface ICrud<TModel> where TModel : class
    {
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<TModel> GetByIdAsync(int id);
        Task<bool> AddAsync(TModel model);
        Task<bool> UpdateAsync(TModel model);
        Task<bool> DeleteByIdAsync(int modelId);
    }
}
