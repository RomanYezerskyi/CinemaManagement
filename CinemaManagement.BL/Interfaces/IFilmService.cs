using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.BL.Models;

namespace CinemaManagement.BL.Interfaces
{
    public interface IFilmService : ICrud<FilmModel>
    {
        //Task<IEnumerable<FilmModel>> GetAllAsync();

        //Task<FilmModel> GetByIdAsync(int id);
        //Task<bool> AddAsync(FilmModel model);

        //Task<bool> UpdateAsync(FilmModel model);

        //Task<bool> DeleteByIdAsync(int modelId);
    }
}
