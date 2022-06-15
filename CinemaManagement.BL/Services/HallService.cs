using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CinemaManagement.BL.Interfaces;
using CinemaManagement.BL.Models;
using CinemaManagement.DAL.Entities;
using CinemaManagement.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace CinemaManagement.BL.Services
{
    public class HallService : IHallService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HallService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<HallModel>> GetAllAsync()
        {
            var halls = _mapper.Map<IEnumerable<Hall>, IEnumerable<HallModel>>(
                await _unitOfWork.Halls.GetAsync(orderBy: x => x.OrderBy(x => x.Id),
                    includes: x => x.Include(seats => seats.Seats).Include(sessions => sessions.Sessions)));
            return halls;
        }

        public async Task<HallModel> GetByIdAsync(int id)
        {
            var hall = _mapper.Map<Hall, HallModel>(await _unitOfWork.Halls.GetAsync(filter: x => x.Id.Equals(id),
                includes: x => x.Include(seats => seats.Seats)
                    .Include(session => session.Sessions)));
            return hall;
        }

        public async Task<bool> AddAsync(HallModel model)
        {
            if (model.Title == null) throw new Exception("The hall must contain a name");
            var hallModel = _mapper.Map<HallModel, Hall>(model);
            var hall = new Hall()
            {
                Sessions = hallModel.Sessions,
                Seats = hallModel.Seats,
                Title = hallModel.Title,
            };
            await _unitOfWork.Halls.InsertAsync(hall);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> UpdateAsync(HallModel model)
        {
            if (model.Title == null) throw new Exception("The hall must contain a name");
            var hall = _mapper.Map<HallModel, Hall>(model);
            _unitOfWork.Halls.Update(hall);
            return await _unitOfWork.SaveAsync();
        }

        public async Task<bool> DeleteByIdAsync(int modelId)
        {
            var hall = await _unitOfWork.Halls.GetAsync(null, x => x.Id == modelId);
            if (hall == null) throw new Exception("No data");
            _unitOfWork.Halls.Delete(hall);
            return await _unitOfWork.SaveAsync();
        }
    }
}
